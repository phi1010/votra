namespace PhillipKuhrt.VoTra.Forms.Editor
{
    partial class WordSettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordSettingsDialog));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.TBHinweis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LblÄnderung = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LblErstellung = new System.Windows.Forms.Label();
            this.TBDeutsch = new System.Windows.Forms.TextBox();
            this.TBFremdsprache = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBHinweisD = new System.Windows.Forms.TextBox();
            this.TBHinweisF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TBHinweis, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LblÄnderung, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.LblErstellung, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.TBDeutsch, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBFremdsprache, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBHinweisD, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TBHinweisF, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(348, 153);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hinweis";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tooltip.SetToolTip(this.label5, "Wird angezeigt, nachdem die Eingabe korrigiert wurde.");
            // 
            // TBHinweis
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TBHinweis, 3);
            this.TBHinweis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBHinweis.Location = new System.Drawing.Point(123, 107);
            this.TBHinweis.Name = "TBHinweis";
            this.TBHinweis.Size = new System.Drawing.Size(222, 20);
            this.TBHinweis.TabIndex = 4;
            this.TBHinweis.Text = "???";
            this.TBHinweis.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TBHinweis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            // 
            // label11
            // 
            this.label11.AutoEllipsis = true;
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "Letzte Änderung:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tooltip.SetToolTip(this.label11, "Gibt an, wann die Vokabel das letzte Mal geändert wurde.");
            // 
            // LblÄnderung
            // 
            this.LblÄnderung.AutoEllipsis = true;
            this.LblÄnderung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblÄnderung.Location = new System.Drawing.Point(123, 130);
            this.LblÄnderung.Name = "LblÄnderung";
            this.LblÄnderung.Size = new System.Drawing.Size(77, 23);
            this.LblÄnderung.TabIndex = 16;
            this.LblÄnderung.Text = "???";
            this.LblÄnderung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(206, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 23);
            this.label13.TabIndex = 17;
            this.label13.Text = "Erstellung:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tooltip.SetToolTip(this.label13, "Gibt an, wann die Vokabel erstellt wurde.");
            // 
            // LblErstellung
            // 
            this.LblErstellung.AutoEllipsis = true;
            this.LblErstellung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblErstellung.Location = new System.Drawing.Point(268, 130);
            this.LblErstellung.Name = "LblErstellung";
            this.LblErstellung.Size = new System.Drawing.Size(77, 23);
            this.LblErstellung.TabIndex = 18;
            this.LblErstellung.Text = "???";
            this.LblErstellung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBDeutsch
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TBDeutsch, 3);
            this.TBDeutsch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBDeutsch.Location = new System.Drawing.Point(123, 29);
            this.TBDeutsch.Name = "TBDeutsch";
            this.TBDeutsch.Size = new System.Drawing.Size(222, 20);
            this.TBDeutsch.TabIndex = 1;
            this.TBDeutsch.Text = "???";
            this.TBDeutsch.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TBDeutsch.Enter += new System.EventHandler(this.TBText_Enter);
            this.TBDeutsch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            this.TBDeutsch.Leave += new System.EventHandler(this.TBText_Leave);
            // 
            // TBFremdsprache
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TBFremdsprache, 3);
            this.TBFremdsprache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBFremdsprache.Location = new System.Drawing.Point(123, 3);
            this.TBFremdsprache.Name = "TBFremdsprache";
            this.TBFremdsprache.Size = new System.Drawing.Size(222, 20);
            this.TBFremdsprache.TabIndex = 0;
            this.TBFremdsprache.Text = "???";
            this.TBFremdsprache.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TBFremdsprache.Enter += new System.EventHandler(this.TBText_Enter);
            this.TBFremdsprache.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            this.TBFremdsprache.Leave += new System.EventHandler(this.TBText_Leave);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fremdsprache";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deutsch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBHinweisD
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TBHinweisD, 3);
            this.TBHinweisD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBHinweisD.Location = new System.Drawing.Point(123, 81);
            this.TBHinweisD.Name = "TBHinweisD";
            this.TBHinweisD.Size = new System.Drawing.Size(222, 20);
            this.TBHinweisD.TabIndex = 3;
            this.TBHinweisD.Text = "???";
            this.TBHinweisD.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TBHinweisD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            // 
            // TBHinweisF
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TBHinweisF, 3);
            this.TBHinweisF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBHinweisF.Location = new System.Drawing.Point(123, 55);
            this.TBHinweisF.Name = "TBHinweisF";
            this.TBHinweisF.Size = new System.Drawing.Size(222, 20);
            this.TBHinweisF.TabIndex = 2;
            this.TBHinweisF.Text = "???";
            this.TBHinweisF.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TBHinweisF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hinweis Fremdsprache";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tooltip.SetToolTip(this.label4, "Wird angezeigt, wenn die Fremdsprache vorgegeben ist.");
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hinweis Deutsch";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tooltip.SetToolTip(this.label3, "Wird angezeigt, wenn die eigene Sprache vorgegeben ist.");
            // 
            // BtnNew
            // 
            this.BtnNew.BackgroundImage = global::PhillipKuhrt.VoTra.Properties.Resources.edit_add_256x256_32;
            this.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNew.Location = new System.Drawing.Point(235, 3);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(110, 42);
            this.BtnNew.TabIndex = 4;
            this.Tooltip.SetToolTip(this.BtnNew, "Vokabel speichern und neue Vokabel anlegen");
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackgroundImage = global::PhillipKuhrt.VoTra.Properties.Resources._1leftarrow_256x256_32;
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBack.Location = new System.Drawing.Point(3, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(110, 42);
            this.BtnBack.TabIndex = 0;
            this.Tooltip.SetToolTip(this.BtnBack, "Vokabel speichern und vorherige Vokabel aufrufen");
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.BackgroundImage = global::PhillipKuhrt.VoTra.Properties.Resources._1rightarrow_256x256_32;
            this.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNext.Location = new System.Drawing.Point(119, 3);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(110, 42);
            this.BtnNext.TabIndex = 1;
            this.Tooltip.SetToolTip(this.BtnNext, "Vokabel speichern und nächste Vokabel aufrufen");
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.BtnNew, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnNext, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnBack, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 153);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(348, 48);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 357);
            this.label6.TabIndex = 2;
            this.label6.Text = resources.GetString("label6.Text");
            this.label6.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(0, 201);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 156);
            this.listBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(348, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 357);
            this.button1.TabIndex = 4;
            this.button1.Text = "<<<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WordSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 357);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(672, 320);
            this.Name = "WordSettingsDialog";
            this.ShowInTaskbar = false;
            this.Text = "Vokabeleigenschaften";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.WordSettingsDialog_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WordSettings_FormClosing);
            this.Load += new System.EventHandler(this.WordSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.ToolTip Tooltip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBDeutsch;
        private System.Windows.Forms.TextBox TBHinweisD;
        private System.Windows.Forms.TextBox TBFremdsprache;
        private System.Windows.Forms.TextBox TBHinweisF;
        private System.Windows.Forms.TextBox TBHinweis;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblÄnderung;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LblErstellung;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}