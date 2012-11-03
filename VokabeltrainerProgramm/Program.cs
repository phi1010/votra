//#define TEST

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using PhillipKuhrt.VoTra.Data;
using PhillipKuhrt.VoTra.Icons;

namespace PhillipKuhrt.VoTra
{
    static class Program
    {

        private const string XMLNameRoot = "ROOT";

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

#if TEST

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PhillipKuhrt.VoTra.Forms.Syntax.DiffBoxTest());

#else
            if (args.Length > 0)
            {
                MessageBox.Show("Dieses Programm akzeptiert keine Argumente!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            #region Load
            List<Folder> Folders = null;
            List<User> Users = null;
            {
                FileInfo fi = new FileInfo(Application.StartupPath + @"\" + ApplicationInfo.File_Name_Full);
                //fi = new FileInfo(Application.CommonAppDataPath + @"\" + ApplicationData.File_Name_Full);

                if (fi.Exists)
                {
                    try
                    {
                        XDocument xd = XDocument.Load(fi.FullName);
                        XElement xRoot = xd.Element(XMLNameRoot);
                        if (xRoot == null) throw new Exception();
                        Data.Data d = Data.XMLData.Load(xRoot.Element(Data.XMLData.XML_Data));
                        Folders = d.Folders;
                        Users = d.Users;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Die Daten konnten nicht geladen werden. Das Programm wird nun geschlossen.\nDurch das Verschieben oder Umbenennen der Datei 'Vokabeln.pkvotra' wird eine neue Vokabeldatei angelegt.", "Fehler beim Laden der Daten", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (DialogResult.Yes == MessageBox.Show("Soll eine Absturzmeldung gespeichert werden? Wenn sie diese an den Entwickler senden, kann dies helfen, Programmfehler zu beheben oder Fehlermeldungen benutzerfreundlicher zu gestalten.", "Fehlermeldung speichern?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                        {
                            MessageBox.Show("Bitte senden sie die markierten Dateien an den Entwickler.", "Absturzmeldung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            try
                            {
                                string Copy = Path.GetTempFileName();
                                fi.CopyTo(Copy, true);
                                System.Diagnostics.Process.Start("explorer", "/e,/select," + Copy);
                            }
                            catch
                            {
                                MessageBox.Show("Die Kopie der Vokabeln konnte nicht erstellt oder angezeigt werden.", "Fehler beim Erstellen der Kopie der Vokabeln", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            try
                            {
                                string Copy = Path.GetTempFileName();
                                StreamWriter sw = new StreamWriter(Copy);
                                sw.WriteLine(exc.ToString());
                                sw.WriteLine();
                                sw.WriteLine(exc.GetType().ToString());
                                sw.WriteLine();
                                sw.WriteLine(exc.HelpLink.ToString());
                                sw.WriteLine();
                                sw.WriteLine(exc.InnerException.ToString());
                                sw.WriteLine();
                                sw.WriteLine(exc.Message.ToString());
                                sw.WriteLine();
                                sw.WriteLine(exc.Source.ToString());
                                sw.WriteLine();
                                sw.WriteLine(exc.StackTrace.ToString());
                                sw.WriteLine();
                                sw.WriteLine(exc.TargetSite.ToString());
                                sw.Flush();
                                sw.Close();
                                System.Diagnostics.Process.Start("explorer", "/e,/select," + Copy);
                            }
                            catch
                            {
                                MessageBox.Show("Die Absturzmeldung konnte nicht erstellt oder angezeigt werden.", "Fehler beim Erstellen der Absturzmeldung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        return;
                        //try
                        //{
                        //    string Copy = Path.GetTempFileName();
                        //    fi.CopyTo(Copy, true);
                        //    MessageBox.Show("Fehler beim Laden der Daten.\nEine Sicherheitskopie der fehlerhaften Daten wurde unter '" + Copy + "' erstellt. Es wird nun eine neue Datei erstellt, die die fehlerhafte ersetzen wird.", "Fehler beim Laden der Daten", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    System.Diagnostics.Process.Start("explorer", "/e,/select," + Copy);
                        //}
                        //catch
                        //{
                        //    MessageBox.Show("Fehler beim Laden der Daten.\nEine Sicherheitskopie der fehlerhaften Daten konnte nicht erstellt oder geöffnet werden. Das Programm wird nun beendet, um die Originaldatei zu erhalten.", "Fehler beim Laden der Daten", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    return;
                        //}
                    }
                }
                if (Folders == null || Users == null)
                {
                    Folders = new List<Folder>();
                    Users = new List<User>();
                }
            }
            IconsFolder FolderIcons;
            IconsUser UserIcons;
            try
            {
                FolderIcons = new IconsFolder();
                UserIcons = new IconsUser();
            }
            catch
            {
                MessageBox.Show("Fehler beim Laden der Symbole. Das Programm wird geschlossen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PhillipKuhrt.VoTra.Forms.Main.StartForm(FolderIcons, UserIcons, Folders, Users));

            #region Save
            {
                XDocument xDoc = null;
                try
                {
                    XElement xeRoot = new XElement(XMLNameRoot);
                    xeRoot.Add(Data.XMLData.Save(new Data.Data() { Folders = Folders, Users = Users }));
                    xDoc = new XDocument(xeRoot);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Die Daten konnten nicht gespeichert werden.", "Fehler beim Speichern", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (DialogResult.Yes == MessageBox.Show("Soll eine Absturzmeldung gespeichert werden?\nWenn sie diese an den Entwickler senden, kann dies helfen, Programmfehler zu beheben oder Fehlermeldungen benutzerfreundlicher zu gestalten.", "Fehlermeldung speichern?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        MessageBox.Show("Bitte senden sie die markierten Dateien an den Entwickler.", "Absturzmeldung", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        try
                        {
                            string Copy = Path.GetTempFileName();
                            StreamWriter sw = new StreamWriter(Copy);
                            sw.WriteLine(exc.ToString());
                            sw.WriteLine();
                            sw.WriteLine(exc.GetType().ToString());
                            sw.WriteLine();
                            sw.WriteLine(exc.HelpLink.ToString());
                            sw.WriteLine();
                            sw.WriteLine(exc.InnerException.ToString());
                            sw.WriteLine();
                            sw.WriteLine(exc.Message.ToString());
                            sw.WriteLine();
                            sw.WriteLine(exc.Source.ToString());
                            sw.WriteLine();
                            sw.WriteLine(exc.StackTrace.ToString());
                            sw.WriteLine();
                            sw.WriteLine(exc.TargetSite.ToString());
                            sw.Flush();
                            sw.Close();
                            System.Diagnostics.Process.Start("explorer", "/e,/select," + Copy);
                        }
                        catch
                        {
                            MessageBox.Show("Die Absturzmeldung konnte nicht erstellt oder angezeigt werden.", "Fehler beim Erstellen der Absturzmeldung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }


                bool SaveSuccessful = false;
                while (!SaveSuccessful)
                {
                    try
                    {
                        //fi = new FileInfo(Application.CommonAppDataPath + @"\" + ApplicationData.File_Name_Full);
                        FileInfo fi = new FileInfo(Application.StartupPath + @"\" + ApplicationInfo.File_Name_Full);

                        xDoc.Save(fi.FullName);
                        SaveSuccessful = true;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "Fehler beim Speichern", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (DialogResult.Cancel == MessageBox.Show("Soll erneut versucht werden, die Datei zu speichern? Andernfalls können sie selbst einen Spicherort auswählen.", "Wiederholen?", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation))
                            break;
                    }
                }
                while (!SaveSuccessful)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    if (sfd.ShowDialog() == DialogResult.OK)
                        try
                        {
                            xDoc.Save(sfd.FileName);
                            SaveSuccessful = true;
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.Message, "Fehler beim Speichern", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Wollen sie die Vokabeln wirklich nicht speichern?\nKlicken sie auf 'NEIN', um die Vokabeln zu speichern.", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                            break;
                    }
                }
            }
            #endregion
#endif
        }


    }
}
