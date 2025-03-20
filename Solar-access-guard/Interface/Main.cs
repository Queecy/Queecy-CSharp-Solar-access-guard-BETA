using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net.Http;
using Google.Cloud.Firestore;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using Google.Cloud.Firestore.V1;
using System.IO;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OtpNet;

namespace Solar_access_guard.Interface
{
    public partial class Main : Form
    {
        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        public delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);
        private static IntPtr _keyboardHookID = IntPtr.Zero;
        private static IntPtr _mouseHookID = IntPtr.Zero;
        private static LowLevelKeyboardProc _keyboardProc = HookCallbackKeyboard;
        private static LowLevelMouseProc _mouseProc = HookCallbackMouse;

        private static IntPtr HookCallbackKeyboard(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                bool isAllowedKey =
                    (vkCode >= 0x30 && vkCode <= 0x39) ||
                    (vkCode >= 0x41 && vkCode <= 0x5A) ||
                    vkCode == 0x0D ||
                    (vkCode >= 0x60 && vkCode <= 0x69) ||
                    (vkCode >= 0x70 && vkCode <= 0x7B) ||
                    vkCode == 0x08;

                if (isAllowedKey)
                {
                    return CallNextHookEx(_keyboardHookID, nCode, wParam, lParam);
                }

                return (IntPtr)1;
            }
            return CallNextHookEx(_keyboardHookID, nCode, wParam, lParam);
        }

        private static IntPtr HookCallbackMouse(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                return (IntPtr)1;
            }

            return CallNextHookEx(_mouseHookID, nCode, wParam, lParam);
        }

        public static void BlockKeyboard()
        {
            _keyboardHookID = SetHookKeyboard(_keyboardProc);
        }

        public static void BlockMouse()
        {
            _mouseHookID = SetHookMouse(_mouseProc);
        }

        public static void UnblockKeyboard()
        {
            UnhookWindowsHookEx(_keyboardHookID);
        }

        public static void UnblockMouse()
        {
            UnhookWindowsHookEx(_mouseHookID);
        }

        private static IntPtr SetHookKeyboard(LowLevelKeyboardProc proc)
        {
            using (var curProcess = System.Diagnostics.Process.GetCurrentProcess())
            using (var curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(13, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private static IntPtr SetHookMouse(LowLevelMouseProc proc)
        {
            using (var curProcess = System.Diagnostics.Process.GetCurrentProcess())
            using (var curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(14, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        FirestoreDb database;
        public Main()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            TopMost = true;

            BlockKeyboard();
            BlockMouse();

            password_1.KeyDown += Password_1_KeyDown;
            password2_input.KeyDown += Password2_Input_KeyDown;
            mfa_code.KeyDown += Mfa_Code_KeyDown;
        }

        private void Password_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                authorize_password_Click(sender, e);
            }
        }

        private void Password2_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                auth_password2_Click(sender, e);
            }
        }

        private void Mfa_Code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                auth_mfa_Click(sender, e);
            }
        }

        private void TurnOffPc()
        {
            Process.Start("shutdown", "/s /f /t 0");
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            await MoveControl(LoadingBar, 86); // Hide 209, 349 / Show 209, 86
            await Task.Delay(2000);
            string path = @"config.json-location";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("project-id");

            await ForceTurnOffPc();
            await GetPassword_1();
            password_1.Focus();
            await GetPassword_2();

            string systemUUID = GetUUID();
            string externalIP = await GetIP();
            var storedData = await GetData();

            bool uuidMatch = (systemUUID == storedData.UUID);
            List<string> systemUSBSerialNumbers = GetUSBSerialNumbers();
            bool usbMatch = systemUSBSerialNumbers.Contains(storedData.USB_ID_1) && systemUSBSerialNumbers.Contains(storedData.USB_ID_2);
            bool ipMatch = (externalIP == storedData.IP);

            if (uuidMatch && usbMatch && ipMatch)
            {
                await MoveControl(LoadingBar, LoadingBar.Top + 350);
                await SendTelegramNotification("SUCCESS_VERIFY_DEVICE");
                await MoveControl(secure_panel, 110);  // Hide 151, 349 / Show 151, 110
            }
            else
            {
                List<string> errors = new List<string>();

                if (!uuidMatch)
                    errors.Add("ERROR_UUID");

                if (!usbMatch)
                    errors.Add("ERROR_VIRTUAL_KEY");

                if (!ipMatch)
                    errors.Add("ERROR_IP");

                string warsawTime = DateTime.UtcNow.AddHours(1).ToString("yyyy-MM-dd HH:mm:ss");
                errors.Add($"Time: {warsawTime}");

                await SendTelegramNotification(string.Join("\n", errors));
                await SetForceTurnOffPc(true);
                TurnOffPc();
            }
        }

        private async Task<(string UUID, string USB_ID_1, string USB_ID_2, string IP)> GetData()
        {
            var documentRef = database.Collection("Access").Document("COMPUTER");
            var documentSnapshot = await documentRef.GetSnapshotAsync();

            if (documentSnapshot.Exists)
            {
                string storedUUID = documentSnapshot.GetValue<string>("UUID");
                string storedUSB_ID_1 = documentSnapshot.GetValue<string>("USB_ID_1");
                string storedUSB_ID_2 = documentSnapshot.GetValue<string>("USB_ID_2");
                string storedIP = documentSnapshot.GetValue<string>("IP");

                return (storedUUID, storedUSB_ID_1, storedUSB_ID_2, storedIP);
            }
            else
            {
                return (null, null, null, null);
            }
        }

        private async Task<bool> ForceTurnOffPc()
        {
            var documentRef = database.Collection("Access").Document("PC_CONTROL");
            var documentSnapshot = await documentRef.GetSnapshotAsync();

            if (documentSnapshot.Exists)
            {
                bool forceTurnOff = documentSnapshot.GetValue<bool>("FORCE_TURN_OFF_PC");
                if (forceTurnOff)
                {
                    TurnOffPc();
                }

                return forceTurnOff;
            }
            else
            {
                return false;
            }
        }

        private async Task<string> GetPassword_1()
        {
            var documentRef = database.Collection("Access").Document("COMPUTER");
            var documentSnapshot = await documentRef.GetSnapshotAsync();

            if (documentSnapshot.Exists)
            {
                string storedPassword = documentSnapshot.GetValue<string>("PASSWORD_1");
                return storedPassword;
            }
            else
            {
                throw new Exception("Password not found in Firestore");
            }
        }

        private async Task<string> GetPassword_2()
        {
            var documentRef = database.Collection("Access").Document("COMPUTER");
            var documentSnapshot = await documentRef.GetSnapshotAsync();

            if (documentSnapshot.Exists)
            {
                string storedPassword2 = documentSnapshot.GetValue<string>("PASSWORD_2");
                return storedPassword2;
            }
            else
            {
                throw new Exception("Password not found in Firestore");
            }
        }

        private async Task SetForceTurnOffPc(bool value)
        {
            var documentRef = database.Collection("Access").Document("PC_CONTROL");
            await documentRef.UpdateAsync("FORCE_TURN_OFF_PC", value);
        }

        private static string GetUUID()
        {
            string uuid = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystemProduct");

            foreach (ManagementObject obj in searcher.Get())
            {
                uuid = obj["UUID"].ToString();
                break;
            }

            return uuid;
        }

        private static async Task<string> GetIP()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "https://api.ipify.org";
                    string externalIP = await client.GetStringAsync(url);
                    return externalIP;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<string> GetUSBSerialNumbers()
        {
            List<string> serialNumbers = new List<string>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE MediaType='Removable Media'");

            foreach (ManagementObject obj in searcher.Get())
            {
                if (obj["SerialNumber"] != null)
                {
                    serialNumbers.Add(obj["SerialNumber"].ToString());
                }
            }

            return serialNumbers;
        }

        private async Task<(string token, string chatId)> GetTelegramData()
        {
            var documentRef = database.Collection("Access").Document("TELEGRAM");
            var documentSnapshot = await documentRef.GetSnapshotAsync();

            if (documentSnapshot.Exists)
            {
                string token = documentSnapshot.GetValue<string>("APP_TOKEN");
                string chatId = documentSnapshot.GetValue<string>("CHAT_ID");

                if (!string.IsNullOrEmpty(token) && !string.IsNullOrEmpty(chatId))
                {
                    return (token, chatId);
                }
            }

            return (null, null);
        }

        private async Task SendTelegramNotification(string message)
        {
            var (token, chatId) = await GetTelegramData();

            if (!string.IsNullOrEmpty(token) && !string.IsNullOrEmpty(chatId))
            {
                string url = $"https://api.telegram.org/bot{token}/sendMessage?chat_id={chatId}&text={Uri.EscapeDataString(message)}";

                using (HttpClient client = new HttpClient())
                {
                    await client.GetAsync(url);
                }
            }
        }

        private async Task MovePanel(Panel panel, int targetTop)
        {
            await SlideEffect(panel, targetTop);
        }

        private async Task MoveControl(Control control, int targetTop)
        {
            await SlideEffect(control, targetTop);
        }

        private async Task SlideEffect(Control control, int targetTop)
        {
            int startTop = control.Top;
            int distance = targetTop - startTop;

            double duration = 400;
            int frames = 50;
            double frameTime = duration / frames;

            for (int frame = 0; frame <= frames; frame++)
            {
                double t = (double)frame / frames;
                double easedT = EaseInOutQuad(t);
                int newTop = startTop + (int)(distance * easedT);

                control.Top = newTop;
                await Task.Delay((int)frameTime);
            }

            control.Top = targetTop;
        }

        private double EaseInOutQuad(double t)
        {
            return t < 0.5 ? 2 * t * t : 1 - Math.Pow(-2 * t + 2, 2) / 2;
        }

        private async void authorize_password_Click(object sender, EventArgs e)
        {
            string storedPassword = await GetPassword_1(); 
            string inputPassword = password_1.Text;
            bool isMFAEnabled = await GetMFA();

            if (inputPassword == storedPassword)
            {
                if (isMFAEnabled)
                {
                    await MoveControl(secure_panel, secure_panel.Top + 350); 
                    await MoveControl(mfa_panel, 110); // Hide 151, 349 / Show 151, 110
                    mfa_code.Focus();
                }
                else
                {
                    await MoveControl(secure_panel, secure_panel.Top + 350);
                    await MoveControl(password2, 110); // Hide 151, 349 / Show 151, 110
                    password2_input.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid Password");
                await SetForceTurnOffPc(true);
                TurnOffPc();
            }
        }

        private async void auth_password2_Click(object sender, EventArgs e)
        {
            string storedPassword2 = await GetPassword_2();
            string inputPassword = password2_input.Text;

            if (inputPassword == storedPassword2)
            {
                await MoveControl(password2, password2.Top + 350);
                await MoveControl(LoadingBar, 86);
                await SendTelegramNotification("Access to a computer has been obtained");
                MessageBox.Show("OK OK OK DONE! [wait 2s]");
                await Task.Delay(2000);
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("Invalid Password");
                await SetForceTurnOffPc(true);
                TurnOffPc();
            }
        }

        private async Task<bool> GetMFA()
        {
            var documentRef = database.Collection("Access").Document("COMPUTER");
            var documentSnapshot = await documentRef.GetSnapshotAsync();

            if (documentSnapshot.Exists)
            {
                return documentSnapshot.GetValue<bool>("MFA");
            }
            else
            {
                return false;
            }
        }

        private async Task<bool> GetMfaSecret(string mfaCode)
        {
            var documentRef = database.Collection("Access").Document("COMPUTER");
            var documentSnapshot = await documentRef.GetSnapshotAsync();

            if (documentSnapshot.Exists)
            {
                string storedMFASecret = documentSnapshot.GetValue<string>("MFA_SECRET");
                if (IsValidMFA(mfaCode, storedMFASecret))
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsValidMFA(string enteredCode, string mfaSecret)
        {
            byte[] secretBytes = Base32Encoding.ToBytes(mfaSecret);
            var totp = new Totp(secretBytes);
            bool isValid = totp.VerifyTotp(enteredCode, out long timeStepMatched, new VerificationWindow(2, 2));

            return isValid;
        }

        private async void auth_mfa_Click(object sender, EventArgs e)
        {
            string mfaCode = mfa_code.Text;

            if (await GetMfaSecret(mfaCode))
            {
                await MoveControl(mfa_panel, mfa_panel.Top + 350);
                await MoveControl(password2, 110);
                password2_input.Focus();
            }
            else
            {
                MessageBox.Show("Invalid MFA Code");
                await SetForceTurnOffPc(true);
                TurnOffPc();
            }
        }
    }
}