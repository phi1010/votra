using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhillipKuhrt.VoTra.Data;
using PhillipKuhrt.VoTra.Icons;

namespace PhillipKuhrt.VoTra.Forms.Editor
{
    public partial class FolderSettingsDialog : Form
    {
        private IconsFolder _FolderIcons;
        public Folder _Folder;
        public FolderSettingsDialog(Data.Folder Folder, IconsFolder FolderIcons)
        {
            InitializeComponent();
            _FolderIcons = FolderIcons;
            _Folder = Folder;

            ImageList imgL = new ImageList();
            imgL.ColorDepth = ColorDepth.Depth32Bit;
            imgL.ImageSize = new System.Drawing.Size(32, 32);
            foreach (var kvp in _FolderIcons.IconDictionary)
            {
                imgL.Images.Add(kvp.Key.ToString(), kvp.Value);

                ListViewItem lvi = new ListViewItem();
                lvi.ImageKey = kvp.Key.ToString();
                lvi.Tag = kvp.Key;
                lvImages1.Items.Add(lvi);
                if (Folder.SymbolID == kvp.Key)
                    lvi.Selected = true;
            }
            lvImages1.SmallImageList = imgL;
            lvImages1.LargeImageList = imgL;

            textBox1.Text = _Folder.Title;
            textBox2.Text = _Folder.Language;
            panel1.BackColor = _Folder.Color ?? SystemColors.Control;
            panel2.BackColor = _Folder.ColorRecursive ?? SystemColors.Control;
            if (null == _Folder.Color)
                panel1.BackgroundImage = Properties.Resources.button_cancel_256x256_32; 
            if (null == _Folder.ColorRecursive)
                panel2.BackgroundImage = Properties.Resources.button_cancel_256x256_32; 
            label5.Text = _Folder.LanguageRecursive;
            lvImages1.SelectedIndices.Clear();
            if (lvImages1.Items.Count > _Folder.SymbolID)
            {
                int index = imgL.Images.IndexOfKey(_Folder.SymbolID.ToString());
                if (index < 0)
                    lvImages1.Items[0].Selected = true;
                else
                    lvImages1.Items[index].Selected = true;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _Folder.Language = textBox2.Text;
            label5.Text = _Folder.LanguageRecursive;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _Folder.Title = textBox1.Text;
        }

        private void lvImages1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvImages1.SelectedIndices.Count > 0)
                _Folder.SymbolID = (int)lvImages1.SelectedItems[0].Tag;
        }

        private void GroupSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
        }


        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                colorDialog1.Color = _Folder.Color ?? SystemColors.Control;
                if (DialogResult.OK == colorDialog1.ShowDialog(this))
                {
                    _Folder.Color = colorDialog1.Color;
                    panel1.BackColor = _Folder.Color ?? SystemColors.Control;
                    panel2.BackColor = _Folder.ColorRecursive ?? SystemColors.Control;
                    panel1.BackgroundImage = null;
                    panel2.BackgroundImage = null;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                _Folder.Color = null;
                panel1.BackColor = _Folder.Color ?? SystemColors.Control;
                panel2.BackColor = _Folder.ColorRecursive ?? SystemColors.Control;
                panel1.BackgroundImage = Properties.Resources.button_cancel_256x256_32;
                if (null == _Folder.ColorRecursive)
                    panel2.BackgroundImage = Properties.Resources.button_cancel_256x256_32; 
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

