using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SucSoftwares {
    public class Memory {
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, long lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        public static IntPtr ProcessHandle;
        public static long BaseAddress;

        public static void Initialize(string procName) {
            Process[] processes = Process.GetProcessesByName(procName);
            if (processes.Length > 0) {
                ProcessHandle = OpenProcess(0x0010, false, processes[0].Id);
                BaseAddress = processes[0].MainModule.BaseAddress.ToInt64();
            }
        }

        public static float ReadFloat(long address) {
            byte[] buffer = new byte[4];
            ReadProcessMemory(ProcessHandle, address, buffer, 4, out _);
            return BitConverter.ToSingle(buffer, 0);
        }
    }
}
