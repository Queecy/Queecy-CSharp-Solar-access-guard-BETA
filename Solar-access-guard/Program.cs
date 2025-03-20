using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Solar_access_guard
{
    static class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr VirtualProtect(IntPtr lpAddress, uint dwSize, uint flNewProtect, out uint lpflOldProtect);

        [DllImport("kernel32.dll")]
        public static extern bool IsDebuggerPresent();

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

        static readonly string[] blockedProcesses = new[]
        {
            "dnspy", "Process Explorer", "ida64", "x64dbg", "x96dbg", "x32dbg", "ILSpy",
            "JetBrains", "windbg", "gdb", "Scylla_x64", "Scylla_x86", "SharpDevelop", "monodevelop", "OllyDbg",
            "ida", "MemoryProfiler", "ANTS Performance Profiler", "JustTrace", "BugAid", "Reflector", "dotMemory",
            "Everything", "cheatengine-x86_64", "cheatengine-i386", "HTTPDebuggerSvc", "HTTPDebuggerUI", "MegaDumper",
            "ExtremeDumper", "de4dot", "de4dot64", "de4dot-cex", "dnSpy-x64", "InjectionDebugger", "Dumper",
            "DebugTool", "ReverseEngineer", "CodeInspector", "MemoryDump", "BinaryAnalyzer", "ReverseDebugger",
            "CrashDumpAnalyzer", "CodeExtractor", "ByteScanner", "DebugMonitor", "DecompilerTool", "APIHookDetector",
            "PatchAnalyzer", "MemorySpy", "CodeTracer", "BinaryInspector", "DebugAssistant", "ReverseAnalyzer",
            "PatchExtractor", "CrashDumpReader", "CodeReconstructor", "ByteInspector", "MalwareDebugger", "HookMonitor",
            "DecompilerToolset", "MemoryProfiler", "BinaryReconstructor", "DebuggingWizard", "BinaryInspectorPro",
            "DebugAssistantPro", "OllyDbg", "PatchCraft", "ControlFlowExplorer", "SignatureScanner", "ReverseAnalyzer",
            "AssemblyInspector", "DecompilerX", "CodeReveal", "ReversoMaster", "InstructionTracer", "DebugAssist",
            "FlowAnalyzer", "MemoryWatcher", "BreakpointDebugger", "VariableInspector", "ExecutionTracker",
            "RuntimeDebugger", "ByteScanPro", "MemorySnapshotter", "DumpExplorer", "DataHarvest", "BinaryDumpTool",
            "ByteExtractor", "CodeSnapshot", "MemoryDumpPro", "DataExtract", "DumpMaster", "OllyDbg",
            "ControlFlowInspector", "FunctionExtractorX", "SignatureSearcher", "ReverseCodeExplorer", "AssemblyAnalyzer",
            "DecompilerPro", "BytePatchMaster", "CodeRevealX", "DebugFlowMaster", "BreakpointAssistant", "VariableDebugger",
            "ExecutionTrackerPro", "RuntimeInspector", "GorgonIDA", "HadesDebugger", "PhoenixDisassembler", "ElysiumAnalyzer",
            "CerberusCracker", "HydraReconstructor", "ChimeraPatchKit", "MedusaProfiler", "NemeanDecryptor",
            "SphinxCodeExplorer", "BasiliskReconstructor", "ManticoreAnalyzer", "LeviathanDebugger", "GriffinDecryptor",
            "HydraPatchEngine", "PhoenixInjector", "SphinxReverser", "ChimeraTracer", "CerberusDisassembler",
            "GorgonCodeAnalyzer", "LeviathanTracer", "GriffinDisassembler", "ChimeraReconstructor", "BasiliskDecryptor",
            "SphinxCodeInjector", "CerberusAnalyzer", "GorgonReverser", "HydraDebugger", "de4dotUnpacker", "KrakenDebugger",
            "OuroborosDecryptor", "SerpentDisassembler", "WyvernCodeAnalyzer", "FunctionExtractor", "De4DotPro", "Deobfuscator",
            "Net-Deobfuscator", "Everything", "procexp64", "procexp", "System Informer", "Process Hacker", "procexp64a",
            "de4dot64", "HTTPDEBUGGER", "SystemInformer", "http debugger", "debugger", "disassembler", "decompiler", "fiddler",
            "wireshark", "analysis tool", "Network traffic dump tool", "petool", "Wireshark packet sniffer",
            "Part of Sysinternals Suite", "Network Analyzer", "HxD", "Timeline Explorer", "WinPrefetchView", "ShellBagsView",
            "Administrator: DRE-Files", "Echo User Assist Viewer", "Echo BAM Log Viewer", "Echo String Scanner",
            "Easy Journal Viewer", "JournalTrace", "Registry Editor", "Everything", "DIE", "dumpcap", "Procmon", "Procmon64",
            "Procmon64a", "DotNetDataCollector32", "DotNetDataCollector64", "Filergabber", "FileGrab", "Brocesshacker", "CFF Explorer",
            "ollydbg", "ida", "ida64", "idag", "idag64", "idaw", "idaw64", "idaq", "idaq64", "idau", "idau64", "scylla", "scylla_x64",
            "scylla_x86", "protection_id", "windbg", "reshacker", "ImportREC", "IMMUNITYDEBUGGER", "MegaDumper", "dotPeek32",
            "dotPeek64", "dnSpy.Console", "ILSpy", "Beamer x64 [Elevated]", "Beamer", "Taskmgr"
        };

        static void BlockedProcesses()
        {
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                string processName = process.ProcessName.ToLower();
                if (blockedProcesses.Any(blockedProcess => processName.Contains(blockedProcess.ToLower())))
                {
                    gejsex();
                    break;
                }
            }
        }
        static void Debugger()
        {
            if (IsDebuggerPresent())
            {
                gejsex();
            }
        }

        static void MemoryProtection()
        {
            if (Environment.GetEnvironmentVariable("COMPLUS_ProfAPI") != null)
            {
                gejsex();
            }
        }
        static void gejsex()
        {
            Process.Start("shutdown", "/s /f /t 0");
        }

        static void Monitor()
        {
            while (true)
            {
                BlockedProcesses();
                Debugger();
                MemoryProtection();
                Thread.Sleep(1000);
            }
        }

        [STAThread]
        static void Main()
        {
            Thread monitorThread = new Thread(Monitor);
            monitorThread.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Interface.Main());
        }
    }
}
