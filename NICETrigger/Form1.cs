using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NICETrigger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            // Disable the close button('X')
            this.ControlBox = false;
            timerToExit.Interval = 5000;
            timerToExit.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string txtoutput = "";
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                txtoutput = txtoutput + String.Join(" ", args.Skip(1));
            }
            else
            {
                txtoutput = txtoutput + "no arguments provided";
            }
            textBoxOutput.Text = txtoutput;
            textBoxOutput.Enabled = false;
        }
 
        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void timerToExit_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelAction_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
