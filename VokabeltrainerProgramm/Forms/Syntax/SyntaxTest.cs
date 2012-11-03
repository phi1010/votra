using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PhillipKuhrt.VoTra.Classes;

namespace PhillipKuhrt.VoTra.Forms.Syntax
{
    public partial class SyntaxTest : Form
    {
        public SyntaxTest()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.BackColor = SystemColors.Window;
            listBox1.Items.Clear();
            try
            {
                foreach (string s in SyntaxProcessor.DoSyntax(textBox1.Text))
                    listBox1.Items.Add(s);
            }
            catch (Exception exc)
            {
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //{
            //    listBox1.BackColor = SystemColors.Window;
            //    listBox1.Items.Clear();
            //    try
            //    {
            //        foreach (string s in Syntax.DoSyntax(textBox1.Text))
            //            listBox1.Items.Add(s);
            //    }
            //    catch(Exception exc)
            //    {
            //        listBox1.BackColor = Color.Orange;
            //        listBox1.Items.Add(exc.Message);
            //    }
            //}
        }

        private void SyntaxTest_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.BackColor = SystemColors.Window;
            listBox1.Items.Clear();
            try
            {
                foreach (string s in SyntaxProcessor.DoSyntax(textBox1.Text))
                    listBox1.Items.Add(s);
            }
            catch (Exception exc)
            {
                listBox1.BackColor = Color.Orange;
                listBox1.Items.Add(exc.Message);
            }
        }
    }
}
