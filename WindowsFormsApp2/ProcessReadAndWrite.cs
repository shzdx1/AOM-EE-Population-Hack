using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace AOMEE
{

    class ProcessReadAndWrite
    {
        // required constants for memory access
        const int PROCESS_ALL_ACCESS = 0x001F0FFF;
        const int PROCESS_WM_READ = 0x0010; 
        const int PROCESS_VM_WRITE = 0x0020; 
        const int PROCESS_VM_OPERATION = 0x0008; 
        
        // base address, where base memory address for aomx.exe starts.
        int BASE_ADDRESS = 0x0;

        public Process process;
        IntPtr processHandle;
        Form1 form1;

        #region DLL IMPORT
        // Required dlls for memory read and write
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);
        #endregion

        public ProcessReadAndWrite(Form1 form1)
        {
            this.form1 = form1;
            SetAOMProcess();
            if(process != null)
            {
                OpenProcess();
            }
        }

        public bool SetAOMProcess()
        {
            try
            {
                process = Process.GetProcessesByName("aomx")[0];
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
            return true;
        }

        public bool OpenProcess()
        {
            // added 0x1000 to the base address because x64dbg
            BASE_ADDRESS = process.MainModule.BaseAddress.ToInt32() + 0x1000;

            processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, process.Id);

            return (int)processHandle != 0;
        }

        public bool ReadMemory(int address, byte[] buffer)
        {
            if (process != null && process.HasExited) return false;

            int bytesRead = 0;
            bool success = ReadProcessMemory((int)processHandle, address, buffer, buffer.Length, ref bytesRead);

            return success;
        }

        public bool WriteMemory(int address, byte[] bytes)
        {
            if (process != null && process.HasExited) return false;

            int bytesWritten = 0;
            bool success = WriteProcessMemory((int)processHandle, address, bytes, bytes.Length, ref bytesWritten);

            return success;
        }

        public int GetBaseAddress()
        {
            return BASE_ADDRESS;
        }
    }
}
