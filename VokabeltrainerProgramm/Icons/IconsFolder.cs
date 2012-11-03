using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PhillipKuhrt.VoTra.Icons
{
    public class IconsFolder
    {
        Dictionary<int, Image> Icons = new Dictionary<int, Image>();

        public IconsFolder()
        {
            try
            {
                Icons.Add(0, Properties.Resources.FolderClosed);
                Icons.Add(1, Properties.Resources.FolderOpen);

                foreach (string s in Directory.GetFiles(Application.StartupPath + @"\Icons\Folder"))
                    try
                    {
                        int i = Convert.ToInt32(Path.GetFileNameWithoutExtension(s));
                        Icons.Add(i, Image.FromFile(s));
                    }
                    catch { }
            }
            catch
            {
                MessageBox.Show("Fehler beim Laden der Ordnersymbole", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception();
            }
        }

        public Image GetIcon(int ID)
        {
            if (Icons.ContainsKey(ID))
                return Icons[ID];
            else
                return null;
        }

        public Image GetIcon(int ID, bool Selected)
        {
            if (Icons.ContainsKey(ID))
                if (ID == 0 || ID == 1)
                    if (Selected)
                        return Icons[1];
                    else
                        return Icons[0];
                else
                    return Icons[ID];
            else
                return null;
        }

        public List<Image> IconList
        {
            get { return Icons.Values.ToList(); }
        }

        public Dictionary<int, Image> IconDictionary
        {
            get { return new Dictionary<int, Image>(Icons); }
        }
    }
}
