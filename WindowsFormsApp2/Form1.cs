using System;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace AOMEE
{
    public partial class Form1 : Form
    {
        ProcessReadAndWrite pRaW;
        bool isMaxPopEdited = false;
        int editedMaxPop = 0;

        public Form1()
        {
            InitializeComponent();

            pRaW = new ProcessReadAndWrite();

            Thread info = new Thread(UpdateInfo);
            info.IsBackground = true;
            info.Start();
        }

        bool CheckIfProcessAvailable()
        {
            if (pRaW.process == null && pRaW.SetAOMProcess() == false)
            {
                ShowError("Error: Age of Mythology is Closed. Please, open the game to continue.");
                isMaxPopEdited = false;
            }
            else if (pRaW.process != null && pRaW.SetAOMProcess() == false)
            {
                ShowError("Error: Age of Mythology is Closed. Please, open the game to continue.");
                isMaxPopEdited = false;
            }
            else if(!pRaW.EnoughPermissions())
            {
                ShowError("Error: Access is denied. Not enough permissions.\n" +
                    "You are running AOM as administrator but this program is not running as administrator. Please, open this program as administrator.");
            } else
            {
                EnableForms(true);
                return true;
            }
            return false;
        }

        private void UpdateInfo()
        {
            // update general information every second
            while (true)
            {
                if (!CheckIfProcessAvailable())
                {
                    Thread.Sleep(4000);
                    continue;
                }

                pRaW.OpenProcess();

                int maxPop = isMaxPopEdited? editedMaxPop : GetPlayerMaxPopulation(1);
                int popCap = GetMaxPopulationCapacity(1);
                try
                {
                    Invoke((MethodInvoker)delegate ()
                    {
                        MaxPopValue.Text = maxPop.ToString();
                        PopCapValue.Text = popCap.ToString();
                    });
                }
                catch (InvalidOperationException) { }

                Thread.Sleep(700);
            }
        }

        public void EnableForms(bool action)
        {
            try
            {
                Invoke((MethodInvoker)delegate ()
                {
                    TotalMaxPopConfirm.Enabled = action;
                    TotalPopReset.Enabled = action;
                    TotalMaxPop.Enabled = action;


                    CurrentMaxPopConfirm.Enabled = action;
                    MaxPopReset.Enabled = action;
                    CurrentMaxPop.Enabled = action;

                    if (action == true) InfoBox.Hide();
                    else InfoBox.Show();
                });
            }
            catch (InvalidOperationException) { }
        }

        public void ShowError(string description)
        {
            try
            {
                Invoke((MethodInvoker)delegate ()
                {
                    EnableForms(false);
                    InfoBox.Text = description;
                });
            }
            catch (InvalidOperationException) { }
        }

        private int GetMaxPopulationCapacity(int PlayerID)
        {
            int popCapAddress = pRaW.GetBaseAddress() + 0x296BEA;

            byte[] pcBytes = new byte[4];

            pRaW.ReadMemory(popCapAddress, pcBytes);
            int popCap = BitConverter.ToInt32(pcBytes, 0);
            return popCap;
        }

        private int GetPlayerMaxPopulation(int playerID)
        {
            // p = player
            int pAddressSeed = pRaW.GetBaseAddress() + 0x84843C; // first constant
            int seedAddress = pRaW.GetBaseAddress() + 0x7AE5D0;
            uint playersAddress = 0;
            uint decryptSeed = 0; // second constant
            uint pAddressPointer = 0;

            byte[] seedBuffer = new byte[4];
            pRaW.ReadMemory(seedAddress, seedBuffer);
            decryptSeed = BitConverter.ToUInt32(seedBuffer, 0);

            byte[] pDynamicSeedBytes = new byte[4];
            pRaW.ReadMemory(pAddressSeed, pDynamicSeedBytes);
            // eaxByteAddress + 0x140 is where the next address is located
            int pDynamicAddress = BitConverter.ToInt32(pDynamicSeedBytes, 0) + 0x140;

            byte[] pAddressPointerBytes = new byte[4];
            pRaW.ReadMemory(pDynamicAddress, pAddressPointerBytes);
            // this address is an array of the current players in game (incluiding mother Nature) 
            // with useful data for decrypt every player information like population, resources, etc
            pAddressPointer = BitConverter.ToUInt32(pAddressPointerBytes, 0) + 0x7C;

            // emulating the function at aomx.exe+0x292EB0
            uint eax = (uint)playerID;
            uint ebpMinus4 = eax;
            eax = decryptSeed;
            uint ecx = ebpMinus4;
            ecx += ecx;
            eax = RotateLeft(eax, (int)ecx);
            uint ebpMinus8 = eax;

            byte[] edxPlus38Bytes = new byte[4];
            pRaW.ReadMemory((int)pAddressPointer, edxPlus38Bytes);
            playersAddress = BitConverter.ToUInt32(edxPlus38Bytes, 0);

            byte[] playerDecryptByte = new byte[4];
            pRaW.ReadMemory((int)playersAddress + (int)playerID * 4, playerDecryptByte);
            int playerDecryptInfo = BitConverter.ToInt32(playerDecryptByte, 0);

            byte[] edxPlus38Bytes2 = new byte[4];
            pRaW.ReadMemory(playerDecryptInfo + 0x38, edxPlus38Bytes2);
            uint edxPlus38 = BitConverter.ToUInt32(edxPlus38Bytes2, 0);
            eax = edxPlus38;
            eax = eax ^ ebpMinus8;

            return (int)eax; // max population
        }

        private void SetMaxPop(int pop)
        {
            int address = pRaW.GetBaseAddress() + 0x294666;

            // MOV EDX, POPULATION
            byte[] maxPopInstrucction = {
                0xB8, // MOV
                (byte)(pop & 0xff),
                (byte)((pop >> 8) & 0xff),
                0x00,
                0x00,
                0xC3, // nop
            };
            pRaW.WriteMemory(address, maxPopInstrucction);
            isMaxPopEdited = true;
            editedMaxPop = pop;
        }

        private void ResetMaxPop()
        {
            int address = pRaW.GetBaseAddress() + 0x294666;

            // 6 bytes: ret, int3, int3, int3, int3, int3
            byte[] mpRestorationBytes =
            {
                0xC3,
                0xCC,
                0xCC,
                0xCC,
                0xCC,
                0xCC
            };
            pRaW.WriteMemory(address, mpRestorationBytes);
            isMaxPopEdited = false;
        }

        private void SetMaxPopCap(int popCap)
        {
            int popCapOffset = pRaW.GetBaseAddress() + 0x297F61;
            Console.WriteLine(popCapOffset);
            int popCapOffset2 = pRaW.GetBaseAddress() + 0x297F73;
            int validationOffset = pRaW.GetBaseAddress() + 0x297F7B;


            // one byte for EAX and two bytes for max cap population
            byte[] offset1Bytes = new byte[3];

            offset1Bytes[0] = 0xB8;
            offset1Bytes[1] = (byte)(popCap & 0xff);
            offset1Bytes[2] = (byte)((popCap >> 8) & 0xff);

            // one byte for EAX, two bytes for max cap population and one byte for nop
            byte[] offset2Bytes = { offset1Bytes[0], offset1Bytes[1], offset1Bytes[2], 0x00, 0x00, 0x90 };

            // nop nop nop
            byte[] nops = { 0x90, 0x90, 0x90 };


            pRaW.WriteMemory(popCapOffset, offset1Bytes);
            pRaW.WriteMemory(popCapOffset2, offset2Bytes);
            //pRaW.WriteMemory(validationOffset, nops);
        }

        private void ResetMaxPopCap()
        {
            int popCapOffset = pRaW.GetBaseAddress() + 0x297F61;
            int popCapOffset2 = pRaW.GetBaseAddress() + 0x297F73;
            int validationOffset = pRaW.GetBaseAddress() + 0x297F7B;


            // MOV EAX, 12C
            byte[] offset1Bytes = new byte[3];

            offset1Bytes[0] = 0xB8;
            offset1Bytes[1] = (byte)(300 & 0xff);
            offset1Bytes[2] = (byte)((300 >> 8) & 0xff);

            // MOV EAX, DWORD PTR DS:[ECX+0x768]
            byte[] offset2Bytes = { 0x8B, 0x81, 0x68, 0x07, 0x00, 0x00 };

            // CMOVLE EAX, EDX
            byte[] cmovle = { 0x0F, 0x4E, 0xC2 };


            pRaW.WriteMemory(popCapOffset, offset1Bytes);
            pRaW.WriteMemory(popCapOffset2, offset2Bytes);
            pRaW.WriteMemory(validationOffset, cmovle);
        }

        private void CurrentMaxPopConfirm_Click(object sender, EventArgs e)
        {
            int maxPop = 0; // 65535 max popcap
            bool parsed = int.TryParse(CurrentMaxPop.Text, out maxPop);
            if (!parsed) maxPop = int.MaxValue;
            SetMaxPop(maxPop);
        }

        private void TotalMaxPop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int popCap = 0; // 65535 max popcap
                bool parsed = int.TryParse(TotalMaxPop.Text, out popCap);
                if (!parsed) popCap = int.MaxValue;
                SetMaxPopCap(popCap);
            }
        }

        private void TotalPopReset_Click(object sender, EventArgs e)
        {
            TotalMaxPop.Clear();
            ResetMaxPopCap();
        }

        private void TotalMaxPopConfirm_Click(object sender, EventArgs e)
        {
            int popCap = 0; // 65535 max popcap
            bool parsed = int.TryParse(TotalMaxPop.Text, out popCap);
            if (!parsed) popCap = int.MaxValue;
            SetMaxPopCap(popCap);
        }

        private uint RotateLeft(uint value, int count)
        {
            return (value << count) | (value >> (32 - count));
        }

        private void CurrentMaxPop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int maxPop = 0; // 65535 max popcap
                bool parsed = int.TryParse(CurrentMaxPop.Text, out maxPop);
                if (!parsed) maxPop = int.MaxValue;
                SetMaxPop(maxPop);
            }
        }

        private void MaxPopReset_Click(object sender, EventArgs e)
        {
            CurrentMaxPop.Clear();
            ResetMaxPop();
        }

        private void InfoBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
