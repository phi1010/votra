using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhillipKuhrt.VoTra.Classes;

namespace PhillipKuhrt.VoTra.Controls
{
    public partial class DiffBox : UserControl
    {
        public DiffBox()
        {
            InitializeComponent();
            _Solution = "";
            _Text = "";
            UpdateView();
        }
        private string _Solution;
        private string _Text;
        public string Solution
        {
            get { return _Solution; }
            set { _Solution = value; UpdateView(); }
        }
        public bool ReadOnly
        {
            get { return richTextBox1.ReadOnly; }
            set
            {
                richTextBox1.ReadOnly = value;
                if (!value)
                {
                    string s = _Text;
                    richTextBox1.Clear();
                    richTextBox1.Text = s;
                }
                UpdateView();
            }
        }
        public string Text
        {
            get { return _Text; }
            set { _Text = value; UpdateView(); }
        }


        private void UpdateView()
        {
            if (ReadOnly)
            {
                string nearestSolution = "";
                #region Auswählen
                {
                    float CorrectRate = 0;
                    var ss = SyntaxProcessor.DoSyntax(_Solution);
                    foreach (var s in ss)
                    {
                        float rate = GetCorrectRate(DiffProcessor.Diff(_Text, s));
                        if (rate > CorrectRate)
                        {
                            CorrectRate = rate;
                            nearestSolution = s;
                        }
                    }
                }
                #endregion
                #region Anzeigen
                {
                    richTextBox1.Clear();
                    Color ClRed = Color.FromArgb(255, 127, 127);
                    Color ClGreen = Color.FromArgb(127, 255, 127);
                    Color ClWhite = Color.FromArgb(255, 255, 255);
                    Font FntRed = new Font(richTextBox1.Font, FontStyle.Strikeout);
                    Font FntGreen = new Font(richTextBox1.Font, FontStyle.Bold);
                    Font FntWhite = new Font(richTextBox1.Font, FontStyle.Regular);

                    int x = 0, y = 0;

                    var diff = DiffProcessor.Diff(Text, nearestSolution);
                    foreach (var d in diff)
                    {
                        if (d.diff)
                        {
                            //Fehler
                            int count = richTextBox1.TextLength;
                            richTextBox1.AppendText(d.a);
                            richTextBox1.Select(count, richTextBox1.TextLength - count);
                            richTextBox1.SelectionBackColor = ClRed;
                            richTextBox1.SelectionFont = FntRed;

                            //Korrektur
                            count = richTextBox1.TextLength;
                            richTextBox1.AppendText(d.b);
                            richTextBox1.Select(count, richTextBox1.TextLength - count);
                            richTextBox1.SelectionBackColor = ClGreen;
                            richTextBox1.SelectionFont = FntGreen;
                        }
                        else
                        {
                            //Richtiger Text
                            int count = richTextBox1.TextLength;
                            richTextBox1.AppendText(d.a);
                            richTextBox1.Select(count, richTextBox1.TextLength - count);
                            richTextBox1.SelectionBackColor = ClWhite;
                            richTextBox1.SelectionFont = FntWhite;
                        }
                    }
                }
                #endregion
            }
        }

        private float GetCorrectRate(DiffProcessor.Section[] s)
        {
            int x = 0, y = 0;
            foreach (var d in s)
            {
                if (d.diff)
                {
                    x += d.a.Length + d.b.Length;
                }
                else
                {
                    x += d.a.Length;
                    y += d.a.Length;
                }
            }
            return ((float)y) / x;
        }

        private void DiffBox_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!ReadOnly)
            {
                _Text = richTextBox1.Text;
                UpdateView();
            }
        }
    }
}
