using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhillipKuhrt.VoTra.Data;
using PhillipKuhrt.VoTra.Icons;

namespace PhillipKuhrt.VoTra.Forms.Main
{
    public partial class UserSettingsForm : Form
    {
        User u;
        List<User> lu;
        IconsUser iu;
        public UserSettingsForm(List<User> Users, User User, IconsUser UserIcons)
        {
            InitializeComponent();
            u = User;
            iu = UserIcons;
            lu = Users;
            ImageList imgL = new ImageList();
            imgL.ColorDepth = ColorDepth.Depth32Bit;
            imgL.ImageSize = new System.Drawing.Size(32, 32);
            foreach (var kvp in iu.IconDictionary)
            {
                imgL.Images.Add(kvp.Key.ToString(), kvp.Value);

                ListViewItem lvi = new ListViewItem();
                lvi.ImageKey = kvp.Key.ToString();
                lvi.Tag = kvp.Key;
                listView1.Items.Add(lvi);
                if (u.PictureID == kvp.Key)
                    lvi.Selected = true;
            }
            listView1.SmallImageList = imgL;
            listView1.LargeImageList = imgL;
            textBox1.Text = u.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Wollen sie wirklich alle ihre Daten löschen? Dies kann nicht rückgängig gemacht werden!\nDie eingegebenen Vokabeln bleiben erhalten, damit weitere Benutzer sie verwenden können.", "Benutzer löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2))
            {
                if (DialogResult.Yes == MessageBox.Show("Sind sie sicher?", "Benutzer löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2))
                {
                    lu.Remove(u);
                    Close();
                }
            }
        }

        private void UserSettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                u.PictureID = (int)listView1.SelectedItems[0].Tag;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            u.Name = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
