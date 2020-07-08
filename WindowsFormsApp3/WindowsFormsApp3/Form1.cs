using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XRPCLib;
using JRPC_Client;
using DevComponents.DotNetBar;
using XDevkit;
using XDevkitPlusPlus;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        XRPC JTAG = new XRPC();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btConnect_Click(object sender, EventArgs e)
        {
                JTAG.Connect();
                if (JTAG.activeConnection == true)
                {

                    MessageBoxEx.Show("Connection Successful", "Connected", MessageBoxButtons.OK);
                }

                else
                {
                    MessageBoxEx.Show("Connection Failed", "Not Connected", MessageBoxButtons.OK);
                }
            }

        private void btSend_Click(object sender, EventArgs e)
        {
            byte[] Values = { 0x00, 0x00, 0x00, 0xF6, };
            JTAG.SetMemory(0xC458AD94, Values);

        }
    }
}
