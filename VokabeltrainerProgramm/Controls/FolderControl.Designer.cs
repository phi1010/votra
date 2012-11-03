namespace PhillipKuhrt.VoTra.Controls
{
    partial class FolderControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Tree = new System.Windows.Forms.TreeView();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewTop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.ausschneidenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einfügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tree
            // 
            this.Tree.AllowDrop = true;
            this.Tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tree.HideSelection = false;
            this.Tree.Location = new System.Drawing.Point(0, 0);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(561, 502);
            this.Tree.TabIndex = 0;
            this.Tree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.Tree_AfterLabelEdit);
            this.Tree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.Tree_ItemDrag);
            this.Tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tree_AfterSelect);
            this.Tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Tree_NodeMouseClick);
            this.Tree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Tree_NodeMouseDoubleClick);
            this.Tree.DragDrop += new System.Windows.Forms.DragEventHandler(this.Tree_DragDrop);
            this.Tree.DragEnter += new System.Windows.Forms.DragEventHandler(this.Tree_DragEnter);
            this.Tree.DragOver += new System.Windows.Forms.DragEventHandler(this.Tree_DragOver);
            // 
            // ContextMenu
            // 
            this.ContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiNewTop,
            this.tsmiEdit,
            this.tsmiDelete,
            this.tss1,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste});
            this.ContextMenu.Name = "contextMenuStrip1";
            this.ContextMenu.Size = new System.Drawing.Size(200, 242);
            this.ContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenu_Opening);
            // 
            // tsmiNew
            // 
            this.tsmiNew.Image = global::PhillipKuhrt.VoTra.Properties.Resources.edit_add_256x256_32;
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.tsmiNew.Size = new System.Drawing.Size(199, 30);
            this.tsmiNew.Text = "Neu...";
            this.tsmiNew.Click += new System.EventHandler(this.ContextMenu_New_Click);
            // 
            // tsmiNewTop
            // 
            this.tsmiNewTop.Image = global::PhillipKuhrt.VoTra.Properties.Resources.edit_add_256x256_32;
            this.tsmiNewTop.Name = "tsmiNewTop";
            this.tsmiNewTop.Size = new System.Drawing.Size(199, 30);
            this.tsmiNewTop.Text = "Neu (oberste Ebene)...";
            this.tsmiNewTop.Click += new System.EventHandler(this.ContextMenu_NewTop_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Image = global::PhillipKuhrt.VoTra.Properties.Resources.configure_256x256_32;
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(199, 30);
            this.tsmiEdit.Text = "Bearbeiten...";
            this.tsmiEdit.Click += new System.EventHandler(this.ContextMenu_Edit_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = global::PhillipKuhrt.VoTra.Properties.Resources.edit_remove_256x256_32;
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmiDelete.Size = new System.Drawing.Size(199, 30);
            this.tsmiDelete.Text = "Löschen...";
            this.tsmiDelete.Click += new System.EventHandler(this.ContextMenu_Delete_Click);
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(196, 6);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Image = global::PhillipKuhrt.VoTra.Properties.Resources.editcut_256x256_32;
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCut.Size = new System.Drawing.Size(199, 30);
            this.tsmiCut.Text = "Ausschneiden";
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Image = global::PhillipKuhrt.VoTra.Properties.Resources.editcopy_256x256_32;
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopy.Size = new System.Drawing.Size(199, 30);
            this.tsmiCopy.Text = "Kopieren";
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Image = global::PhillipKuhrt.VoTra.Properties.Resources.editpaste_256x256_32;
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiPaste.Size = new System.Drawing.Size(199, 30);
            this.tsmiPaste.Text = "Einfügen";
            // 
            // ausschneidenToolStripMenuItem
            // 
            this.ausschneidenToolStripMenuItem.Name = "ausschneidenToolStripMenuItem";
            this.ausschneidenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ausschneidenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ausschneidenToolStripMenuItem.Text = "Ausschneiden";
            // 
            // kopierenToolStripMenuItem
            // 
            this.kopierenToolStripMenuItem.Name = "kopierenToolStripMenuItem";
            this.kopierenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopierenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.kopierenToolStripMenuItem.Text = "Kopieren";
            // 
            // einfügenToolStripMenuItem
            // 
            this.einfügenToolStripMenuItem.Name = "einfügenToolStripMenuItem";
            this.einfügenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.einfügenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.einfügenToolStripMenuItem.Text = "Einfügen";
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // FolderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.ContextMenu;
            this.Controls.Add(this.Tree);
            this.Name = "FolderControl";
            this.Size = new System.Drawing.Size(561, 502);
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView Tree;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ausschneidenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einfügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewTop;
    }
}
