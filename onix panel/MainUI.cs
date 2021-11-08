using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using OsInfo.Utils;
using OsInfo;
using OsInfo.Extensions;
using AutoItX3Lib;
using System.Threading;



namespace zero_panel
{
    public partial class MainUI : MaterialForm
    {
        AutoItX3 au3 = new AutoItX3();

        [DllImport("user32.dll")]

        static extern short GetAsyncKeyState(Keys vkey);

        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton14_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange700, Primary.Orange800, Accent.Orange100, TextShade.WHITE);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue700, Primary.Blue800, Accent.Blue100, TextShade.WHITE);
        }

        private void materialRaisedButton24_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton28_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green800, Primary.Green900, Accent.Green400, TextShade.WHITE);
        }

        private void materialRaisedButton23_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink800, Primary.Pink700, Primary.Pink800, Accent.Pink100, TextShade.WHITE);
        }

        private void materialRaisedButton20_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple700, Primary.Purple800, Accent.Purple100, TextShade.WHITE);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red700, Primary.Red800, Accent.Red100, TextShade.WHITE);
        }

        private void materialRaisedButton29_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void materialRaisedButton30_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void materialRaisedButton27_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            textBox1.BackColor = Color.FromArgb(255, 51, 51, 51);
            textBox2.BackColor = Color.FromArgb(255, 51, 51, 51);
            tabPage3.BackColor = Color.FromArgb(255, 51, 51, 51);
        }

        private void materialRaisedButton3_Click_1(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            textBox1.BackColor = Color.FromArgb(255, 255, 255, 255);
            textBox2.BackColor = Color.FromArgb(255, 255, 255, 255);
            tabPage3.BackColor = Color.FromArgb(255, 255, 255, 255);
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            bool sysarch = OsInfo.Utils.OperatingSystemBitChecker.Is64BitOperatingSystem();
            string sysarchstring = sysarch.ToString();
            if(sysarch == true)
            {
                textBox1.Text = "your system is running in a 64bit enviroment";
            }
            else
            {
                textBox1.Text = "your system is running in a 32bit enviroment";
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            Thread AB = new Thread(aimbot) { IsBackground = true };
            AB.Start();
        }
        void aimbot()
        {
            while (true)
            {
                if (GetAsyncKeyState(Keys.Z) < 0)
                {
                    try
                    {
                        object pix = au3.PixelSearch(47, 173, 1349, 655, 0xF6FAFD);
                        if (pix.ToString() != "1")
                        {
                            object[] pixCoord = (object[])pix;
                            au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                        }
                    }
                    catch { }

                }
                Thread.Sleep(1);
            }
        }
    }
}
