#define CloseAfterTested

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PhillipKuhrt.VoTra.Data;
using PhillipKuhrt.VoTra.Icons;

namespace PhillipKuhrt.VoTra.Forms.Test
{
    public partial class TestSettings : Form
    {


        private User CurrentUser;
        private IconsFolder FolderIcons;
        private List<Folder> Folders;
        private IconsUser UserIcons;


        public TestSettings(IconsFolder FolderIcons, List<Folder> Folders, User CurrentUser, IconsUser UserIcons)
        {
            InitializeComponent();
            this.FolderIcons = FolderIcons;
            this.Folders = Folders;
            this.CurrentUser = CurrentUser;
            this.UserIcons = UserIcons;
            folderControl1.Folders = Folders;
            folderControl1.FolderIcons = FolderIcons;
            lblUserName.Text = CurrentUser.Name;
            pbUserIcon.Image = UserIcons.GetIcon(CurrentUser.PictureID);
        }

        private void TestSettings_Load(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            List<Word> lw2 = GetUsableWords(CBRecursive.Checked, GetAllowedStatus());
            List<Word> lw3 = ChooseWords(lw2);

            Language? lang;

            if (RbtnPresetGerman.Checked)
                lang = Language.German;
            else if (RbtnPresetOther.Checked)
                lang = Language.OtherLanguage;
            else
                lang = null;

            TestForm tf = new TestForm(lw3, lang, CBRevise.Checked, CurrentUser);

            Hide();
            tf.ShowDialog();
            Close();
        }

        private List<Word> ChooseWords(List<Word> lw2)
        {
            Random Rdm = new Random();
            List<Word> lw3 = new List<Word>();
            for (int i = 0; i < NUDCount.Value; i++)
            {
                Word w = lw2[Rdm.Next(0, lw2.Count)];
                lw3.Add(w);
                lw2.Remove(w);
            }
            return lw3;
        }

        /// <summary>
        /// Gibt eine Liste von Wörtern zurück, die der Spezifikation entsprechen.
        /// </summary>
        private List<Word> GetUsableWords(bool Recursive, Dictionary<int, bool> allowedStatus)
        {
            if (folderControl1.SelectedFolder != null)
            {
                Folder g = folderControl1.SelectedFolder;

                List<Word> lw1, lw2;

                if (Recursive)
                    lw1 = g.AllWords;
                else
                    lw1 = g.Words;

                lw2 = new List<Word>();
                foreach (Word w in lw1)
                {
                    bool statusAllowed = false;
                    int status = w.GetState(CurrentUser);
                    if (allowedStatus.ContainsKey(status))
                        statusAllowed = allowedStatus[status];

                    if (statusAllowed)
                        lw2.Add(w);
                }
                return lw2;
            }
            else
                return new List<Word>();
        }


        private void UpdateBtnOK()
        {
            int i = GetUsableWords(CBRecursive.Checked, GetAllowedStatus()).Count;
            BtnOK.Text = "Vokabeln abfragen(" + NUDCount.Value.ToString() + "/" + i.ToString() + ")";
            BtnOK.Enabled = (NUDCount.Value <= i);
        }

        private Dictionary<int, bool> GetAllowedStatus()
        {
            return new Dictionary<int, bool> 
                    { 
                        { 1, CBVokabelauswahl1.Checked }, 
                        { 2, CBVokabelauswahl2.Checked },
                        { 3, CBVokabelauswahl3.Checked },
                        { 4, CBVokabelauswahl4.Checked },
                        { 5, CBVokabelauswahl5.Checked }
                    };
        }

        private void NUDCount_ValueChanged(object sender, EventArgs e)
        {
            UpdateBtnOK();
        }

        private void CBRecursive_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBtnOK();
        }

        private void CBRevise_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBtnOK();
        }

        private void NUDCount_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateBtnOK();
        }

        private void CBVokabelauswahl_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBtnOK();
        }

        private void RbtnPreset_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBtnOK();
        }

        private void folderControl1_SelectedEvent()
        {
            UpdateBtnOK();
        }

        private void folderControl1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateBtnOK();
        }
    }
}
