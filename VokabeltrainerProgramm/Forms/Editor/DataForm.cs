using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PhillipKuhrt.VoTra.Data;
using PhillipKuhrt.VoTra.Icons;

namespace PhillipKuhrt.VoTra.Forms.Editor
{
	public partial class DataForm : Form
	{
		//TODO Benutzernamen anzeigen

		private IconsFolder FolderIcons;
		private List<Folder> Folders;
		private User CurrentUser;

		public DataForm(IconsFolder FolderIcons, List<Folder> Folders, User CurrentUser)
		{
			InitializeComponent();
			this.FolderIcons = FolderIcons;
			this.Folders = Folders;
			this.CurrentUser = CurrentUser;
			ControlFolders.Folders = Folders;
			ControlFolders.FolderIcons = FolderIcons;
			ControlWords.User = CurrentUser;
			ControlWords.Edit = true;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}




		private void folderControl1_Load(object sender, EventArgs e)
		{

		}

		private void DataForm_Click(object sender, EventArgs e)
		{
		}

		private void DataForm_MouseEnter(object sender, EventArgs e)
		{
		}

		private void toolStripProgressBar1_Click(object sender, EventArgs e)
		{
		}


		private void folderControl1_DoubleClick(object sender, EventArgs e)
		{

		}

		private void ControlFolders_SelectionChanged(object sender, EventArgs e)
		{
			ControlWords.Folder = ControlFolders.SelectedFolder;
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				button1_Click(null, null);
		}

		private void button1_Click(object sender, EventArgs e)
		{
		}



	}
}
