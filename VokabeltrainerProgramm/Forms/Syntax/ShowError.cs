using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhillipKuhrt.VoTra.Classes;

namespace PhillipKuhrt.VoTra.Forms.Syntax
{
    public partial class ShowError : Form
    {
        public ShowError()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();


            Color ClRed = Color.FromArgb(255, 127, 127);
            Color ClGreen = Color.FromArgb(127, 255, 127);
            Color ClWhite = Color.FromArgb(255, 255, 255);
            Font FntRed = new System.Drawing.Font(richTextBox1.Font, FontStyle.Strikeout);
            Font FntGreen = new System.Drawing.Font(richTextBox1.Font, FontStyle.Bold);
            Font FntWhite = new System.Drawing.Font(richTextBox1.Font, FontStyle.Regular);

            string textA = textBox1.Text;
            string textB = textBox3.Text;
            int x = 0, y = 0;

            var diff = DiffProcessor.Diff(textA, textB);
            foreach (var d in diff)
            {
                if (d.diff)
                {

                    int count = richTextBox1.TextLength;
                    richTextBox1.AppendText(d.a);
                    richTextBox1.Select(count, richTextBox1.TextLength - count);
                    richTextBox1.SelectionBackColor = ClRed;
                    richTextBox1.SelectionFont = FntRed;

                    count = richTextBox1.TextLength;
                    richTextBox1.AppendText(d.b);
                    richTextBox1.Select(count, richTextBox1.TextLength - count);
                    richTextBox1.SelectionBackColor = ClGreen;
                    richTextBox1.SelectionFont = FntGreen;
                    x += d.a.Length + d.b.Length;
                    y += d.a.Length + d.b.Length;
                }
                else
                {
                    int count = richTextBox1.TextLength;
                    richTextBox1.AppendText(d.a);
                    richTextBox1.Select(count, richTextBox1.TextLength - count);
                    richTextBox1.SelectionBackColor = ClWhite;
                    richTextBox1.SelectionFont = FntWhite;
                    x += d.a.Length;
                }
            }
            if (x != 0)
                Text = (y * 100 / x).ToString() + "% fehlerhaft";
            else
                Text = "DiffTest";


#if OLD1
            var diff = DiffProcessor.FindDifferences(textA, textB);
            var nextchar = 0;
            var selectionStart = -1;

            bool Mark = true;
            Mark &= Math.Abs(textA.Length - textB.Length) <= textB.Length / 2;
            Mark &= diff.Length <= textB.Length / 6 + 1;

            if (Mark)
            {
                for (int i = 0; i < diff.Length; i++)
                {
                    DiffProcessor.Difference item = diff[i];

                    selectionStart = richTextBox1.TextLength;
                    richTextBox1.AppendText(textA.Substring(nextchar, item.startA - nextchar));
                    richTextBox1.Select(selectionStart, item.startA - nextchar);
                    richTextBox1.SelectionBackColor = ClWhite;
                    nextchar = item.startA + item.countA;

                    selectionStart = richTextBox1.TextLength;
                    richTextBox1.AppendText(textA.Substring(item.startA, item.countA));
                    richTextBox1.Select(selectionStart, item.countA);
                    richTextBox1.SelectionBackColor = ClRed;

                    selectionStart = richTextBox1.TextLength;
                    richTextBox1.AppendText(textB.Substring(item.startB, item.countB));
                    richTextBox1.Select(selectionStart, item.countB);
                    richTextBox1.SelectionBackColor = ClGreen;
                }
                if (nextchar < textA.Length)
                {
                    selectionStart = richTextBox1.TextLength;
                    richTextBox1.AppendText(textA.Substring(nextchar, textA.Length - nextchar));
                    richTextBox1.Select(selectionStart, textA.Length - nextchar);
                    richTextBox1.SelectionBackColor = ClWhite;
                }
            }
            else
            {
                richTextBox1.Text = "ERROR";
            }
#endif

#if OLD2
            //richTextBox1.Text = textBox1.Text + "\n" + textBox3.Text;
            //var diff = Diff.DiffText(textBox1.Text, textBox3.Text);
            //int A = 0;
            //int B = textBox1.Text.Length + 1;
            //Color ClRed = Color.FromArgb(255, 127, 127);
            //Color ClGreen = Color.FromArgb(127, 255, 127);
            //Color ClYellow = Color.FromArgb(255, 255, 0);
            //foreach (var item in diff)
            //{
            //    if (item.deletedA > 0 && item.insertedB == 0)
            //    {
            //        richTextBox1.Select(A + item.StartA, item.deletedA);
            //        richTextBox1.SelectionBackColor = ClRed;
            //    }
            //    else if (item.deletedA == 0 && item.insertedB > 0)
            //    {
            //        richTextBox1.Select(B + item.StartB, item.insertedB);
            //        richTextBox1.SelectionBackColor = ClGreen;
            //    }
            //    else
            //    {
            //        richTextBox1.Select(A + item.StartA, item.deletedA);
            //        richTextBox1.SelectionBackColor = ClYellow;
            //        richTextBox1.Select(B + item.StartB, item.insertedB);
            //        richTextBox1.SelectionBackColor = ClYellow;
            //    }
            //}
#endif

        }

        private void ShowError_Load(object sender, EventArgs e)
        {

        }
    }
}
