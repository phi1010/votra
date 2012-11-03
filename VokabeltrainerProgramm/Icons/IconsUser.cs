using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PhillipKuhrt.VoTra.Icons
{
    public class IconsUser
    {
        Dictionary<int, Image> Icons = new Dictionary<int, Image>();

        public IconsUser()
        {
            try
            {

                foreach (string s in Directory.GetFiles(Application.StartupPath + @"\Icons\User"))
                    try
                    {
                        int i = Convert.ToInt32(Path.GetFileNameWithoutExtension(s));
                        Icons.Add(i, Image.FromFile(s));
                    }
                    catch { }
            }
            catch
            {
                MessageBox.Show("Fehler beim Laden der Benutzersymbole", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
