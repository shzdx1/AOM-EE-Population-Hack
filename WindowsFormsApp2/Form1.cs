using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOMEE
{
    public partial class Form1 : Form
    {
        ProcessReadAndWrite processReadAndWrite;

        public Form1()
        {
            processReadAndWrite = new ProcessReadAndWrite();
            InitializeComponent();
        }

        private void SetMaxPopCap(int popCap)
        {
            int popCapOffset = 0x296BEA;
            int secondValidationOffset = 0x296C09;

            // nop nop nop
            byte[] nops = { 0x90, 0x90, 0x90 };

            // two bytes for max cap population
            byte[] bytesToWrite = new byte[2];

            bytesToWrite[0] = (byte)(popCap & 0xff);
            bytesToWrite[1] = (byte)((popCap >> 8) & 0xff);

            processReadAndWrite.WriteMemory(popCapOffset, bytesToWrite);
            processReadAndWrite.WriteMemory(secondValidationOffset, nops);

        }

        private void ResetMaxPopCap()
        {
            int popCapOffset = 0x296BEA;
            int secondValidationOffset = 0x296C09;

            byte[] pop300 = { 0x12, 0x0C}; // 12C = 300 = 300 population cap
            byte[] secondValidationBytes = { 0x0F, 0x4F, 0xC1}; // cmovg eax, ecx

            // restore original memory data
            processReadAndWrite.WriteMemory(popCapOffset, pop300);
            processReadAndWrite.WriteMemory(secondValidationOffset, secondValidationBytes);
        }

        private void CurrentMaxPopConfirm_Click(object sender, EventArgs e)
        {
        }

        private void TotalMaxPop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int popCap = int.Parse(TotalMaxPop.Text); // 65535 max popcap
                SetMaxPopCap(popCap);
            }
        }

        private void TotalPopReset_Click(object sender, EventArgs e)
        {
            ResetMaxPopCap();
        }

        private void TotalMaxPopConfirm_Click(object sender, EventArgs e)
        {
            int popCap = int.Parse(TotalMaxPop.Text); // 65535 max popcap
            SetMaxPopCap(popCap);
        }


    }
}
