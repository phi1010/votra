using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhillipKuhrt.VoTra.Classes;
using PhillipKuhrt.VoTra.Controls;

namespace PhillipKuhrt.VoTra.Forms.Syntax
{
    public partial class DiffBoxTest : Form
    {
        public DiffBoxTest()
        {
            InitializeComponent();
            diffBox1.ReadOnly = checkBox1.Checked;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            diffBox1.Solution = textBox1.Text;

        }

        private void ShowError_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            diffBox1.ReadOnly = checkBox1.Checked;
        }
    }
}
