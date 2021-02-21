using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace HWID_Display

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                Id = mo.Properties["processorID"].Value.ToString();
                break;
            }
            bunifuMetroTextbox1.Text = Id;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(bunifuMetroTextbox1.Text);
            string message = "Copied Processor HWID!";
            string title = "HWID Displayer";
            MessageBox.Show(message, title);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(bunifuMetroTextbox1.Text);
            string message = "Copied Processor HWID!";
            string title = "HWID Displayer";
            MessageBox.Show(message, title);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.webopedia.com/definitions/hwid/");
        }
    }
}
