using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhillipKuhrt.VoTra.Data;
using PhillipKuhrt.VoTra.Icons;
using PhillipKuhrt.VoTra.Classes;

namespace PhillipKuhrt.VoTra.Controls
{
    public partial class WordControl : UserControl
    {

        public WordControl()
        {
            InitializeComponent();

            ImageList imgl = new ImageList();
            imgl.ColorDepth = ColorDepth.Depth32Bit;
            for (int i = 1; i <= 5; i++)
                imgl.Images.Add(IconsRating.GetImage(i));
            LvWords.SmallImageList = imgl;
            LvWords.LargeImageList = imgl;
        }



        private Folder _Folder;
        public Folder Folder
        {
            get { return _Folder; }
            set { _Folder = value; UpdateView(); }
        }

        private User _User;
        public User User
        {
            get { return _User; }
            set { _User = value; UpdateView(); }
        }

        private bool _Edit;
        public bool Edit
        {
            get { return _Edit; }
            set { _Edit = value; }
        }

        private bool _ShowText;
        public bool ShowText
        {
            get { return _ShowText; }
            set { _ShowText = value; UpdateView(); }
        }



        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new Word();
            w.Parent = _Folder;
            var dlg = new PhillipKuhrt.VoTra.Forms.Editor.WordSettingsDialog();
            dlg.Vokabel = w;
            dlg.ShowDialog();
            //LvWords.Items.Add(GetListViewItem(w, CurrentUser));
            //LvWords.Sort();
            UpdateView();
        }
        private void bearbeitenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (LvWords.SelectedItems.Count > 0)
            {
                var w = LvWords.SelectedItems[0].Tag as Word;
                var dlg = new PhillipKuhrt.VoTra.Forms.Editor.WordSettingsDialog();
                dlg.Vokabel = w;
                dlg.ShowDialog();
                UpdateView();
            }
        }
        private void löschenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Wollen Sie wirklich " + LvWords.SelectedItems.Count.ToString() + " Wörter löschen?", "Löschen?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                foreach (ListViewItem i in LvWords.SelectedItems)
                {
                    (i.Tag as Word).Parent = null;
                }
                UpdateView();
            }
        }

        private void ausschneidenToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void kopierenToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void einfügenToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private ListViewItem GetListViewItem(Word w, User CurrentUser)
        {
            if (LvWords.Columns.Count > 0)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = GetStringFromColumn(w, LvWords.Columns[0]);
                for (int i = 1; i < LvWords.Columns.Count; i++)
                {
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, GetStringFromColumn(w, LvWords.Columns[i])));
                }
                lvi.Tag = w;
                lvi.ImageIndex = w.GetState(CurrentUser) - 1;
                return lvi;
            }
            else return null;
        }

        private string GetStringFromColumn(Word w, ColumnHeader ch)
        {
            if (w == null || ch == null)
                return " ";
            if (ch == chTextGerman)
                if (_ShowText)
                    return SyntaxProcessor.DoSyntax(w.TextGerman).Aggregate((a, b) => { return a + " # " + b; });
                else
                    return w.TextGerman;
            if (ch == chTextOtherLanguage)
                if (_ShowText)
                    return SyntaxProcessor.DoSyntax(w.TextOtherLanguage).Aggregate((a, b) => { return a + " # " + b; });
                else
                    return w.TextOtherLanguage;
            if (ch == chInfo)
                return w.Info;
            if (ch == chInfoGerman)
                return w.InfoGerman;
            if (ch == chInfoOtherLanguage)
                return w.InfoOtherLanguage;
            return " ";
        }

        private void UpdateView()
        {
            LvWords.BeginUpdate();
            LvWords.Items.Clear();
            if (_Folder != null)
            {
                foreach (Word w in _Folder.Words)
                {
                    LvWords.Items.Add(GetListViewItem(w, _User));
                }
                LvWords.Sort();
            }
            LvWords.EndUpdate();
        }


        private void LvWords_DoubleClick(object sender, EventArgs e)
        {
            if (LvWords.SelectedItems.Count > 0)
            {
                var w = LvWords.SelectedItems[0].Tag as Word;
                var dlg = new PhillipKuhrt.VoTra.Forms.Editor.WordSettingsDialog();
                dlg.Vokabel = w;
                dlg.ShowDialog();
                UpdateView();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (!_Edit)
            {
                e.Cancel = true;
                return;
            }
            neuToolStripMenuItem.Enabled = _Folder != null;
            bearbeitenToolStripMenuItem1.Enabled = LvWords.SelectedItems.Count == 1;
            löschenToolStripMenuItem1.Enabled = LvWords.SelectedItems.Count > 0;

            //TODO CutCopyPaste
            kopierenToolStripMenuItem1.Enabled = false;
            ausschneidenToolStripMenuItem1.Enabled = false;
            einfügenToolStripMenuItem1.Enabled = false;
        }

        private void LvWords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        #region Ansicht
        private void großeSymboleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LvWords.View = View.LargeIcon;
        }
        private void kleineSymboleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LvWords.View = View.SmallIcon;
        }
        private void kachelnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LvWords.View = View.Tile;
        }
        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LvWords.View = View.List;
        }
        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LvWords.View = View.Details;
        }
        #endregion

        private void syntaxAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ShowText = !_ShowText;
            UpdateView();
        }

        private void LvWords_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (_Edit && LvWords.SelectedItems.Count > 0)
                try
                {
                    List<Word> words = new List<Word>(LvWords.SelectedItems.Count);
                    foreach (ListViewItem item in LvWords.SelectedItems)
                        words.Add(item.Tag as Word);
                    var res = DoDragDrop(words, DragDropEffects.Copy | DragDropEffects.Move);
                    if (res == DragDropEffects.Move)
                    {
                        UpdateView();
                    }
                }
                catch (Exception exc) { MessageBox.Show("Fehler beim Verschieben von Vokabeln"); }
        }

    }
}
