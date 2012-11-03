using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PhillipKuhrt.VoTra.Icons;

namespace PhillipKuhrt.VoTra.Controls
{
    [DefaultEvent("SelectionChanged")]
    public partial class FolderControl : UserControl
    {

        public FolderControl()
        {
            InitializeComponent();
            Edit = false;
        }



        private List<Data.Folder> _Folders = null;
        private bool _Edit;
        private IconsFolder _FolderIcons = null;



        public event EventHandler SelectionChanged;



        [Browsable(false)]
        public IconsFolder FolderIcons
        {
            get { return _FolderIcons; }
            set
            {
                _FolderIcons = value;
                UpdateIcons();
            }
        }

        [Browsable(false)]
        public Data.Folder SelectedFolder
        {
            get
            {
                if (Tree.SelectedNode != null)
                    return Tree.SelectedNode.Tag as Data.Folder;
                else
                    return null;
            }
        }

        public bool Edit
        {
            get { return _Edit; }
            set
            {
                Tree.LabelEdit = value;
                _Edit = value;
            }
        }

        [Browsable(false)]
        public List<Data.Folder> Folders
        {
            get { return _Folders; }
            set
            {
                _Folders = value;
                UpdateView();
            }
        }



        private void UpdateIcons()
        {
            Tree.BeginUpdate();
            ImageList imgL = new ImageList();
            imgL.ColorDepth = ColorDepth.Depth32Bit;
            imgL.ImageSize = new System.Drawing.Size(32, 32);
            if (_FolderIcons != null)
                foreach (var kvp in _FolderIcons.IconDictionary)
                    imgL.Images.Add(kvp.Key.ToString(), kvp.Value);
            Tree.ImageList = imgL;
            Tree.EndUpdate();
        }

        public void UpdateView()
        {
            Tree.BeginUpdate();
            Tree.Nodes.Clear();
            if (_Folders != null)
                foreach (var folder in _Folders)
                    Tree.Nodes.Add(GetNode(folder));
            Tree.Sort();
            Tree.EndUpdate();
        }

        private TreeNode GetNode(Data.Folder folder)
        {
            if (folder != null)
            {
                TreeNode tn = new TreeNode(folder.Title);
                if (folder.SymbolID == 0 || folder.SymbolID == 1)
                {
                    tn.ImageKey = "0";
                    tn.SelectedImageKey = "1";
                }
                else
                {
                    tn.ImageKey = folder.SymbolID.ToString();
                    tn.SelectedImageKey = folder.SymbolID.ToString();
                }
                tn.Tag = folder;
                foreach (var f in folder.Folders)
                    tn.Nodes.Add(GetNode(f));
                tn.ContextMenuStrip = ContextMenu;
                return tn;
            }
            else
                return null;
        }

        private void UpdateNode(TreeNode tn)
        {
            if (tn != null)
                if (tn.Tag is Data.Folder)
                {
                    Data.Folder folder = tn.Tag as Data.Folder;
                    Tree.BeginUpdate();
                    tn.Text = folder.Title;
                    if (folder.SymbolID == 0 || folder.SymbolID == 1)
                    {
                        tn.ImageKey = "0";
                        tn.SelectedImageKey = "1";
                    }
                    else
                    {
                        tn.ImageKey = folder.SymbolID.ToString();
                        tn.SelectedImageKey = folder.SymbolID.ToString();
                    }
                    //tn.Nodes.Clear();
                    //foreach (var f in folder.Folders)
                    //    tn.Nodes.Add(GetNode(f));
                    Tree.Sort();
                    Tree.SelectedNode = tn;
                    Tree.EndUpdate();
                }
        }



        private void Tree_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (_Edit)
                try
                {
                    //_DDSourceNode = (TreeNode)e.Item;
                    //DoDragDrop((e.Item as TreeNode).Tag as Data.Folder, DragDropEffects.Copy | DragDropEffects.Move);
                    //_DDSourceNode = null;
                    TreeNode node = e.Item as TreeNode;
                    Data.Folder folder = node.Tag as Data.Folder;
                    if (folder != null)
                    {
                        bool nul = folder.Parent == null;
                        var res = DoDragDrop(folder, DragDropEffects.Copy | DragDropEffects.Move);
                        if (res == DragDropEffects.Move)
                        {
                            if (nul)
                            {
                                if (Tree.Nodes.Contains(node))
                                    Tree.Nodes.Remove(node);
                                if (_Folders.Contains(folder))
                                    _Folders.Remove(folder);
                            }
                            else
                            {
                                if (node.Parent.Nodes.Contains(node))
                                    node.Parent.Nodes.Remove(node);
                            }
                        }
                    }
                }
                catch (Exception exc) { MessageBox.Show("Fehler beim Verschieben eines Ordners"); }
        }
        private void Tree_DragEnter(object sender, DragEventArgs e)
        {
            Tree_DragOver(sender, e);
        }
        private void Tree_DragOver(object sender, DragEventArgs e)
        {
            if (_Edit)
            {
                if (e.Data != null && e.Data.GetDataPresent(typeof(Data.Folder)))
                {
                    try
                    {
                        Data.Folder FolderSource = e.Data.GetData(typeof(Data.Folder)) as Data.Folder;

                        if (FolderSource != null)
                        {
                            Point Position = new Point(e.X, e.Y);
                            Position = Tree.PointToClient(Position);
                            TreeNode DropNode = this.Tree.GetNodeAt(Position);

                            if (DropNode != null)
                            {
                                Data.Folder FolderDestination = DropNode.Tag as Data.Folder;

                                if
                                    (
                                    (!FolderSource.Contains(FolderDestination)) &&
                                    ((e.AllowedEffect & DragDropEffects.Move) != 0)
                                    )
                                {
                                    e.Effect = DragDropEffects.Move;
                                    return;
                                }
                            }
                            else if ((e.AllowedEffect & DragDropEffects.Move) != 0)
                            {
                                //Verschieben in die oberste Ebene immer zulassen
                                if ((e.AllowedEffect & DragDropEffects.Move) != 0)
                                {
                                    e.Effect = DragDropEffects.Move;
                                    return;
                                }
                            }
                        }
                    }
                    catch (Exception exc) { MessageBox.Show("Fehler beim Verschieben eines Ordners"); }
                }
                else if (e.Data != null && e.Data.GetDataPresent(typeof(List<Data.Word>)))
                {
                    List<Data.Word> Words = e.Data.GetData(typeof(List<Data.Word>)) as List<Data.Word>;
                    if (Words != null && Words.Count > 0)
                    {
                        Point Position = new Point(e.X, e.Y);
                        Position = Tree.PointToClient(Position);
                        TreeNode DropNode = this.Tree.GetNodeAt(Position);

                        if (DropNode != null)
                        {

                            if ((e.AllowedEffect & DragDropEffects.Move) != 0)
                            {
                                e.Effect = DragDropEffects.Move;
                                return;
                            }
                        }
                    }
                }
            }
            e.Effect = DragDropEffects.None;
        }
        private void Tree_DragDrop(object sender, DragEventArgs e)
        {
            if (_Edit)
            {
                if (e.Data != null && e.Data.GetDataPresent(typeof(Data.Folder)))
                {
                    try
                    {
                        Data.Folder FolderSource = e.Data.GetData(typeof(Data.Folder)) as Data.Folder;

                        if (FolderSource != null)
                        {
                            Point Position = new Point(e.X, e.Y);
                            Position = Tree.PointToClient(Position);
                            TreeNode DropNode = this.Tree.GetNodeAt(Position);

                            if (DropNode != null)
                            {
                                Data.Folder FolderDestination = DropNode.Tag as Data.Folder;

                                if
                                    (
                                    (!FolderSource.Contains(FolderDestination)) &&
                                    ((e.AllowedEffect & DragDropEffects.Move) != 0)
                                    )
                                {
                                    FolderSource.Parent = FolderDestination;
                                    DropNode.Nodes.Add(GetNode(FolderSource));
                                    e.Effect = DragDropEffects.Move;
                                    return;
                                }
                            }
                            else if ((e.AllowedEffect & DragDropEffects.Move) != 0)
                            {
                                _Folders.Add(FolderSource);
                                FolderSource.Parent = null;
                                Tree.Nodes.Add(GetNode(FolderSource));
                                Tree.Sort();
                                e.Effect = DragDropEffects.Move;
                                return;
                            }
                        }
                    }
                    catch (Exception exc) { MessageBox.Show("Fehler beim Verschieben eines Ordners"); }
                }
                else if (e.Data != null && e.Data.GetDataPresent(typeof(List<Data.Word>)))
                {
                    List<Data.Word> Words = e.Data.GetData(typeof(List<Data.Word>)) as List<Data.Word>;
                    if (Words != null && Words.Count > 0)
                    {
                        Point Position = new Point(e.X, e.Y);
                        Position = Tree.PointToClient(Position);
                        TreeNode DropNode = this.Tree.GetNodeAt(Position);

                        if (DropNode != null)
                        {
                            Data.Folder FolderDestination = DropNode.Tag as Data.Folder;
                            if ((e.AllowedEffect & DragDropEffects.Move) != 0)
                            {
                                foreach (var w in Words)
                                {
                                    w.Parent = FolderDestination;
                                }
                                e.Effect = DragDropEffects.Move;
                                return;
                            }
                        }
                    }
                }
            }
            e.Effect = DragDropEffects.None;
        }
        private void Tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Tree.SelectedNode = e.Node;
        }
        private void Tree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //if (treeView1.SelectedNode != null)
            //{
            //    var f1 = treeView1.SelectedNode.Tag as Data.Folder;
            //    var dlg = new PhillipKuhrt.VoTra.Forms.Editor.FolderSettingsDialog(f1, _FolderIcons);
            //    dlg.ShowDialog();
            //    UpdateNode(treeView1.SelectedNode);
            //}
        }
        private void Tree_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (
                _Edit &&
                e.Label != null &&
                e.Label != "" &&
                e.Node != null
                )
            {
                e.Node.Text = e.Label;
                (e.Node.Tag as Data.Folder).Title = e.Label;
            }
            else
                e.CancelEdit = true;
        }
        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (SelectionChanged != null)
                SelectionChanged(this, new EventArgs());
        }

        private void ContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (!_Edit)
            {
                e.Cancel = true;
                return;
            }

            if (Tree.SelectedNode != null)
            {
                tsmiNew.Enabled = true;
                tsmiDelete.Enabled = true;

                //TODOL CutCopyPaste
                tsmiCut.Enabled = false;
                tsmiCopy.Enabled = false;
                tsmiPaste.Enabled = false;
            }
            else
            {
                tsmiNew.Enabled = true;
                tsmiDelete.Enabled = false;
                tsmiCut.Enabled = false;
                tsmiCopy.Enabled = false;

                //TODOL CutCopyPaste
                tsmiPaste.Enabled = false;
            }
        }
        private void ContextMenu_New_Click(object sender, EventArgs e)
        {
            if (Tree.SelectedNode == null)
            {
                var f = new Data.Folder();
                _Folders.Add(f);
                var dlg = new PhillipKuhrt.VoTra.Forms.Editor.FolderSettingsDialog(f, _FolderIcons);
                dlg.ShowDialog();
                Tree.BeginUpdate();
                Tree.Nodes.Add(GetNode(f));
                Tree.Sort();
                Tree.EndUpdate();
            }
            else
            {
                var f1 = Tree.SelectedNode.Tag as Data.Folder;
                var f2 = new Data.Folder();
                f2.Parent = f1;
                var dlg = new PhillipKuhrt.VoTra.Forms.Editor.FolderSettingsDialog(f2, _FolderIcons);
                dlg.ShowDialog();
                Tree.BeginUpdate();
                Tree.SelectedNode.Nodes.Add(GetNode(f2));
                Tree.Sort();
                Tree.EndUpdate();
            }
        }
        private void ContextMenu_Edit_Click(object sender, EventArgs e)
        {
            if (Tree.SelectedNode != null)
            {
                var f1 = Tree.SelectedNode.Tag as Data.Folder;
                var dlg = new PhillipKuhrt.VoTra.Forms.Editor.FolderSettingsDialog(f1, _FolderIcons);
                dlg.ShowDialog();
                UpdateNode(Tree.SelectedNode);
            }
        }
        private void ContextMenu_Delete_Click(object sender, EventArgs e)
        {
            if (Tree.SelectedNode != null)
            {
                var f1 = Tree.SelectedNode.Tag as Data.Folder;
                if
                    (
                    DialogResult.Yes == MessageBox.Show(
                    "Wollen Sie den Ordner '" + f1.Title + "' wirklich löschen?\n" +
                    "Dieser Ordner enthält " + f1.AllWords.Count.ToString() + " Vokabeln.",
                    "Löschen?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning)
                    )
                {
                    if (f1.Parent == null)
                        _Folders.Remove(f1);
                    else
                        f1.Parent = null;
                    f1.Parent = null;
                    if (Tree.SelectedNode.Parent == null)
                        Tree.Nodes.Remove(Tree.SelectedNode);
                    else
                        Tree.SelectedNode.Parent.Nodes.Remove(Tree.SelectedNode);
                    UpdateNode(Tree.SelectedNode);
                }
            }
        }
        private void ContextMenu_NewTop_Click(object sender, EventArgs e)
        {
            var f = new Data.Folder();
            _Folders.Add(f);
            Tree.BeginUpdate();
            Tree.Nodes.Add(GetNode(f));
            Tree.Sort();
            Tree.EndUpdate();
            var dlg = new PhillipKuhrt.VoTra.Forms.Editor.FolderSettingsDialog(f, _FolderIcons);
            dlg.ShowDialog();
            UpdateNode(Tree.SelectedNode);
        }

    }
}