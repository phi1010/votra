using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PhillipKuhrt.VoTra.Data;
using System.Linq;
using PhillipKuhrt.VoTra.Classes;

namespace PhillipKuhrt.VoTra.Forms.Editor
{
    public partial class WordSettingsDialog : Form
    {
        private Word _Vokabel;
        private User _User;
        private bool _Modified = false;

        public WordSettingsDialog()
        {
            InitializeComponent();
        }

        public Word Vokabel
        {
            get
            {
                return (_Vokabel);
            }
            set
            {
                _Vokabel = value;
                LoadData();
                UpdateButtons();
            }
        }

        private void WordSettings_Load(object sender, EventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            SaveData();

            try
            {
                _Vokabel = _Vokabel.Parent.Words[_Vokabel.Parent.Words.IndexOf(_Vokabel) + 1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadData();
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            if (_Vokabel != null)
            {
                BtnNext.Enabled = ((_Vokabel.Parent.Words.IndexOf(_Vokabel) + 1) < (_Vokabel.Parent.Words.Count));
                BtnBack.Enabled = ((_Vokabel.Parent.Words.IndexOf(_Vokabel)) > 0);
            }
            else
            {
                BtnBack.Enabled = false;
                BtnNext.Enabled = true;
            }
        }

        private void LoadData()
        {
            if (_Vokabel != null)
            {
                TBDeutsch.Text = _Vokabel.TextGerman;
                TBFremdsprache.Text = _Vokabel.TextOtherLanguage;
                TBHinweis.Text = _Vokabel.Info;
                TBHinweisD.Text = _Vokabel.InfoGerman;
                TBHinweisF.Text = _Vokabel.InfoOtherLanguage;
                LblÄnderung.Text = _Vokabel.DateChanged.ToString();
                LblErstellung.Text = _Vokabel.DateCreated.ToString();
                _Modified = false;
                Tooltip.SetToolTip(
                    TBDeutsch,
                    SyntaxProcessor.DoSyntax(TBDeutsch.Text).Aggregate(
                    (all, one) =>
                    {
                        string tmp = all + "\n" + one;
                        return tmp;
                    }
                    )
                    );
                Tooltip.SetToolTip(
                    TBFremdsprache,
                    SyntaxProcessor.DoSyntax(TBFremdsprache.Text).Aggregate(
                    (all, one) =>
                    {
                        string tmp = all + "\n" + one;
                        return tmp;
                    }
                    )
                    );
            }
        }

        private void SaveData()
        {
            if (_Modified)
                if (_Vokabel != null)
                {
                    _Vokabel.TextGerman = TBDeutsch.Text;
                    _Vokabel.TextOtherLanguage = TBFremdsprache.Text;
                    _Vokabel.Info = TBHinweis.Text;
                    _Vokabel.InfoGerman = TBHinweisD.Text;
                    _Vokabel.InfoOtherLanguage = TBHinweisF.Text;
                }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            SaveData();
            try
            {
                _Vokabel = _Vokabel.Parent.Words[_Vokabel.Parent.Words.IndexOf(_Vokabel) - 1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadData();
            UpdateButtons();
        }

        private void WordSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            SaveData();
            if (_Vokabel != null)
            {
                try
                {
                    var Parent = _Vokabel.Parent;
                    _Vokabel = new Word();
                    _Vokabel.Parent = Parent;
                    LoadData();
                    UpdateButtons();
                    TBFremdsprache.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <param name="e">Wird verwendet</param>
        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                BtnNew_Click(null, null);
        }

        /// <param name="sender">Wird verwendet</param>
        private void TB_TextChanged(object sender, EventArgs e)
        {
            if (sender == TBDeutsch || sender == TBFremdsprache)
                TBText_Enter(sender, null);
            _Modified = true;
        }

        private void WordSettingsDialog_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            label6.Visible = !label6.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Visible = !label6.Visible;
            if (label6.Visible)
                button1.Text = ">>>";
            else
                button1.Text = "<<<";
        }

        private void TBText_Leave(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        /// <param name="sender">Wird verwendet</param>
        private void TBText_Enter(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var s in SyntaxProcessor.DoSyntax(((TextBox)sender).Text))
                listBox1.Items.Add(s);
        }




        #region alt
        //if (sender == TBFremdsprache || sender == TBDeutsch)
        //{
        //    TextBox tb = sender as TextBox;
        //    string text =
        //        Syntax.Syntax.DoSyntax(tb.Text).Aggregate(
        //        (all, one) =>
        //        {
        //            string tmp = all + "\n" + one;
        //            return tmp;
        //        }
        //        );

        //    //Tooltip.SetToolTip(tb,text);
        //    Tooltip.Show(text, tb);
        //}
        ////In einer Zeile:
        ////if (sender == TBFremdsprache||sender==TBDeutsch)Tooltip.Show(Syntax.Syntax.DoSyntax((sender as TextBox).Text).Aggregate((all, one) =>{string tmp = all + "\n" + one;return tmp;}),(sender as TextBox));
        #endregion
    }
}
