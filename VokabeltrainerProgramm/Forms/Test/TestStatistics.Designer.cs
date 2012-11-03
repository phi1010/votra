namespace PhillipKuhrt.VoTra.Forms.Test
{
    partial class TestStatistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestStatistics));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.ImglButtons = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(77, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(240, 201);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Wort";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Anzahl Fehler";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageKey = "add_32.ico";
            this.button1.ImageList = this.ImglButtons;
            this.button1.Location = new System.Drawing.Point(0, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(512, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ImglButtons
            // 
            this.ImglButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImglButtons.ImageStream")));
            this.ImglButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.ImglButtons.Images.SetKeyName(0, "folder-closed_32.ico");
            this.ImglButtons.Images.SetKeyName(1, "folder-open_32.ico");
            this.ImglButtons.Images.SetKeyName(2, "mail_32.ico");
            this.ImglButtons.Images.SetKeyName(3, "paste_32.ico");
            this.ImglButtons.Images.SetKeyName(4, "print_32.ico");
            this.ImglButtons.Images.SetKeyName(5, "redo_32.ico");
            this.ImglButtons.Images.SetKeyName(6, "save_32.ico");
            this.ImglButtons.Images.SetKeyName(7, "trash_32.ico");
            this.ImglButtons.Images.SetKeyName(8, "undo_32.ico");
            this.ImglButtons.Images.SetKeyName(9, "add_32.ico");
            this.ImglButtons.Images.SetKeyName(10, "applications_32.ico");
            this.ImglButtons.Images.SetKeyName(11, "arrow-back_32.ico");
            this.ImglButtons.Images.SetKeyName(12, "arrow-down_32.ico");
            this.ImglButtons.Images.SetKeyName(13, "arrow-forward_32.ico");
            this.ImglButtons.Images.SetKeyName(14, "arrow-up_32.ico");
            this.ImglButtons.Images.SetKeyName(15, "computer_32.ico");
            this.ImglButtons.Images.SetKeyName(16, "copy_32.ico");
            this.ImglButtons.Images.SetKeyName(17, "cut_32.ico");
            this.ImglButtons.Images.SetKeyName(18, "delete_32.ico");
            this.ImglButtons.Images.SetKeyName(19, "disc-media_32.ico");
            this.ImglButtons.Images.SetKeyName(20, "documents_32.ico");
            this.ImglButtons.Images.SetKeyName(21, "home_32.ico");
            this.ImglButtons.Images.SetKeyName(22, "Nuvola_German_flag.png");
            this.ImglButtons.Images.SetKeyName(23, "Nuvola_Template_flag.png");
            // 
            // TestStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "TestStatistics";
            this.Text = "TestStatistics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ImglButtons;

    }
}