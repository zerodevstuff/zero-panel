using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zero_panel
{
    public partial class zerotext : UserControl
    {
        //field stuff for the textbox lol
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;

        public zerotext()
        {
            InitializeComponent();
        }
    }
}
