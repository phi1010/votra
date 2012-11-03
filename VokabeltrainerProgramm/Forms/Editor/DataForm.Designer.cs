namespace PhillipKuhrt.VoTra.Forms.Editor
{
    partial class DataForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.Split = new System.Windows.Forms.SplitContainer();
            this.ControlFolders = new PhillipKuhrt.VoTra.Controls.FolderControl();
            this.ControlWords = new PhillipKuhrt.VoTra.Controls.WordControl();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Status = new System.Windows.Forms.StatusStrip();
            this.StatusFolder = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Split.Panel1.SuspendLayout();
            this.Split.Panel2.SuspendLayout();
            this.Split.SuspendLayout();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // Split
            // 
            this.Split.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Split.Location = new System.Drawing.Point(0, 0);
            this.Split.Name = "Split";
            // 
            // Split.Panel1
            // 
            this.Split.Panel1.Controls.Add(this.ControlFolders);
            // 
            // Split.Panel2
            // 
            this.Split.Panel2.Controls.Add(this.ControlWords);
            this.Split.Size = new System.Drawing.Size(841, 688);
            this.Split.SplitterDistance = 397;
            this.Split.TabIndex = 0;
            // 
            // ControlFolders
            // 
            this.ControlFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlFolders.Edit = true;
            this.ControlFolders.FolderIcons = null;
            this.ControlFolders.Folders = null;
            this.ControlFolders.Location = new System.Drawing.Point(0, 0);
            this.ControlFolders.Name = "ControlFolders";
            this.ControlFolders.Size = new System.Drawing.Size(393, 684);
            this.ControlFolders.TabIndex = 0;
            this.ControlFolders.SelectionChanged += new System.EventHandler(this.ControlFolders_SelectionChanged);
            this.ControlFolders.Load += new System.EventHandler(this.folderControl1_Load);
            this.ControlFolders.DoubleClick += new System.EventHandler(this.folderControl1_DoubleClick);
            // 
            // ControlWords
            // 
            this.ControlWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlWords.Edit = false;
            this.ControlWords.Folder = null;
            this.ControlWords.Location = new System.Drawing.Point(0, 0);
            this.ControlWords.Name = "ControlWords";
            this.ControlWords.ShowText = false;
            this.ControlWords.Size = new System.Drawing.Size(436, 684);
            this.ControlWords.TabIndex = 0;
            this.ControlWords.User = null;
            // 
            // Tooltip
            // 
            this.Tooltip.IsBalloon = true;
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusFolder});
            this.Status.Location = new System.Drawing.Point(0, 666);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(841, 22);
            this.Status.TabIndex = 2;
            this.Status.Text = "statusStrip1";
            this.Status.Visible = false;
            // 
            // StatusFolder
            // 
            this.StatusFolder.Name = "StatusFolder";
            this.StatusFolder.Size = new System.Drawing.Size(0, 17);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "agt_forward_256x256-32.png");
            this.imageList1.Images.SetKeyName(1, "find_256x256-32.png");
            this.imageList1.Images.SetKeyName(2, "search_256x256-32.png");
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 688);
            this.Controls.Add(this.Split);
            this.Controls.Add(this.Status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataForm";
            this.Text = "Datenverwaltung";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.DataForm_Click);
            this.MouseEnter += new System.EventHandler(this.DataForm_MouseEnter);
            this.Split.Panel1.ResumeLayout(false);
            this.Split.Panel2.ResumeLayout(false);
            this.Split.ResumeLayout(false);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer Split;
        private System.Windows.Forms.ToolTip Tooltip;
        private System.Windows.Forms.StatusStrip Status;
        private Controls.FolderControl ControlFolders;
        private Controls.WordControl ControlWords;
        private System.Windows.Forms.ToolStripStatusLabel StatusFolder;
        private System.Windows.Forms.ImageList imageList1;
    }
}

