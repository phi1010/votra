namespace PhillipKuhrt.VoTra.Forms.Test
{
    partial class TestSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestSettings));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NUDCount = new System.Windows.Forms.NumericUpDown();
            this.ImglButtons = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CBVokabelauswahl1 = new System.Windows.Forms.CheckBox();
            this.CBVokabelauswahl2 = new System.Windows.Forms.CheckBox();
            this.CBVokabelauswahl3 = new System.Windows.Forms.CheckBox();
            this.CBVokabelauswahl4 = new System.Windows.Forms.CheckBox();
            this.CBVokabelauswahl5 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbtnPresetGerman = new System.Windows.Forms.RadioButton();
            this.RbtnPresetRandom = new System.Windows.Forms.RadioButton();
            this.RbtnPresetOther = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CBRevise = new System.Windows.Forms.CheckBox();
            this.CBRecursive = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbUserIcon = new System.Windows.Forms.PictureBox();
            this.folderControl1 = new PhillipKuhrt.VoTra.Controls.FolderControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCount)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.NUDCount);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 320);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 39);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Anzahl der Vokabeln";
            // 
            // NUDCount
            // 
            this.NUDCount.AutoSize = true;
            this.NUDCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.NUDCount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUDCount.Location = new System.Drawing.Point(3, 16);
            this.NUDCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDCount.Name = "NUDCount";
            this.NUDCount.Size = new System.Drawing.Size(260, 20);
            this.NUDCount.TabIndex = 0;
            this.NUDCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NUDCount.ValueChanged += new System.EventHandler(this.NUDCount_ValueChanged);
            this.NUDCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NUDCount_KeyUp);
            // 
            // ImglButtons
            // 
            this.ImglButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImglButtons.ImageStream")));
            this.ImglButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.ImglButtons.Images.SetKeyName(0, "037.png");
            this.ImglButtons.Images.SetKeyName(1, "042.png");
            this.ImglButtons.Images.SetKeyName(2, "043.png");
            this.ImglButtons.Images.SetKeyName(3, "1_256x256-32.png");
            this.ImglButtons.Images.SetKeyName(4, "2_256x256-32.png");
            this.ImglButtons.Images.SetKeyName(5, "3_256x256-32.png");
            this.ImglButtons.Images.SetKeyName(6, "4_256x256-32.png");
            this.ImglButtons.Images.SetKeyName(7, "5_256x256-32.png");
            this.ImglButtons.Images.SetKeyName(8, "FolderOpen.png");
            this.ImglButtons.Images.SetKeyName(9, "2leftarrow_256x256-32.png");
            this.ImglButtons.Images.SetKeyName(10, "button_cancel_256x256-32.png");
            this.ImglButtons.Images.SetKeyName(11, "button_ok_256x256-32.png");
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.CBVokabelauswahl1);
            this.groupBox3.Controls.Add(this.CBVokabelauswahl2);
            this.groupBox3.Controls.Add(this.CBVokabelauswahl3);
            this.groupBox3.Controls.Add(this.CBVokabelauswahl4);
            this.groupBox3.Controls.Add(this.CBVokabelauswahl5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 165);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Abzufragende Vokabeln";
            // 
            // CBVokabelauswahl1
            // 
            this.CBVokabelauswahl1.Checked = true;
            this.CBVokabelauswahl1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBVokabelauswahl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBVokabelauswahl1.ImageIndex = 3;
            this.CBVokabelauswahl1.ImageList = this.ImglButtons;
            this.CBVokabelauswahl1.Location = new System.Drawing.Point(3, 144);
            this.CBVokabelauswahl1.Name = "CBVokabelauswahl1";
            this.CBVokabelauswahl1.Size = new System.Drawing.Size(260, 32);
            this.CBVokabelauswahl1.TabIndex = 4;
            this.CBVokabelauswahl1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.CBVokabelauswahl1.UseVisualStyleBackColor = true;
            this.CBVokabelauswahl1.CheckedChanged += new System.EventHandler(this.CBVokabelauswahl_CheckedChanged);
            // 
            // CBVokabelauswahl2
            // 
            this.CBVokabelauswahl2.Checked = true;
            this.CBVokabelauswahl2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBVokabelauswahl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBVokabelauswahl2.ImageIndex = 4;
            this.CBVokabelauswahl2.ImageList = this.ImglButtons;
            this.CBVokabelauswahl2.Location = new System.Drawing.Point(3, 112);
            this.CBVokabelauswahl2.Name = "CBVokabelauswahl2";
            this.CBVokabelauswahl2.Size = new System.Drawing.Size(260, 32);
            this.CBVokabelauswahl2.TabIndex = 3;
            this.CBVokabelauswahl2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.CBVokabelauswahl2.UseVisualStyleBackColor = true;
            this.CBVokabelauswahl2.CheckedChanged += new System.EventHandler(this.CBVokabelauswahl_CheckedChanged);
            // 
            // CBVokabelauswahl3
            // 
            this.CBVokabelauswahl3.Checked = true;
            this.CBVokabelauswahl3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBVokabelauswahl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBVokabelauswahl3.ImageIndex = 5;
            this.CBVokabelauswahl3.ImageList = this.ImglButtons;
            this.CBVokabelauswahl3.Location = new System.Drawing.Point(3, 80);
            this.CBVokabelauswahl3.Name = "CBVokabelauswahl3";
            this.CBVokabelauswahl3.Size = new System.Drawing.Size(260, 32);
            this.CBVokabelauswahl3.TabIndex = 2;
            this.CBVokabelauswahl3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.CBVokabelauswahl3.UseVisualStyleBackColor = true;
            this.CBVokabelauswahl3.CheckedChanged += new System.EventHandler(this.CBVokabelauswahl_CheckedChanged);
            // 
            // CBVokabelauswahl4
            // 
            this.CBVokabelauswahl4.Checked = true;
            this.CBVokabelauswahl4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBVokabelauswahl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBVokabelauswahl4.ImageIndex = 6;
            this.CBVokabelauswahl4.ImageList = this.ImglButtons;
            this.CBVokabelauswahl4.Location = new System.Drawing.Point(3, 48);
            this.CBVokabelauswahl4.Name = "CBVokabelauswahl4";
            this.CBVokabelauswahl4.Size = new System.Drawing.Size(260, 32);
            this.CBVokabelauswahl4.TabIndex = 1;
            this.CBVokabelauswahl4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.CBVokabelauswahl4.UseVisualStyleBackColor = true;
            this.CBVokabelauswahl4.CheckedChanged += new System.EventHandler(this.CBVokabelauswahl_CheckedChanged);
            // 
            // CBVokabelauswahl5
            // 
            this.CBVokabelauswahl5.Checked = true;
            this.CBVokabelauswahl5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBVokabelauswahl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBVokabelauswahl5.ImageIndex = 7;
            this.CBVokabelauswahl5.ImageList = this.ImglButtons;
            this.CBVokabelauswahl5.Location = new System.Drawing.Point(3, 16);
            this.CBVokabelauswahl5.Name = "CBVokabelauswahl5";
            this.CBVokabelauswahl5.Size = new System.Drawing.Size(260, 32);
            this.CBVokabelauswahl5.TabIndex = 0;
            this.CBVokabelauswahl5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.CBVokabelauswahl5.UseVisualStyleBackColor = true;
            this.CBVokabelauswahl5.CheckedChanged += new System.EventHandler(this.CBVokabelauswahl_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.RbtnPresetGerman);
            this.groupBox2.Controls.Add(this.RbtnPresetRandom);
            this.groupBox2.Controls.Add(this.RbtnPresetOther);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vorgegeben";
            // 
            // RbtnPresetGerman
            // 
            this.RbtnPresetGerman.AutoEllipsis = true;
            this.RbtnPresetGerman.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RbtnPresetGerman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RbtnPresetGerman.ImageIndex = 0;
            this.RbtnPresetGerman.ImageList = this.ImglButtons;
            this.RbtnPresetGerman.Location = new System.Drawing.Point(3, 16);
            this.RbtnPresetGerman.Name = "RbtnPresetGerman";
            this.RbtnPresetGerman.Size = new System.Drawing.Size(260, 32);
            this.RbtnPresetGerman.TabIndex = 0;
            this.RbtnPresetGerman.Text = "Deutsch";
            this.RbtnPresetGerman.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RbtnPresetGerman.UseVisualStyleBackColor = true;
            this.RbtnPresetGerman.CheckedChanged += new System.EventHandler(this.RbtnPreset_CheckedChanged);
            // 
            // RbtnPresetRandom
            // 
            this.RbtnPresetRandom.AutoEllipsis = true;
            this.RbtnPresetRandom.Checked = true;
            this.RbtnPresetRandom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RbtnPresetRandom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RbtnPresetRandom.ImageIndex = 1;
            this.RbtnPresetRandom.ImageList = this.ImglButtons;
            this.RbtnPresetRandom.Location = new System.Drawing.Point(3, 48);
            this.RbtnPresetRandom.Name = "RbtnPresetRandom";
            this.RbtnPresetRandom.Size = new System.Drawing.Size(260, 32);
            this.RbtnPresetRandom.TabIndex = 1;
            this.RbtnPresetRandom.TabStop = true;
            this.RbtnPresetRandom.Text = "Zufällig";
            this.RbtnPresetRandom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RbtnPresetRandom.UseVisualStyleBackColor = true;
            this.RbtnPresetRandom.CheckedChanged += new System.EventHandler(this.RbtnPreset_CheckedChanged);
            // 
            // RbtnPresetOther
            // 
            this.RbtnPresetOther.AutoEllipsis = true;
            this.RbtnPresetOther.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RbtnPresetOther.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RbtnPresetOther.ImageIndex = 2;
            this.RbtnPresetOther.ImageList = this.ImglButtons;
            this.RbtnPresetOther.Location = new System.Drawing.Point(3, 80);
            this.RbtnPresetOther.Name = "RbtnPresetOther";
            this.RbtnPresetOther.Size = new System.Drawing.Size(260, 32);
            this.RbtnPresetOther.TabIndex = 2;
            this.RbtnPresetOther.Text = "Fremdsprache";
            this.RbtnPresetOther.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RbtnPresetOther.UseVisualStyleBackColor = true;
            this.RbtnPresetOther.CheckedChanged += new System.EventHandler(this.RbtnPreset_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CBRevise);
            this.splitContainer1.Panel1.Controls.Add(this.CBRecursive);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.folderControl1);
            this.splitContainer1.Size = new System.Drawing.Size(669, 559);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 5;
            // 
            // CBRevise
            // 
            this.CBRevise.AutoEllipsis = true;
            this.CBRevise.Checked = true;
            this.CBRevise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBRevise.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBRevise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CBRevise.ImageIndex = 9;
            this.CBRevise.ImageList = this.ImglButtons;
            this.CBRevise.Location = new System.Drawing.Point(0, 391);
            this.CBRevise.Name = "CBRevise";
            this.CBRevise.Size = new System.Drawing.Size(266, 32);
            this.CBRevise.TabIndex = 0;
            this.CBRevise.Text = "Wiederholung falsch beantworteter Vokabeln";
            this.CBRevise.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBRevise.UseVisualStyleBackColor = true;
            this.CBRevise.CheckedChanged += new System.EventHandler(this.CBRevise_CheckedChanged);
            // 
            // CBRecursive
            // 
            this.CBRecursive.AutoEllipsis = true;
            this.CBRecursive.Checked = true;
            this.CBRecursive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBRecursive.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBRecursive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CBRecursive.ImageIndex = 8;
            this.CBRecursive.ImageList = this.ImglButtons;
            this.CBRecursive.Location = new System.Drawing.Point(0, 359);
            this.CBRecursive.Name = "CBRecursive";
            this.CBRecursive.Size = new System.Drawing.Size(266, 32);
            this.CBRecursive.TabIndex = 4;
            this.CBRecursive.Text = "Unterordner einbeziehen";
            this.CBRecursive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBRecursive.UseVisualStyleBackColor = true;
            this.CBRecursive.CheckedChanged += new System.EventHandler(this.CBRecursive_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblUserName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbUserIcon, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(266, 54);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoEllipsis = true;
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(57, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(206, 54);
            this.lblUserName.TabIndex = 15;
            this.lblUserName.Text = "No User Selected";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbUserIcon
            // 
            this.pbUserIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbUserIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbUserIcon.Location = new System.Drawing.Point(3, 3);
            this.pbUserIcon.Name = "pbUserIcon";
            this.pbUserIcon.Size = new System.Drawing.Size(48, 48);
            this.pbUserIcon.TabIndex = 14;
            this.pbUserIcon.TabStop = false;
            // 
            // folderControl1
            // 
            this.folderControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderControl1.Edit = false;
            this.folderControl1.FolderIcons = null;
            this.folderControl1.Folders = null;
            this.folderControl1.Location = new System.Drawing.Point(0, 0);
            this.folderControl1.Name = "folderControl1";
            this.folderControl1.Size = new System.Drawing.Size(391, 555);
            this.folderControl1.TabIndex = 0;
            this.folderControl1.SelectionChanged += new System.EventHandler(this.folderControl1_SelectionChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnOK, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnCancel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 559);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 41);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // BtnOK
            // 
            this.BtnOK.AutoEllipsis = true;
            this.BtnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnOK.Enabled = false;
            this.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOK.ImageIndex = 11;
            this.BtnOK.ImageList = this.ImglButtons;
            this.BtnOK.Location = new System.Drawing.Point(337, 3);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(329, 35);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "Vokabeln abfragen";
            this.BtnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.AutoEllipsis = true;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.ImageIndex = 10;
            this.BtnCancel.ImageList = this.ImglButtons;
            this.BtnCancel.Location = new System.Drawing.Point(3, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(328, 35);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Testeinstellungen schließen";
            this.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // TestSettings
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(669, 600);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestSettings";
            this.Text = "Testeinstellungen";
            this.Load += new System.EventHandler(this.TestSettings_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown NUDCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox CBVokabelauswahl1;
        private System.Windows.Forms.CheckBox CBVokabelauswahl2;
        private System.Windows.Forms.CheckBox CBVokabelauswahl3;
        private System.Windows.Forms.CheckBox CBVokabelauswahl4;
        private System.Windows.Forms.CheckBox CBVokabelauswahl5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RbtnPresetGerman;
        private System.Windows.Forms.RadioButton RbtnPresetRandom;
        private System.Windows.Forms.RadioButton RbtnPresetOther;
        private System.Windows.Forms.ImageList ImglButtons;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox CBRevise;
        private System.Windows.Forms.CheckBox CBRecursive;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private Controls.FolderControl folderControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pbUserIcon;
    }
}

