using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Linq;

namespace PhillipKuhrt.VoTra.Data
{
    public class User
    {

        public User()
        {
            _Name = "";
            _PictureID = -1;
        }
        public User(string Name)
        {
            _Name = Name;
            _PictureID = -1;
        }
        public User(string Name, int PictureID)
        {
            _Name = Name;
            _PictureID = PictureID;
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private int _PictureID;
        public int PictureID
        {
            get { return _PictureID; }
            set { _PictureID = value; }
        }

        //public static User LoadFromXElement(XElement xelement)
        //{
        //    try
        //    {
        //        return new User((string)xelement.Element(XMLNameName), (int)xelement.Element(XMLNamePictureID));
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
        //public static XElement SaveToXElement(User user)
        //{
        //    return new XElement(XMLNameMain,
        //        new XElement(XMLNameName, user.Name),
        //        new XElement(XMLNamePictureID, user.PictureID));
        //}
        //public XElement SaveToXElement()
        //{
        //    return SaveToXElement(this);
        //}

        //public ListViewItem GetListViewItem()
        //{
        //    return new ListViewItem(_Name, Convert.ToInt32(_PictureID)) { Tag = this };
        //}

    }
}
