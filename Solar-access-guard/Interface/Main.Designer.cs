namespace Solar_access_guard.Interface
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.FormBorderLess = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.LoadingBar = new Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar();
            this.secure_panel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.password_1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.authorize_password = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.mfa_panel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label3 = new System.Windows.Forms.Label();
            this.mfa_code = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.auth_mfa = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.password2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label4 = new System.Windows.Forms.Label();
            this.password2_input = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.auth_password2 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.secure_panel.SuspendLayout();
            this.mfa_panel.SuspendLayout();
            this.password2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormBorderLess
            // 
            this.FormBorderLess.BorderRadius = 15;
            this.FormBorderLess.ContainerControl = this;
            this.FormBorderLess.DockForm = false;
            this.FormBorderLess.DockIndicatorTransparencyValue = 1D;
            this.FormBorderLess.DragStartTransparencyValue = 1D;
            this.FormBorderLess.HasFormShadow = false;
            this.FormBorderLess.ResizeForm = false;
            this.FormBorderLess.ShadowColor = System.Drawing.Color.White;
            this.FormBorderLess.TransparentWhileDrag = true;
            // 
            // LoadingBar
            // 
            this.LoadingBar.Animated = true;
            this.LoadingBar.AnimationSpeed = 1F;
            this.LoadingBar.BackColor = System.Drawing.Color.Transparent;
            this.LoadingBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadingBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.LoadingBar.FillThickness = 5;
            this.LoadingBar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.LoadingBar.ForeColor = System.Drawing.Color.White;
            this.LoadingBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.LoadingBar.Image = ((System.Drawing.Image)(resources.GetObject("LoadingBar.Image")));
            this.LoadingBar.ImageSize = new System.Drawing.Size(90, 90);
            this.LoadingBar.InnerColor = System.Drawing.Color.Transparent;
            this.LoadingBar.Location = new System.Drawing.Point(209, 349);
            this.LoadingBar.Minimum = 0;
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.LoadingBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.LoadingBar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
            this.LoadingBar.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.LoadingBar.ProgressThickness = 5;
            this.LoadingBar.ShowText = true;
            this.LoadingBar.Size = new System.Drawing.Size(157, 157);
            this.LoadingBar.TabIndex = 168;
            this.LoadingBar.TextMode = Siticone.Desktop.UI.WinForms.Enums.ProgressBarTextMode.Custom;
            this.LoadingBar.UseTransparentBackground = true;
            this.LoadingBar.Value = 25;
            // 
            // secure_panel
            // 
            this.secure_panel.BackColor = System.Drawing.Color.Transparent;
            this.secure_panel.Controls.Add(this.label1);
            this.secure_panel.Controls.Add(this.password_1);
            this.secure_panel.Controls.Add(this.authorize_password);
            this.secure_panel.Location = new System.Drawing.Point(151, 349);
            this.secure_panel.Name = "secure_panel";
            this.secure_panel.Size = new System.Drawing.Size(273, 106);
            this.secure_panel.TabIndex = 172;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 145;
            this.label1.Text = "Password";
            // 
            // password_1
            // 
            this.password_1.Animated = true;
            this.password_1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.password_1.BorderRadius = 4;
            this.password_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_1.DefaultText = "";
            this.password_1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.password_1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.password_1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            this.password_1.ForeColor = System.Drawing.Color.Gray;
            this.password_1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_1.Location = new System.Drawing.Point(14, 27);
            this.password_1.Name = "password_1";
            this.password_1.PasswordChar = '\0';
            this.password_1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_1.PlaceholderText = "";
            this.password_1.SelectedText = "";
            this.password_1.Size = new System.Drawing.Size(245, 29);
            this.password_1.TabIndex = 159;
            // 
            // authorize_password
            // 
            this.authorize_password.Animated = true;
            this.authorize_password.AnimatedGIF = true;
            this.authorize_password.BorderRadius = 5;
            this.authorize_password.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.authorize_password.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.authorize_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.authorize_password.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.authorize_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.authorize_password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.authorize_password.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.authorize_password.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.authorize_password.ForeColor = System.Drawing.Color.White;
            this.authorize_password.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.authorize_password.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.authorize_password.Location = new System.Drawing.Point(14, 62);
            this.authorize_password.Name = "authorize_password";
            this.authorize_password.Size = new System.Drawing.Size(245, 30);
            this.authorize_password.TabIndex = 155;
            this.authorize_password.Text = "Authorize";
            this.authorize_password.Click += new System.EventHandler(this.authorize_password_Click);
            // 
            // mfa_panel
            // 
            this.mfa_panel.BackColor = System.Drawing.Color.Transparent;
            this.mfa_panel.Controls.Add(this.label3);
            this.mfa_panel.Controls.Add(this.mfa_code);
            this.mfa_panel.Controls.Add(this.auth_mfa);
            this.mfa_panel.Location = new System.Drawing.Point(151, 349);
            this.mfa_panel.Name = "mfa_panel";
            this.mfa_panel.Size = new System.Drawing.Size(273, 106);
            this.mfa_panel.TabIndex = 174;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(11, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 14);
            this.label3.TabIndex = 145;
            this.label3.Text = "MFA";
            // 
            // mfa_code
            // 
            this.mfa_code.Animated = true;
            this.mfa_code.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.mfa_code.BorderRadius = 4;
            this.mfa_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mfa_code.DefaultText = "";
            this.mfa_code.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mfa_code.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mfa_code.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mfa_code.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mfa_code.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.mfa_code.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.mfa_code.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            this.mfa_code.ForeColor = System.Drawing.Color.Gray;
            this.mfa_code.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mfa_code.Location = new System.Drawing.Point(14, 27);
            this.mfa_code.Name = "mfa_code";
            this.mfa_code.PasswordChar = '\0';
            this.mfa_code.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mfa_code.PlaceholderText = "";
            this.mfa_code.SelectedText = "";
            this.mfa_code.Size = new System.Drawing.Size(245, 29);
            this.mfa_code.TabIndex = 159;
            // 
            // auth_mfa
            // 
            this.auth_mfa.Animated = true;
            this.auth_mfa.AnimatedGIF = true;
            this.auth_mfa.BorderRadius = 5;
            this.auth_mfa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.auth_mfa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.auth_mfa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.auth_mfa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.auth_mfa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.auth_mfa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.auth_mfa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.auth_mfa.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.auth_mfa.ForeColor = System.Drawing.Color.White;
            this.auth_mfa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.auth_mfa.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.auth_mfa.Location = new System.Drawing.Point(14, 62);
            this.auth_mfa.Name = "auth_mfa";
            this.auth_mfa.Size = new System.Drawing.Size(245, 30);
            this.auth_mfa.TabIndex = 155;
            this.auth_mfa.Text = "Authorize";
            this.auth_mfa.Click += new System.EventHandler(this.auth_mfa_Click);
            // 
            // password2
            // 
            this.password2.BackColor = System.Drawing.Color.Transparent;
            this.password2.Controls.Add(this.label4);
            this.password2.Controls.Add(this.password2_input);
            this.password2.Controls.Add(this.auth_password2);
            this.password2.Location = new System.Drawing.Point(151, 349);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(273, 106);
            this.password2.TabIndex = 176;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(11, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 145;
            this.label4.Text = "Password 2";
            // 
            // password2_input
            // 
            this.password2_input.Animated = true;
            this.password2_input.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.password2_input.BorderRadius = 4;
            this.password2_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password2_input.DefaultText = "";
            this.password2_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password2_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password2_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password2_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password2_input.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.password2_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.password2_input.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            this.password2_input.ForeColor = System.Drawing.Color.Gray;
            this.password2_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password2_input.Location = new System.Drawing.Point(14, 27);
            this.password2_input.Name = "password2_input";
            this.password2_input.PasswordChar = '\0';
            this.password2_input.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password2_input.PlaceholderText = "";
            this.password2_input.SelectedText = "";
            this.password2_input.Size = new System.Drawing.Size(245, 29);
            this.password2_input.TabIndex = 159;
            // 
            // auth_password2
            // 
            this.auth_password2.Animated = true;
            this.auth_password2.AnimatedGIF = true;
            this.auth_password2.BorderRadius = 5;
            this.auth_password2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.auth_password2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.auth_password2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.auth_password2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.auth_password2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.auth_password2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.auth_password2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.auth_password2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.auth_password2.ForeColor = System.Drawing.Color.White;
            this.auth_password2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.auth_password2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.auth_password2.Location = new System.Drawing.Point(14, 62);
            this.auth_password2.Name = "auth_password2";
            this.auth_password2.Size = new System.Drawing.Size(245, 30);
            this.auth_password2.TabIndex = 155;
            this.auth_password2.Text = "Authorize";
            this.auth_password2.Click += new System.EventHandler(this.auth_password2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(575, 350);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.mfa_panel);
            this.Controls.Add(this.secure_panel);
            this.Controls.Add(this.LoadingBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.secure_panel.ResumeLayout(false);
            this.secure_panel.PerformLayout();
            this.mfa_panel.ResumeLayout(false);
            this.mfa_panel.PerformLayout();
            this.password2.ResumeLayout(false);
            this.password2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm FormBorderLess;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleProgressBar LoadingBar;
        private Siticone.Desktop.UI.WinForms.SiticonePanel secure_panel;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox password_1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton authorize_password;
        private Siticone.Desktop.UI.WinForms.SiticonePanel mfa_panel;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox mfa_code;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton auth_mfa;
        private Siticone.Desktop.UI.WinForms.SiticonePanel password2;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox password2_input;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton auth_password2;
    }
}