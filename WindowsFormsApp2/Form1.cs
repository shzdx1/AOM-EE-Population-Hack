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

            byte[] bytesToWrite = new byte[2]; // dos bytes son suficientes para la poblacion, falta verificar si con 3 no hay problemas

            bytesToWrite[0] = (byte)(popCap & 0xff);
            bytesToWrite[1] = (byte)((popCap >> 8) & 0xff);
            //Array.Reverse(bytesToWrite);

            processReadAndWrite.WriteMemory(popCapOffset, bytesToWrite);
            processReadAndWrite.WriteMemory(secondValidationOffset, nops);

        }

        private void ResetMaxPopCap()
        {
            int popCapOffset = 0x296BEA;
            int secondValidationOffset = 0x296C09;

            byte[] pop300 = { 0x12, 0x0C}; // 300 poblacion cap
            byte[] secondValidationBytes = { 0x0F, 0x4F, 0xC1};

            // vuelvo a escribir los 300 de poblacion
            processReadAndWrite.WriteMemory(popCapOffset, pop300);
            // recupero el codigo en donde puse nops.
            processReadAndWrite.WriteMemory(secondValidationOffset, secondValidationBytes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[2];
            int bufferReaded = processReadAndWrite.ReadMemory(0x00A97BEA, buffer);
        }


        private void CurrentMaxPopConfirm_Click(object sender, EventArgs e)
        {
        }

        private void TotalMaxPop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int popCap = int.Parse(TotalMaxPop.Text); // maximo 65535 de popcap
                SetMaxPopCap(popCap);
            }
        }

        private void TotalPopReset_Click(object sender, EventArgs e)
        {
            ResetMaxPopCap();
        }

        private void TotalMaxPopConfirm_Click(object sender, EventArgs e)
        {
            int popCap = int.Parse(TotalMaxPop.Text); // maximo 65535 de popcap
            SetMaxPopCap(popCap);
        }


    }
}
