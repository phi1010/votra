using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using PhillipKuhrt.VoTra.Data;
using PhillipKuhrt.VoTra.Icons;
using PhillipKuhrt.VoTra.Forms.Syntax;

namespace PhillipKuhrt.VoTra.Forms.Main
{
    public partial class StartForm : Form
    {
        private User CurrentUser;
        private IconsFolder FolderIcons;
        private IconsUser UserIcons;
        private List<Folder> Folders;
        private List<User> Users;

        public StartForm(IconsFolder FolderIcons, IconsUser UserIcons, List<Folder> Folders, List<User> Users)
        {
            this.FolderIcons = FolderIcons;
            this.UserIcons = UserIcons;
            this.Folders = Folders;
            this.Users = Users;
            InitializeComponent();
        }


        private void StartForm_Load(object sender, EventArgs e)
        {
            SelectUser();
        }

        private void SelectUser()
        {
            UserSelectionForm usf = new UserSelectionForm(UserIcons, Users);
            //Hide();
            var dr = usf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                CurrentUser = usf.User;
                lblUserName.Text = CurrentUser.Name;
                pbUserIcon.Image = UserIcons.GetIcon(CurrentUser.PictureID);
                Show();
            }
            if (CurrentUser == null)
                Close();
            //else
            //    Show();
        }



        private void lblTest_Click(object sender, EventArgs e)
        {
            Hide();
            try
            {
                Test.TestSettings frm = new Test.TestSettings(FolderIcons, Folders, CurrentUser, UserIcons);
                frm.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten.\nEs wird empfohlen, eine Sicherheitskopie der Datei 'Vokabeln.pkvotra' zu erstellen, das Programm dann zu schließen und eine zweite Kopie zu erstellen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Show();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblManagement_Click(object sender, EventArgs e)
        {
            Hide();
            try
            {
                Editor.DataForm frm = new PhillipKuhrt.VoTra.Forms.Editor.DataForm(FolderIcons, Folders, CurrentUser);
                frm.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten.\nEs wird empfohlen, eine Sicherheitskopie der Datei 'Vokabeln.pkvotra' zu erstellen, das Programm dann zu schließen und eine zweite Kopie zu erstellen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Show();
        }



        private void StartForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            if (((Label)sender).Enabled)
            {
                ((Label)sender).ForeColor = Color.Red;
                ((Label)sender).Font = new Font(((Label)sender).Font, FontStyle.Underline | FontStyle.Bold);
            }
        }
        private void label_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.White;
            ((Label)sender).Font = new Font(((Label)sender).Font, FontStyle.Bold);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            (new AboutBox()).ShowDialog();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
            SelectUser();
        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
            //Hide();
            new UserSettingsForm(Users, CurrentUser, UserIcons).ShowDialog();
            if (Users.Contains(CurrentUser))
            {
                lblUserName.Text = CurrentUser.Name;
                pbUserIcon.Image = UserIcons.GetIcon(CurrentUser.PictureID);
                //Show();
            }
            else
            {
                CurrentUser = null;
                SelectUser();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle != FormBorderStyle.FixedToolWindow)
                FormBorderStyle = FormBorderStyle.FixedToolWindow;
            else
                FormBorderStyle = FormBorderStyle.None;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new SyntaxTest().ShowDialog();
        }
    }
}
