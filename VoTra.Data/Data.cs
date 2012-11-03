using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Drawing;

namespace PhillipKuhrt.VoTra.Data
{
    public struct Data
    {
        public List<Folder> Folders;
        public List<User> Users;
    }
    public static class XMLData
    {
        public const string XML_Data = "DATA";
        /// <summary>
        /// Als Attribut, nicht als Element!
        /// </summary>
        private const string XML_Version = "Version";
        public const string CurrentVersion = "1.0.0";


        public static Data Load(XElement e)
        {
            string Version = (string)e.Attribute(XML_Version) ?? "";
            if (Version == "")
                throw new ArgumentException("Versionsangabe der Daten fehlt.");

            switch (Version)
            {
                case V_1_0_0.Version:
                    return V_1_0_0.Load(e);
                default:
                    throw new ArgumentException("Versionsangabe der Daten ist ungültig. Die Daten könnten aus einer zu alten Programmversion stammen.");
            }
        }

        public static XElement Save(Data data)
        {
            return Save(data, CurrentVersion);
        }

        public static XElement Save(Data data, string version)
        {
            switch (version)
            {
                case V_1_0_0.Version:
                    return V_1_0_0.Save(data);
                default:

                    throw new ArgumentException("Versionsangabe zum Speichern ist ungültig. Bitte andere Version verwenden. Aktuelle Version: " + CurrentVersion);
            }
        }



        private class V_1_0_0
        {
            /*
             * Anmerkungen zum Format 1.0.0
             * 
             * Die UserId kann sich bei jedem Speichern verändern, sie wird jedes Mal neu vergeben.
             * Existiert einer der Color-Werte nicht, wird die Farbe als nicht zugewiesen behandelt.
             * 
             * 
             */

            #region Konstanten
            private const string XML_Folder = "Folder";
            private const string XML_Folder_Title = "Title";
            private const string XML_Folder_SymbolID = "SymbolID";
            private const string XML_Folder_Language = "Language";
            private const string XML_Folder_Color_R = "ColorR";
            private const string XML_Folder_Color_G = "ColorG";
            private const string XML_Folder_Color_B = "ColorB";

            private const string XML_Word = "Word";
            private const string XML_Word_SymbolID = "SymbolID";
            private const string XML_Word_Text_OtherLanguage = "Text_OtherLanguage";
            private const string XML_Word_Text_German = "Text_German";
            private const string XML_Word_Info_OtherLanguage = "Info_OtherLanguage";
            private const string XML_Word_Info_German = "Info_German";
            private const string XML_Word_Info = "Info";
            private const string XML_Word_Date_Created = "Date_Created";
            private const string XML_Word_Date_Changed = "Date_Changed";

            private const string XML_Result = "Result";
            private const string XML_Result_Correct = "Correct";
            private const string XML_Result_DateTime = "DateTime";
            private const string XML_Result_UserID = "UserID";
            private const string XML_Result_Text_Assignment = "Text_Assignment";
            private const string XML_Result_Text_Answer = "Text_Answer";
            private const string XML_Result_Language_Assignment = "Language_Assignment";

            private const string XML_User = "User";
            private const string XML_User_Name = "Name";
            private const string XML_User_UserId = "UserID";
            private const string XML_User_PictureId = "SymbolID";
            #endregion


            public const string Version = "1.0.0";

            public static XElement Save(Data data)
            {
                XElement xe = new XElement(XML_Data);
                Dictionary<User, int> UserIDs = new Dictionary<User, int>();
                {
                    int CurrentID = 0;
                    foreach (User u in data.Users)
                    {
                        xe.Add(SaveUser(u, CurrentID));
                        UserIDs.Add(u, CurrentID);
                        CurrentID++;
                    }
                }
                foreach (Folder f in data.Folders)
                    xe.Add(SaveFolder(f, UserIDs));
                xe.Add(new XAttribute(XML_Version, Version));
                return xe;
            }
            private static XElement SaveUser(User u, int ID)
            {
                XElement xe = new XElement(XML_User);
                xe.Add(new XAttribute(XML_User_UserId, ID));
                xe.Add(new XAttribute(XML_User_Name, u.Name ?? ""));
                xe.Add(new XAttribute(XML_User_PictureId, u.PictureID));
                return xe;
            }
            private static XElement SaveFolder(Folder folder, Dictionary<User, int> UserIDs)
            {
                XElement xe = new XElement(XML_Folder);
                xe.Add(new XAttribute(XML_Folder_Title, folder.Title ?? ""));
                xe.Add(new XAttribute(XML_Folder_Language, folder.Language));
                xe.Add(new XAttribute(XML_Folder_SymbolID, folder.SymbolID));
                if (folder.Color != null)
                {
                    xe.Add(new XAttribute(XML_Folder_Color_R, folder.Color.Value.R));
                    xe.Add(new XAttribute(XML_Folder_Color_G, folder.Color.Value.G));
                    xe.Add(new XAttribute(XML_Folder_Color_B, folder.Color.Value.B));
                }


                foreach (Folder f in folder.Folders)
                    try
                    {
                        xe.Add(SaveFolder(f, UserIDs));
                    }
                    catch
                    {
                        try
                        {
                            string text = "MISSING FOLDER:";
                            text += f.Title.ToString() + ";";
                            text += f.SymbolID.ToString() + ";";
                            text += f.Language.ToString() + ";";
                            xe.Add(new XComment(text));
                        }
                        catch
                        { }
                    }
                foreach (Word w in folder.Words)
                    try
                    {
                        xe.Add(SaveWord(w, UserIDs));
                    }
                    catch
                    {
                        try
                        {
                            string text = "MISSING WORD:";
                            text += w.TextGerman.ToString() + ";";
                            text += w.TextOtherLanguage.ToString() + ";";
                            xe.Add(new XComment(text));
                        }
                        catch
                        { }
                    }
                return xe;
            }
            private static XElement SaveWord(Word w, Dictionary<User, int> UserIDs)
            {
                XElement xe = new XElement(XML_Word);
                xe.Add(new XAttribute(XML_Word_Date_Changed, w.DateChanged));
                xe.Add(new XAttribute(XML_Word_Date_Created, w.DateCreated));
                xe.Add(new XAttribute(XML_Word_Text_German, w.TextGerman ?? ""));
                xe.Add(new XAttribute(XML_Word_Text_OtherLanguage, w.TextOtherLanguage ?? ""));
                xe.Add(new XAttribute(XML_Word_Info, w.Info ?? ""));
                xe.Add(new XAttribute(XML_Word_Info_German, w.InfoGerman ?? ""));
                xe.Add(new XAttribute(XML_Word_Info_OtherLanguage, w.InfoOtherLanguage ?? ""));
                foreach (Result r in w.Results)
                    try
                    {
                        xe.Add(SaveResult(r, UserIDs));
                    }
                    catch
                    {
                        try
                        {
                            string text = "MISSING RESULT:";
                            text += r.DateTime.ToString() + ";";
                            text += r.Correct.ToString() + ";";
                            if (r.User != null)
                            {
                                text += r.User.Name.ToString() + ";";
                                text += r.User.PictureID.ToString() + ";";
                            }
                            xe.Add(new XComment(text));
                        }
                        catch
                        { }
                    }
                return xe;
            }
            private static XElement SaveResult(Result r, Dictionary<User, int> UserIDs)
            {
                XElement xe = new XElement(XML_Result);
                xe.Add(new XAttribute(XML_Result_Correct, r.Correct));
                xe.Add(new XAttribute(XML_Result_DateTime, r.DateTime));
                xe.Add(new XAttribute(XML_Result_Language_Assignment, r.Language_Assignment == Language.German));
                xe.Add(new XAttribute(XML_Result_Text_Answer, r.Text_Answer ?? ""));
                xe.Add(new XAttribute(XML_Result_Text_Assignment, r.Text_Assignment ?? ""));
                if (r.User != null)
                    xe.Add(new XAttribute(XML_Result_UserID, UserIDs[r.User]));

                return xe;
            }

            public static Data Load(XElement xelement)
            {
                Data d = new Data();
                d.Folders = new List<Folder>();
                d.Users = new List<User>();
                Dictionary<int, User> UserIDs = new Dictionary<int, User>();
                foreach (XElement xe in xelement.Elements(XML_User))
                    d.Users.Add(LoadUser(xe, UserIDs));
                foreach (XElement xe in xelement.Elements(XML_Folder))
                    d.Folders.Add(LoadFolder(xe, UserIDs));
                return d;
            }
            private static User LoadUser(XElement xe, Dictionary<int, User> UserIDs)
            {
                User u = new User();
                u.Name = (string)xe.Attribute(XML_User_Name) ?? "";
                u.PictureID = (int?)xe.Attribute(XML_User_PictureId) ?? 0;

                //ID herusfinden
                int? ID = (int?)xe.Attribute(XML_User_UserId);
                //Bei vorhandener ID in Dictionary eintragen
                //Falls ID fehlt, können keine Ergebnisse zugeordnet werden
                if (ID != null)
                    if (!UserIDs.ContainsKey(ID.Value))
                        UserIDs.Add(ID.Value, u);
                return u;
            }
            private static Folder LoadFolder(XElement xelement, Dictionary<int, User> UserIDs)
            {
                Folder f = new Folder();
                f.Title = (string)xelement.Attribute(XML_Folder_Title) ?? "";
                f.SymbolID = (int?)xelement.Attribute(XML_Folder_SymbolID) ?? 0;
                f.Language = (string)xelement.Attribute(XML_Folder_Language) ?? "";

                if ((xelement.Attribute(XML_Folder_Color_R) != null) && (xelement.Attribute(XML_Folder_Color_G) != null) && (xelement.Attribute(XML_Folder_Color_B) != null))
                {
                    f.Color = Color.FromArgb(
                        (int?)xelement.Attribute(XML_Folder_Color_R) ?? 0,
                        (int?)xelement.Attribute(XML_Folder_Color_G) ?? 0,
                        (int?)xelement.Attribute(XML_Folder_Color_B) ?? 0
                        );
                }
                foreach (XElement xe in xelement.Elements(XML_Folder))
                     LoadFolder(xe, UserIDs).Parent = f; 
                foreach (XElement xe in xelement.Elements(XML_Word))
                    LoadWord(xe, UserIDs).Parent = f; 
                return f;
            }
            private static Word LoadWord(XElement xe, Dictionary<int, User> UserIDs)
            {

                Word w = new Word();
                w.DateChanged = (DateTime?)xe.Attribute(XML_Word_Date_Changed) ?? DateTime.Now;
                w.DateCreated = (DateTime?)xe.Attribute(XML_Word_Date_Created) ?? DateTime.Now;
                w.Info = (string)xe.Attribute(XML_Word_Info) ?? "";
                w.InfoGerman = (string)xe.Attribute(XML_Word_Info_German) ?? "";
                w.InfoOtherLanguage = (string)xe.Attribute(XML_Word_Info_OtherLanguage) ?? "";
                w.TextGerman = (string)xe.Attribute(XML_Word_Text_German) ?? "";
                w.TextOtherLanguage = (string)xe.Attribute(XML_Word_Text_OtherLanguage) ?? "";

                foreach (XElement xee in xe.Elements(XML_Result))
                    LoadResult(xee, UserIDs).Parent = w; 
                return w;
            }
            private static Result LoadResult(XElement xe, Dictionary<int, User> UserIDs)
            {
                Result r = new Result();
                r.Correct = (bool?)xe.Attribute(XML_Result_Correct) ?? false;
                r.DateTime = (DateTime?)xe.Attribute(XML_Result_DateTime) ?? DateTime.Now;
                r.Language_Assignment = ((bool?)xe.Attribute(XML_Result_Language_Assignment) ?? false) ? Language.German : Language.OtherLanguage;
                r.Text_Answer = (string)xe.Attribute(XML_Result_Text_Answer) ?? "";
                r.Text_Assignment = (string)xe.Attribute(XML_Result_Text_Assignment) ?? "";
                int? ID = (int?)xe.Attribute(XML_Result_UserID);
                if (ID != null)
                    if (UserIDs.ContainsKey(ID.Value))
                        r.User = UserIDs[ID.Value];
                return r;

            }

        }
    }
}
