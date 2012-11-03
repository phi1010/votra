namespace PhillipKuhrt.VoTra.Forms.Main
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.lblTest = new System.Windows.Forms.Label();
            this.lblManagement = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblExport = new System.Windows.Forms.Label();
            this.lblImport = new System.Windows.Forms.Label();
            this.lblStatistics = new System.Windows.Forms.Label();
            this.lblTestToDo = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.pbUserIcon = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            this.lblTest.AutoEllipsis = true;
            this.lblTest.AutoSize = true;
            this.lblTest.BackColor = System.Drawing.Color.Transparent;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.ForeColor = System.Drawing.Color.White;
            this.lblTest.Location = new System.Drawing.Point(12, 115);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(139, 20);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "Vokabeln lernen";
            this.lblTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTest.Click += new System.EventHandler(this.lblTest_Click);
            this.lblTest.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.lblTest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            // 
            // lblManagement
            // 
            this.lblManagement.AutoEllipsis = true;
            this.lblManagement.AutoSize = true;
            this.lblManagement.BackColor = System.Drawing.Color.Transparent;
            this.lblManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagement.ForeColor = System.Drawing.Color.White;
            this.lblManagement.Location = new System.Drawing.Point(12, 367);
            this.lblManagement.Name = "lblManagement";
            this.lblManagement.Size = new System.Drawing.Size(163, 20);
            this.lblManagement.TabIndex = 2;
            this.lblManagement.Text = "Vokabeln eingeben";
            this.lblManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblManagement.Click += new System.EventHandler(this.lblManagement_Click);
            this.lblManagement.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.lblManagement.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoEllipsis = true;
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(218, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(89, 20);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "Schließen";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.lblClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            // 
            // lblExport
            // 
            this.lblExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExport.AutoEllipsis = true;
            this.lblExport.AutoSize = true;
            this.lblExport.BackColor = System.Drawing.Color.Transparent;
            this.lblExport.Enabled = false;
            this.lblExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExport.ForeColor = System.Drawing.Color.Gray;
            this.lblExport.Location = new System.Drawing.Point(48, 400);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(127, 13);
            this.lblExport.TabIndex = 7;
            this.lblExport.Text = "Vokabeln exportieren";
            this.lblExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblExport.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.lblExport.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            // 
            // lblImport
            // 
            this.lblImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImport.AutoEllipsis = true;
            this.lblImport.AutoSize = true;
            this.lblImport.BackColor = System.Drawing.Color.Transparent;
            this.lblImport.Enabled = false;
            this.lblImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImport.ForeColor = System.Drawing.Color.Gray;
            this.lblImport.Location = new System.Drawing.Point(49, 387);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(126, 13);
            this.lblImport.TabIndex = 8;
            this.lblImport.Text = "Vokabeln importieren";
            this.lblImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblImport.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.lblImport.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            // 
            // lblStatistics
            // 
            this.lblStatistics.AutoEllipsis = true;
            this.lblStatistics.AutoSize = true;
            this.lblStatistics.BackColor = System.Drawing.Color.Transparent;
            this.lblStatistics.Enabled = false;
            this.lblStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistics.ForeColor = System.Drawing.Color.Gray;
            this.lblStatistics.Location = new System.Drawing.Point(12, 242);
            this.lblStatistics.Name = "lblStatistics";
            this.lblStatistics.Size = new System.Drawing.Size(149, 20);
            this.lblStatistics.TabIndex = 9;
            this.lblStatistics.Text = "Statistik ansehen";
            this.lblStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatistics.Visible = false;
            this.lblStatistics.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.lblStatistics.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            // 
            // lblTestToDo
            // 
            this.lblTestToDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTestToDo.AutoEllipsis = true;
            this.lblTestToDo.AutoSize = true;
            this.lblTestToDo.BackColor = System.Drawing.Color.Transparent;
            this.lblTestToDo.Enabled = false;
            this.lblTestToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestToDo.ForeColor = System.Drawing.Color.Gray;
            this.lblTestToDo.Location = new System.Drawing.Point(13, 135);
            this.lblTestToDo.Name = "lblTestToDo";
            this.lblTestToDo.Size = new System.Drawing.Size(138, 13);
            this.lblTestToDo.TabIndex = 10;
            this.lblTestToDo.Text = "--- Vokabeln empfohlen";
            this.lblTestToDo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoEllipsis = true;
            this.lblSettings.AutoSize = true;
            this.lblSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.White;
            this.lblSettings.Location = new System.Drawing.Point(12, 483);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(118, 20);
            this.lblSettings.TabIndex = 11;
            this.lblSettings.Text = "Einstellungen";
            this.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSettings.Click += new System.EventHandler(this.lblSettings_Click);
            this.lblSettings.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.lblSettings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            // 
            // pbUserIcon
            // 
            this.pbUserIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbUserIcon.Location = new System.Drawing.Point(12, 12);
            this.pbUserIcon.Name = "pbUserIcon";
            this.pbUserIcon.Size = new System.Drawing.Size(48, 48);
            this.pbUserIcon.TabIndex = 12;
            this.pbUserIcon.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoEllipsis = true;
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(12, 63);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(150, 20);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "No User Selected";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            this.lblUserName.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.lblUserName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(266, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(230, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Verschieben";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(319, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pbUserIcon);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.lblTestToDo);
            this.Controls.Add(this.lblStatistics);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblManagement);
            this.Controls.Add(this.lblImport);
            this.Controls.Add(this.lblExport);
            this.Controls.Add(this.lblClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vokabeltrainer";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblManagement;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.Label lblImport;
        private System.Windows.Forms.Label lblStatistics;
        private System.Windows.Forms.Label lblTestToDo;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.PictureBox pbUserIcon;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

