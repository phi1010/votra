using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PhillipKuhrt.VoTra.Syntax
{
    public partial class UserControl1 : UserControl
    {
        TextBox TB;
        public TextBox TextBox
        {
            get { return TB; }
            set { TB = value; }
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(new Point(0,0), ToolStripDropDownDirection.BelowRight);
        }

        private void LetterClicked(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
                if (TB != null)
                    TB.Text += (sender as ToolStripMenuItem).Text.Split(';')[0];

        }
    }
}
