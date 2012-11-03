using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PhillipKuhrt.VoTra.Data;
using PhillipKuhrt.VoTra.Icons;

namespace PhillipKuhrt.VoTra.Forms.Main
{
    public partial class UserSelectionForm : Form
    {
        private IconsUser UserIcons;
        List<User> Users;
        User CurrentUser = null;
        public UserSelectionForm(IconsUser UserIcons, List<User> Users)
        {
            InitializeComponent();
            this.UserIcons = UserIcons;
            this.Users = Users;
            ImageList imgL = new ImageList();
            imgL.ColorDepth = ColorDepth.Depth32Bit;
            imgL.ImageSize = new System.Drawing.Size(32, 32);
            foreach (var kvp in UserIcons.IconDictionary)
                imgL.Images.Add(kvp.Key.ToString(), kvp.Value);
            listView1.SmallImageList = imgL;
            listView1.LargeImageList = imgL;
            foreach (User u in Users)
            {
                ListViewItem lvi = new ListViewItem(u.Name);
                lvi.ImageKey = u.PictureID.ToString();
                lvi.Tag = u;
                listView1.Items.Add(lvi);
            }
        }


        public User User
        {
            get
            {
                return CurrentUser;
            }
        }

        private void UserSelectionForm_Load(object sender, EventArgs e)
        {
            ImageList imgL = new ImageList();
            imgL.ColorDepth = ColorDepth.Depth32Bit;
            foreach (var kvp in UserIcons.IconDictionary)
            {
                imgL.Images.Add(kvp.Key.ToString(), kvp.Value);
            }

            foreach (User u in Users)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = u.Name;
                lvi.ImageKey = u.PictureID.ToString();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Name = "Neuer Benutzer";
            u.PictureID = 0;
            Users.Add(u);
            Hide();
            new UserSettingsForm(Users, u, UserIcons).ShowDialog();
            if (Users.Contains(u))
            {
                DialogResult = DialogResult.OK;
                CurrentUser = u;
                Close();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UserSelectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CurrentUser == null)
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    CurrentUser = null;
                    DialogResult = DialogResult.Cancel;
                }
                else
                    if (listView1.SelectedItems[0].Tag is User)
                    {
                        CurrentUser = listView1.SelectedItems[0].Tag as User;
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        CurrentUser = null;
                        DialogResult = DialogResult.Cancel;
                    }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = listView1.SelectedItems.Count > 0;
        }
    }
}
