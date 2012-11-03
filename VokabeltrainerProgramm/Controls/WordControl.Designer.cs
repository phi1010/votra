namespace PhillipKuhrt.VoTra.Controls
{
    partial class WordControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordControl));
            this.LvWords = new System.Windows.Forms.ListView();
            this.chTextGerman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTextOtherLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInfoGerman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInfoOtherLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ausschneidenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopierenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.einfügenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.großeSymboleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kleineSymboleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kachelnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.syntaxAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LvWords
            // 
            this.LvWords.AllowColumnReorder = true;
            this.LvWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTextGerman,
            this.chTextOtherLanguage,
            this.chInfoGerman,
            this.chInfoOtherLanguage,
            this.chInfo});
            this.LvWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvWords.FullRowSelect = true;
            this.LvWords.GridLines = true;
            this.LvWords.HideSelection = false;
            this.LvWords.Location = new System.Drawing.Point(0, 0);
            this.LvWords.Name = "LvWords";
            this.LvWords.ShowGroups = false;
            this.LvWords.Size = new System.Drawing.Size(723, 240);
            this.LvWords.TabIndex = 1;
            this.LvWords.UseCompatibleStateImageBehavior = false;
            this.LvWords.View = System.Windows.Forms.View.Details;
            this.LvWords.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvWords_ItemDrag);
            this.LvWords.SelectedIndexChanged += new System.EventHandler(this.LvWords_SelectedIndexChanged);
            this.LvWords.DoubleClick += new System.EventHandler(this.LvWords_DoubleClick);
            // 
            // chTextGerman
            // 
            this.chTextGerman.Text = "Deutsch";
            this.chTextGerman.Width = 140;
            // 
            // chTextOtherLanguage
            // 
            this.chTextOtherLanguage.Text = "Fremdsprache";
            this.chTextOtherLanguage.Width = 121;
            // 
            // chInfoGerman
            // 
            this.chInfoGerman.Text = "Hinweis Deutsch";
            this.chInfoGerman.Width = 136;
            // 
            // chInfoOtherLanguage
            // 
            this.chInfoOtherLanguage.Text = "Hinweis Fremdsprache";
            this.chInfoOtherLanguage.Width = 167;
            // 
            // chInfo
            // 
            this.chInfo.Text = "Hinweis danach";
            this.chInfo.Width = 134;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.bearbeitenToolStripMenuItem1,
            this.löschenToolStripMenuItem1,
            this.toolStripSeparator3,
            this.ausschneidenToolStripMenuItem1,
            this.kopierenToolStripMenuItem1,
            this.einfügenToolStripMenuItem1,
            this.toolStripSeparator1,
            this.großeSymboleToolStripMenuItem,
            this.kleineSymboleToolStripMenuItem,
            this.kachelnToolStripMenuItem,
            this.listeToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.syntaxAnzeigenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 404);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Image = global::PhillipKuhrt.VoTra.Properties.Resources.edit_add_256x256_32;
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.neuToolStripMenuItem.Text = "Neu...";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem1
            // 
            this.bearbeitenToolStripMenuItem1.Image = global::PhillipKuhrt.VoTra.Properties.Resources.configure_256x256_32;
            this.bearbeitenToolStripMenuItem1.Name = "bearbeitenToolStripMenuItem1";
            this.bearbeitenToolStripMenuItem1.Size = new System.Drawing.Size(208, 30);
            this.bearbeitenToolStripMenuItem1.Text = "Bearbeiten...";
            this.bearbeitenToolStripMenuItem1.Click += new System.EventHandler(this.bearbeitenToolStripMenuItem1_Click);
            // 
            // löschenToolStripMenuItem1
            // 
            this.löschenToolStripMenuItem1.Image = global::PhillipKuhrt.VoTra.Properties.Resources.edit_remove_256x256_32;
            this.löschenToolStripMenuItem1.Name = "löschenToolStripMenuItem1";
            this.löschenToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.löschenToolStripMenuItem1.Size = new System.Drawing.Size(208, 30);
            this.löschenToolStripMenuItem1.Text = "Löschen...";
            this.löschenToolStripMenuItem1.Click += new System.EventHandler(this.löschenToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(205, 6);
            // 
            // ausschneidenToolStripMenuItem1
            // 
            this.ausschneidenToolStripMenuItem1.Image = global::PhillipKuhrt.VoTra.Properties.Resources.editcut_256x256_32;
            this.ausschneidenToolStripMenuItem1.Name = "ausschneidenToolStripMenuItem1";
            this.ausschneidenToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ausschneidenToolStripMenuItem1.Size = new System.Drawing.Size(208, 30);
            this.ausschneidenToolStripMenuItem1.Text = "Ausschneiden";
            this.ausschneidenToolStripMenuItem1.Click += new System.EventHandler(this.ausschneidenToolStripMenuItem1_Click);
            // 
            // kopierenToolStripMenuItem1
            // 
            this.kopierenToolStripMenuItem1.Image = global::PhillipKuhrt.VoTra.Properties.Resources.editcopy_256x256_32;
            this.kopierenToolStripMenuItem1.Name = "kopierenToolStripMenuItem1";
            this.kopierenToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopierenToolStripMenuItem1.Size = new System.Drawing.Size(208, 30);
            this.kopierenToolStripMenuItem1.Text = "Kopieren";
            this.kopierenToolStripMenuItem1.Click += new System.EventHandler(this.kopierenToolStripMenuItem1_Click);
            // 
            // einfügenToolStripMenuItem1
            // 
            this.einfügenToolStripMenuItem1.Image = global::PhillipKuhrt.VoTra.Properties.Resources.editpaste_256x256_32;
            this.einfügenToolStripMenuItem1.Name = "einfügenToolStripMenuItem1";
            this.einfügenToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.einfügenToolStripMenuItem1.Size = new System.Drawing.Size(208, 30);
            this.einfügenToolStripMenuItem1.Text = "Einfügen";
            this.einfügenToolStripMenuItem1.Click += new System.EventHandler(this.einfügenToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // großeSymboleToolStripMenuItem
            // 
            this.großeSymboleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("großeSymboleToolStripMenuItem.Image")));
            this.großeSymboleToolStripMenuItem.Name = "großeSymboleToolStripMenuItem";
            this.großeSymboleToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.großeSymboleToolStripMenuItem.Text = "Große Symbole";
            this.großeSymboleToolStripMenuItem.Visible = false;
            this.großeSymboleToolStripMenuItem.Click += new System.EventHandler(this.großeSymboleToolStripMenuItem_Click);
            // 
            // kleineSymboleToolStripMenuItem
            // 
            this.kleineSymboleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kleineSymboleToolStripMenuItem.Image")));
            this.kleineSymboleToolStripMenuItem.Name = "kleineSymboleToolStripMenuItem";
            this.kleineSymboleToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.kleineSymboleToolStripMenuItem.Text = "Kleine Symbole";
            this.kleineSymboleToolStripMenuItem.Visible = false;
            this.kleineSymboleToolStripMenuItem.Click += new System.EventHandler(this.kleineSymboleToolStripMenuItem_Click);
            // 
            // kachelnToolStripMenuItem
            // 
            this.kachelnToolStripMenuItem.Image = global::PhillipKuhrt.VoTra.Properties.Resources.view_multicolumn_256x256_32;
            this.kachelnToolStripMenuItem.Name = "kachelnToolStripMenuItem";
            this.kachelnToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.kachelnToolStripMenuItem.Text = "Kacheln";
            this.kachelnToolStripMenuItem.Click += new System.EventHandler(this.kachelnToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Image = global::PhillipKuhrt.VoTra.Properties.Resources.view_multicolumn_256x256_32;
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.listeToolStripMenuItem.Text = "Liste";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Image = global::PhillipKuhrt.VoTra.Properties.Resources.view_detailed_256x256_32;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // syntaxAnzeigenToolStripMenuItem
            // 
            this.syntaxAnzeigenToolStripMenuItem.Image = global::PhillipKuhrt.VoTra.Properties.Resources.info_256x256_32;
            this.syntaxAnzeigenToolStripMenuItem.Name = "syntaxAnzeigenToolStripMenuItem";
            this.syntaxAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.syntaxAnzeigenToolStripMenuItem.Text = "Syntax/Text umschalten";
            this.syntaxAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.syntaxAnzeigenToolStripMenuItem_Click);
            // 
            // WordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.LvWords);
            this.Name = "WordControl";
            this.Size = new System.Drawing.Size(723, 240);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvWords;
        private System.Windows.Forms.ColumnHeader chTextGerman;
        private System.Windows.Forms.ColumnHeader chTextOtherLanguage;
        private System.Windows.Forms.ColumnHeader chInfoGerman;
        private System.Windows.Forms.ColumnHeader chInfoOtherLanguage;
        private System.Windows.Forms.ColumnHeader chInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ausschneidenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kopierenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem einfügenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem großeSymboleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kleineSymboleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kachelnToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem syntaxAnzeigenToolStripMenuItem;
    }
}
