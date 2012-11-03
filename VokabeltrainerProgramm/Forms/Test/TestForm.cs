using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PhillipKuhrt.VoTra.Data;
using PhillipKuhrt.VoTra.Classes;

namespace PhillipKuhrt.VoTra.Forms.Test
{
    public partial class TestForm : Form
    {
        enum ColorMode
        {
            Normal,
            Wrong,
            Correct
        }
        Word CurrentWord;
        /// <summary>
        /// Angezeigte/Vorgegebene Sprache
        /// </summary>
        private Language CurrentLanguage;

        private enum ProgramState
        {
            Question,
            Answer
        }
        private ProgramState State;

        Random rand;

        private User CurrentUser;

        private int CountCorrect = 0;
        private int CountWrong = 0;

        private List<Word> WordsToDo = new List<Word>();
        private List<Word> WordsDone = new List<Word>();

        private Language? PresetLanguage;
        private bool PresetRevise = false;



        public TestForm(List<Word> words, Language? lang, bool revise, User user)
        {
            rand = new Random();
            InitializeComponent();
            CurrentUser = user;
            WordsToDo = words;
            PresetLanguage = lang;
            PresetRevise = revise;
        }

        private void OK()
        {
            switch (State)
            {
                case ProgramState.Question:
                    {
                        NextAnswer();
                        break;
                    }
                case ProgramState.Answer:
                    {
                        if (WordsToDo.Count > 0)
                            NextQuestion();
                        else
                            Close();
                        break;
                    }
            }
        }

        private void NextAnswer()
        {
            State = ProgramState.Answer;
            bool correct;
            tbBWord.ReadOnly = true;
            foreach (string s in SyntaxProcessor.DoSyntax(GetText(CurrentLanguage, CurrentWord, false)))
                lbAList.Items.Add(s);
            foreach (string s in SyntaxProcessor.DoSyntax(GetText(CurrentLanguage, CurrentWord, true)))
                lbBList.Items.Add(s);
            lblBComment.Text = GetInfo(CurrentLanguage, CurrentWord, true);
            correct = SyntaxProcessor.CorrectWord(GetText(CurrentLanguage, CurrentWord, true), tbBWord.Text);

            lblComment.Text = CurrentWord.Info;

            if (correct)
            {
                btnOK.ForeColor = Color.Green;
                CountCorrect++;
            }
            else
            {
                btnOK.ForeColor = Color.Red;
                CountWrong++;
            }

            if (WordsToDo.Count == 0)
                btnOK.Text = "Schließen!";
            else
                btnOK.Text = "Weiter!";


            new Result(correct, CurrentWord, CurrentUser, CurrentLanguage, lblAWord.Text, tbBWord.Text);
            if (correct || !PresetRevise)
            {
                WordsDone.Add(CurrentWord);
                WordsToDo.Remove(CurrentWord);
            }


            diffBox1.Text = tbBWord.Text;
            diffBox1.Solution = GetText(CurrentLanguage, CurrentWord, true) ;

            UpdateProgressDisplay();
            UpdateQualityDisplay();

        }

        private void NextQuestion()
        {
            btnOK.ForeColor = SystemColors.ControlText;

            btnOK.Text = "OK";
            tbBWord.Focus();
            State = ProgramState.Question;
            CurrentWord = WordsToDo[rand.Next(WordsToDo.Count)];

            CurrentLanguage = PresetLanguage ?? ((rand.Next(2) == 0) ? Language.German : Language.OtherLanguage);

            lblALanguage.BackColor = lblAWord.BackColor = GetColor(CurrentLanguage, CurrentWord.Parent.ColorRecursive, false);
            lblBLanguage.BackColor = tbBWord.BackColor = GetColor(CurrentLanguage, CurrentWord.Parent.ColorRecursive, true);
            if (lblALanguage.BackColor.R + lblALanguage.BackColor.G + lblALanguage.BackColor.B < 3 * 255 / 2) lblALanguage.ForeColor = Color.White; else lblALanguage.ForeColor = Color.Black;
            if (lblBLanguage.BackColor.R + lblBLanguage.BackColor.G + lblBLanguage.BackColor.B < 3 * 255 / 2) lblBLanguage.ForeColor = Color.White; else lblBLanguage.ForeColor = Color.Black;
            if (lblAWord.BackColor.R + lblAWord.BackColor.G + lblAWord.BackColor.B < 3 * 255 / 2) lblAWord.ForeColor = Color.White; else lblAWord.ForeColor = Color.Black;
            if (tbBWord.BackColor.R + tbBWord.BackColor.G + tbBWord.BackColor.B < 3 * 255 / 2) tbBWord.ForeColor = Color.White; else tbBWord.ForeColor = Color.Black;

            lblALanguage.Text = GetLanguage(CurrentLanguage, CurrentWord.Parent.LanguageRecursive, false);
            lblBLanguage.Text = GetLanguage(CurrentLanguage, CurrentWord.Parent.LanguageRecursive, true);

            lblAWord.Text = SyntaxProcessor.GetWord(GetText(CurrentLanguage, CurrentWord, false));

            lblAComment.Text = GetInfo(CurrentLanguage, CurrentWord, false);

            tbBWord.Text = "";
            tbBWord.ReadOnly = false;

            lbAList.Items.Clear();
            lbBList.Items.Clear();

            lblComment.Text = "";
            lblBComment.Text = "";

            diffBox1.Text = "";
            diffBox1.Solution = "";


        }

        private Color GetColor(Language lang, Color? col, bool invert)
        {
            if (invert)
                return (lang == Language.OtherLanguage) ? SystemColors.Control : (CurrentWord.Parent.ColorRecursive ?? SystemColors.Control);
            else
                return (lang == Language.German) ? SystemColors.Control : (CurrentWord.Parent.ColorRecursive ?? SystemColors.Control);
        }
        private string GetLanguage(Language lang, string otherLanguage, bool invert)
        {
            if (otherLanguage == null || otherLanguage == "")
                otherLanguage = "Fremdsprache";
            if (invert)
                return (lang == Language.OtherLanguage) ? "Deutsch" : otherLanguage;
            else
                return (lang == Language.German) ? "Deutsch" : otherLanguage;
        }
        private string GetText(Language lang, Word w, bool invert)
        {
            if (invert)
                return (lang == Language.OtherLanguage) ? w.TextGerman : w.TextOtherLanguage;
            else
                return (lang == Language.German) ? w.TextGerman : w.TextOtherLanguage;
        }
        private string GetInfo(Language lang, Word w, bool invert)
        {
            if (invert)
                return (lang == Language.OtherLanguage) ? w.InfoGerman : w.InfoOtherLanguage;
            else
                return (lang == Language.German) ? w.InfoGerman : w.InfoOtherLanguage;
        }


        private void UpdateQualityDisplay()
        {
            if (CountCorrect + CountWrong == 0)
            {
                pgQuality.Maximum = 100;
                pgQuality.Value = 0;
                lblQuality.Text = "---";
            }
            else
            {
                int a = CountCorrect;
                int ab = CountWrong + CountCorrect;
                pgQuality.Maximum = ab;
                pgQuality.Value = a;
                lblQuality.Text = Convert.ToInt32(100 * (a * 1f) / (ab)).ToString().PadLeft(3) + "% richtig";
            }
        }
        private void UpdateProgressDisplay()
        {
            int a = WordsDone.Count;
            int ab = WordsDone.Count + WordsToDo.Count;
            pgProgress.Maximum = ab;
            pgProgress.Value = a;
            lblProgress.Text = Convert.ToInt32(100 * (a * 1f) / (ab)).ToString().PadLeft(3) + "% fertig";
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            NextQuestion();
        }


        private void BWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                OK();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OK();
        }
    }
}
