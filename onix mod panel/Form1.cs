using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OsInfo;
using System.Management;


namespace onix_mod_panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool os = OsInfo.Utils.OperatingSystemBitChecker.Is64BitOperatingSystem();
            string res = os.ToString();
            textBox1.Text = res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher wmiData = new ManagementObjectSearcher(@"root\SecurityCenter2", "SELECT * FROM AntiVirusProduct");
            ManagementObjectCollection data = wmiData.Get();

            foreach (ManagementObject av in data)
            {
                string nl = "\r\n";
                textBox2.Text = (av["displayName"].ToString() + nl + av["pathToSignedProductExe"].ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
