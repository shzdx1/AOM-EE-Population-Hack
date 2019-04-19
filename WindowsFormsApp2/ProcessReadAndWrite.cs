using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text;

namespace AOMEE
{

    class ProcessReadAndWrite
    {
        const int PROCESS_ALL_ACCESS = 0x001F0FFF;
        const int PROCESS_WM_READ = 0x0010; // constante requerida para leer en un proceso
        const int PROCESS_VM_WRITE = 0x0020; // constante requerida para escribir en un proceso
        const int PROCESS_VM_OPERATION = 0x0008; // permiso requerido para escribir
        int BASE_ADDRESS = 0x0;

        Process process;

        #region DLL IMPORT
        // Importo las DLL requeridas para escribir en procesos y leer.
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);
        #endregion

        public ProcessReadAndWrite()
        {
            process = Process.GetProcessesByName("aomx")[0];
            // le sumo 0x1000 porque es la diferencia que hay entre dbgx32 y esta instruccion
            BASE_ADDRESS = process.MainModule.BaseAddress.ToInt32() + 0x1000;
        }

        public int ReadMemory(int address, byte[] buffer)
        {
            int fixedAddress = BASE_ADDRESS + address;

            IntPtr processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, process.Id);
            if (processHandle == IntPtr.Zero)
            {
                var eCode = Marshal.GetLastWin32Error();
            }
            int bytesRead = 0;

            bool success = ReadProcessMemory((int)processHandle, address, buffer, buffer.Length, ref bytesRead);

            //CloseHandle(processHandle);
   
            int i = BitConverter.ToInt16(buffer, 0);

            return i;
        }

        public bool WriteMemory(int address, byte[] bytes)
        {
            int fixedAddress = BASE_ADDRESS + address;

            IntPtr processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, process.Id);

            int bytesWritten = 0;

            bool success = WriteProcessMemory((int)processHandle, fixedAddress, bytes, bytes.Length, ref bytesWritten);
            return success;
        }
    }
}
