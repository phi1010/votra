using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace PhillipKuhrt.VoTra.Data
{

	public class Word
	{


		public Word()
		{
			_DateCreated = DateTime.Now;
			_DateChanged = DateTime.Now;
			_Results = new List<Result>();
		}







		private Folder _Parent;

		private DateTime _DateChanged;
		private DateTime _DateCreated;

		private string _Text_German = "";
		private string _Text_OtherLanguage = "";
		private string _Info_German = "";
		private string _Info_OtherLanguage = "";
		private string _Info = "";

		internal List<Result> _Results;








		/// <summary>
		/// Ruft den übergeordneten Ordner ab oder legt diesen fest.
		/// </summary>
		public Folder Parent
		{
			get
			{
				return _Parent;
			}
			set
			{
				if (_Parent != null)
					_Parent._Words.Remove(this);

				_Parent = value;

				if (_Parent != null)
					_Parent._Words.Add(this);
			}
		}

		public DateTime DateChanged
		{
			get
			{
				return (_DateChanged);
			}
			set
			{
				_DateChanged = value;
			}
		}
		public DateTime DateCreated
		{
			get
			{
				return (_DateCreated);
			}
			set
			{
				_DateCreated = value;
			}
		}

		public string TextGerman
		{
			get
			{
				return (_Text_German);
			}
			set
			{
				_Text_German = value;
				_DateChanged = DateTime.Now;
			}
		}
		public string TextOtherLanguage
		{
			get
			{
				return (_Text_OtherLanguage);
			}
			set
			{
				_Text_OtherLanguage = value;
				_DateChanged = DateTime.Now;
			}
		}
		public string InfoGerman
		{
			get
			{
				return (_Info_German);
			}
			set
			{
				_Info_German = value;
				_DateChanged = DateTime.Now;
			}
		}
		public string InfoOtherLanguage
		{
			get
			{
				return (_Info_OtherLanguage);
			}
			set
			{
				_Info_OtherLanguage = value;
				_DateChanged = DateTime.Now;
			}
		}
		public string Info
		{
			get
			{
				return (_Info);
			}
			set
			{
				_Info = value;
				_DateChanged = DateTime.Now;
			}
		}

		public List<Result> Results
		{
			get
			{
				return new List<Result>(_Results);
			}
		}

		public override string ToString()
		{
			return _Text_German + " - " + _Text_OtherLanguage;
		}


		/// <summary>
		/// Gibt den aktuellen Status (1-5) des angegebenen Benutzers für das aktuelle Wort zurück
		/// </summary>
		public int GetState(User User)
		{
			List<Result> lr = GetResults(User);
			int _Status = 1;
			lr.Sort(
				(Comparison<Result>)((Result a, Result b) =>
				{
					if (a.DateTime < b.DateTime)
						return -1;
					if (a.DateTime > b.DateTime)
						return +1;
					return 0;

				})
			);
			foreach (Result r in lr)
				if (r.Correct)
				{
					if (_Status < 5)
						_Status++;
				}
				else
				{
					_Status = 1;
				}
			return _Status;
		}

		/// <summary>
		/// Gibt die Ergebnisse des angegebenen Benutzers zurück
		/// </summary>
		public List<Result> GetResults(User user)
		{
			List<Result> temp = new List<Result>();
			foreach (Result res in _Results)
				if (res.User == user)
					temp.Add(res);
			return temp;
		}

		/// <summary>
		/// Löscht die Ergebnisse aller Benutzer für dieses Wort<para/>
		/// Sollte nur zum Export der Daten verwendet werden
		/// </summary>
		public void ResetResultsAllUsers()
		{
			foreach (Result r in _Results)
				r.Parent = null;
		}

		/// <summary>
		/// Löscht die Ergebnisse des angegebenen Benutzers für dieses Wort
		/// </summary>
		public void ResetResults(User User)
		{
			foreach (Result r in GetResults(User))
				r.Parent = null;

		}

		//#region Anzeige
		//public ListViewItem GetListViewItem(string User)
		//{
		//    ListViewItem LVI = new ListViewItem(TextOwnLanguage);
		//    LVI.ImageIndex = GetState(User) - 1;
		//    LVI.SubItems.Add(new ListViewItem.ListViewSubItem().Text = TextForeignLanguage);
		//    LVI.SubItems.Add(new ListViewItem.ListViewSubItem().Text = HintOwnLanguage);
		//    LVI.SubItems.Add(new ListViewItem.ListViewSubItem().Text = HintFoeignLanguage);
		//    LVI.SubItems.Add(new ListViewItem.ListViewSubItem().Text = Hint);
		//    LVI.Tag = this;
		//    return (LVI);
		//}
		//#endregion

		//#region Save & Load

		//#region Save
		//public XElement SaveToXElement()
		//{
		//    return SaveToXElement(this);
		//}
		//public static XElement SaveToXElement(Word data)
		//{
		//    var XE = new XElement(XMLNameMain,
		//        new XAttribute(XMLNameChanging, data._Changing),
		//        new XAttribute(XMLNameCreation, data._Creation),
		//        new XAttribute(XMLNameForeignLanguage, data._TextForeignLanguage),
		//        new XAttribute(XMLNameGerman, data._TextOwnLanguage),
		//        new XAttribute(XMLNameInformation, data._Hint),
		//        new XAttribute(XMLNameInformationForeignLanguage, data._HintFoeignLanguage),
		//        new XAttribute(XMLNameInformationGerman, data._HintOwnLanguage)
		//        );
		//    foreach (Result wr in data._Results)
		//        XE.Add(wr.SaveToXElement());
		//    return XE;

		//}
		//#endregion

		//#region Load
		//public static Word LoadFromXElement(XElement data, Folder parent)
		//{
		//    try
		//    {
		//        Word w = new Word(
		//            ((string)data.Attribute(XMLNameGerman))??"",
		//            ((string)data.Attribute(XMLNameForeignLanguage)) ?? "",
		//            ((string)data.Attribute(XMLNameInformation)) ?? "",
		//            ((string)data.Attribute(XMLNameInformationGerman)) ?? "",
		//            ((string)data.Attribute(XMLNameInformationForeignLanguage)) ?? "",
		//            parent
		//            );
		//        foreach (XElement XE in data.Elements(Result.XMLNameMain))
		//        {
		//            Result.LoadFromXElement(XE, w);
		//        }
		//        return w;
		//    }
		//    catch (ApplicationExitException AEE)
		//    {
		//        throw AEE;
		//    }
		//    catch
		//    {
		//        return null;
		//    }
		//}

		//public static Word LoadFromXElement(XElement data)
		//{
		//    return LoadFromXElement(data, null);
		//}
		//#endregion

		//#endregion

		/// <summary>
		/// Kopiert das Wort
		/// </summary>
		/// <param name="cloneResults">Gibt an, ob die Ergebnisse mitkopiert werden sollen<para/>Werden die Ergebnisse mitkopiert, wird auch das Änderungs- und Erstellungsdatum übernommen.</param>
		public Word Clone(bool cloneResults)
		{
			Word w = new Word();

			w._Text_German = _Text_German;
			w._Text_OtherLanguage = _Text_OtherLanguage;
			w._Info = _Info;
			w._Info_German = _Info_German;
			w._Info_OtherLanguage = _Info_OtherLanguage;

			if (cloneResults)
			{
				w._DateCreated = _DateCreated;
				w._DateChanged = _DateChanged;
				foreach (Result wr in _Results)
					wr.Clone(w);
			}
			return w;
		}

		public int CountResults(User u)
		{
			int r = 0;
			foreach (Result res in _Results)
				if (res.User == u)
					r++;
			return r;
		}
	}
}
