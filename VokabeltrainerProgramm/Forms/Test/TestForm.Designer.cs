namespace PhillipKuhrt.VoTra.Forms.Test
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pgProgress = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pgQuality = new System.Windows.Forms.ProgressBar();
            this.lblQuality = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbBWord = new System.Windows.Forms.TextBox();
            this.lblAWord = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblAComment = new System.Windows.Forms.Label();
            this.lblBComment = new System.Windows.Forms.Label();
            this.lblALanguage = new System.Windows.Forms.Label();
            this.lblBLanguage = new System.Windows.Forms.Label();
            this.lbAList = new System.Windows.Forms.ListBox();
            this.lbBList = new System.Windows.Forms.ListBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.diffBox1 = new PhillipKuhrt.VoTra.Controls.DiffBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 615);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.Controls.Add(this.pgProgress, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblProgress, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pgQuality, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblQuality, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 545);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(747, 67);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pgProgress
            // 
            this.pgProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgProgress.Location = new System.Drawing.Point(3, 3);
            this.pgProgress.Name = "pgProgress";
            this.pgProgress.Size = new System.Drawing.Size(672, 27);
            this.pgProgress.TabIndex = 0;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoEllipsis = true;
            this.lblProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgress.Location = new System.Drawing.Point(681, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(63, 33);
            this.lblProgress.TabIndex = 1;
            this.lblProgress.Text = "0% Fertig";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pgQuality
            // 
            this.pgQuality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgQuality.Location = new System.Drawing.Point(3, 36);
            this.pgQuality.Name = "pgQuality";
            this.pgQuality.Size = new System.Drawing.Size(672, 28);
            this.pgQuality.TabIndex = 2;
            // 
            // lblQuality
            // 
            this.lblQuality.AutoEllipsis = true;
            this.lblQuality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuality.Location = new System.Drawing.Point(681, 33);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(63, 34);
            this.lblQuality.TabIndex = 3;
            this.lblQuality.Text = "---";
            this.lblQuality.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tbBWord, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblAWord, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnOK, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblAComment, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblBComment, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblALanguage, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblBLanguage, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbAList, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lbBList, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblComment, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.diffBox1, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(747, 536);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tbBWord
            // 
            this.tbBWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBWord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBWord.Location = new System.Drawing.Point(376, 126);
            this.tbBWord.Name = "tbBWord";
            this.tbBWord.Size = new System.Drawing.Size(368, 26);
            this.tbBWord.TabIndex = 1;
            this.tbBWord.Tag = "Zur Eingabe der Lösung";
            this.tbBWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BWord_KeyDown);
            // 
            // lblAWord
            // 
            this.lblAWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAWord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAWord.Location = new System.Drawing.Point(3, 123);
            this.lblAWord.Name = "lblAWord";
            this.lblAWord.Size = new System.Drawing.Size(367, 32);
            this.lblAWord.TabIndex = 6;
            this.lblAWord.Tag = "Zeigt das vorgegebene Wort an";
            this.lblAWord.Text = "Vorgegebenes Wort";
            this.lblAWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOK
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.btnOK, 2);
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(3, 158);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(741, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblAComment
            // 
            this.lblAComment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAComment.Location = new System.Drawing.Point(3, 73);
            this.lblAComment.Name = "lblAComment";
            this.lblAComment.Size = new System.Drawing.Size(367, 50);
            this.lblAComment.TabIndex = 4;
            this.lblAComment.Text = "Hinweis Deutsch/Fremdsprache";
            // 
            // lblBComment
            // 
            this.lblBComment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBComment.Location = new System.Drawing.Point(376, 73);
            this.lblBComment.Name = "lblBComment";
            this.lblBComment.Size = new System.Drawing.Size(368, 50);
            this.lblBComment.TabIndex = 5;
            this.lblBComment.Text = "Hinweis Fremdsprache/Deutsch";
            // 
            // lblALanguage
            // 
            this.lblALanguage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblALanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblALanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALanguage.Location = new System.Drawing.Point(3, 0);
            this.lblALanguage.Name = "lblALanguage";
            this.lblALanguage.Size = new System.Drawing.Size(367, 23);
            this.lblALanguage.TabIndex = 7;
            this.lblALanguage.Text = "Deutsch/Fremdsprache";
            this.lblALanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBLanguage
            // 
            this.lblBLanguage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBLanguage.Location = new System.Drawing.Point(376, 0);
            this.lblBLanguage.Name = "lblBLanguage";
            this.lblBLanguage.Size = new System.Drawing.Size(368, 23);
            this.lblBLanguage.TabIndex = 8;
            this.lblBLanguage.Text = "Fremdsprache/Deutsch";
            this.lblBLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAList
            // 
            this.lbAList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAList.FormattingEnabled = true;
            this.lbAList.IntegralHeight = false;
            this.lbAList.ItemHeight = 16;
            this.lbAList.Location = new System.Drawing.Point(3, 219);
            this.lbAList.Name = "lbAList";
            this.lbAList.ScrollAlwaysVisible = true;
            this.lbAList.Size = new System.Drawing.Size(367, 314);
            this.lbAList.TabIndex = 9;
            this.lbAList.Tag = "Zeigt mögliche Vorgaben nach Korrektur der Vokabel";
            // 
            // lbBList
            // 
            this.lbBList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBList.FormattingEnabled = true;
            this.lbBList.IntegralHeight = false;
            this.lbBList.ItemHeight = 16;
            this.lbBList.Location = new System.Drawing.Point(376, 219);
            this.lbBList.Name = "lbBList";
            this.lbBList.ScrollAlwaysVisible = true;
            this.lbBList.Size = new System.Drawing.Size(368, 314);
            this.lbBList.TabIndex = 10;
            this.lbBList.Tag = "Zeigt mögliche Ergebnisse nach Korrektur der Vokabel";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel3.SetColumnSpan(this.lblComment, 2);
            this.lblComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblComment.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(3, 23);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(741, 50);
            this.lblComment.TabIndex = 11;
            this.lblComment.Text = "Hinweis";
            // 
            // diffBox1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.diffBox1, 2);
            this.diffBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diffBox1.Location = new System.Drawing.Point(3, 187);
            this.diffBox1.Name = "diffBox1";
            this.diffBox1.ReadOnly = true;
            this.diffBox1.Size = new System.Drawing.Size(741, 26);
            this.diffBox1.Solution = "";
            this.diffBox1.TabIndex = 12;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 615);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestForm";
            this.Text = "Vokabelabfrage";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ProgressBar pgProgress;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar pgQuality;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tbBWord;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblAComment;
        private System.Windows.Forms.Label lblBComment;
        private System.Windows.Forms.Label lblAWord;
        private System.Windows.Forms.Label lblALanguage;
        private System.Windows.Forms.Label lblBLanguage;
        private System.Windows.Forms.ListBox lbAList;
        private System.Windows.Forms.ListBox lbBList;
        private System.Windows.Forms.Label lblComment;
        private Controls.DiffBox diffBox1;
    }
}