using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Linq;
using System.Drawing;

namespace PhillipKuhrt.VoTra.Data
{
	public class Folder
	{
		public Folder()
		{
		}





		private string _Title = "";
		private int _SymbolID = 0;
		private Folder _Parent = null;

		private List<Folder> _Folders = new List<Folder>();
		internal List<Word> _Words = new List<Word>();

		private string _Language = "";
		private Color? _Color = null;




		public int SymbolID
		{
			get { return _SymbolID; }
			set { _SymbolID = value; }
		}
		public string Title
		{
			get { return _Title; }
			set { _Title = value; }
		}
		/// <summary>
		/// Ruft den übergeordneten Ordner ab oder legt diesen fest.
		/// ArgumentException wird ausgelöst, wenn der Ordner in sich selbst verschoben wird.
		/// </summary>
		public Folder Parent
		{
			get
			{
				return _Parent;
			}
			set
			{
				if (Contains(value))
					throw new ArgumentException("Ordner kann nicht in sich selbst oder einen seiner Unterordner verschoben werden.");

				if (_Parent != null)
					_Parent._Folders.Remove(this);

				_Parent = value;

				if (_Parent != null)
					_Parent._Folders.Add(this);
			}
		}

		public List<Folder> Folders
		{
			get
			{
				return new List<Folder>(_Folders);
			}
		}
		public List<Word> Words
		{
			get
			{
				return new List<Word>(_Words);
			}
		}
		public List<Folder> AllFolders
		{
			get
			{
				var l = new List<Folder>(_Folders);
				foreach (var f in _Folders)
					l = new List<Folder>(l.Concat(f.AllFolders));
				return l;
			}
		}
		public List<Word> AllWords
		{
			get
			{
				var l = new List<Word>(_Words);
				foreach (var f in _Folders)
					l = new List<Word>(l.Concat(f.AllWords));
				return l;
			}
		}

		public string Language
		{
			get { return _Language; }
			set { _Language = value; }
		}
		public string LanguageRecursive
		{
			get
			{
				if (_Language == null || _Language == "")
					if (_Parent == null)
						return "";
					else
						return _Parent.LanguageRecursive;
				else
					return _Language;
			}
		}
		public Color? Color
		{
			get { return _Color; }
			set { _Color = value; }
		}
		public Color? ColorRecursive
		{
			get
			{
				if (_Color == null)
					if (_Parent == null)
						return null;
					else
						return _Parent.ColorRecursive;
				else
					return _Color;
			}
		}




		/// <summary>
		/// Überprüft, ob f2 in f1 enthalten ist.<para/>
		/// Ergebnisse:<para/>
		/// f1 == f2 -&gt; true<para/>
		/// f1 == null -&gt; false<para/>
		/// f2 == null -&gt; false
		/// </summary>
		public static bool Contains(Folder f1, Folder f2)
		{
			//Sonderfälle:
			//-Ein Order ist null -> false
			if (f1 == null || f2 == null)
				return false;
			//-Beide Ordner sind Gleich -> true
			if (f1 == f2)
				return true;

			Folder tmp = f2;

			while (tmp._Parent != null)
			{
				//Einen Order nach oben:
				tmp = tmp._Parent;
				//Überprüfen, ob nun beim mögl. enthaltenden O. angekommen
				if (tmp == f1)
					return true;
			}
			return false;

			#region //Suche
			//if (f == null)
			//    return false;
			//if (_Folders.Contains(f))
			//    return true;
			//foreach (Folder f1 in _Folders)
			//    if (f1.Contains(f))
			//        return true;
			//return false;
			#endregion
		}

		/// <summary>
		/// Überprüft, ob f in diesem Ordner enthalten ist.<para/>
		/// Ergebnisse:<para/>
		/// f == this -&gt; true<para/>
		/// f == null -&gt; false
		/// </summary>
		public bool Contains(Folder f)
		{
			return Contains(this, f);
		}

		/// <summary>
		/// Überprüft, ob w in f enthalten ist.
		/// </summary>
		public static bool Contains(Folder f, Word w)
		{
			if (f == null || w == null)
				return false;
			if (w.Parent == null)
				return false;
			return Contains(f, w.Parent);
		}

		/// <summary>
		/// Überprüft, ob w in diesem Ordner enthalten ist.<para/>
		/// Ergebnisse:<para/>
		/// w == null -&gt; false
		/// </summary>
		public bool Contains(Word w)
		{
			return Contains(this, w);
		}



		public override string ToString()
		{
			return Title + " (" + SymbolID.ToString() + "; " + Language + "): " + _Folders.Count + "/" + _Words.Count;
		}

		/// <summary>
		/// Kopiert den Ordner
		/// </summary>
		/// <param name="cloneResults">Gibt an, ob die Ergebnisse der Wörter mitkopiert werden sollen<para/>Werden die Ergebnisse mitkopiert, wird auch das Änderungs- und Erstellungsdatum übernommen.</param>
		public Folder Clone(bool cloneResults)
		{
			Folder f = new Folder();

			f._Title = _Title;
			f._SymbolID = _SymbolID;
			f._Language = _Language;
			f._Color = _Color;

			foreach (Folder f1 in _Folders)
				f1.Clone(cloneResults).Parent = f;
			foreach (Word w1 in _Words)
				w1.Clone(cloneResults).Parent = f;

			return f;
		}

		public int CountResults(User u)
		{
			int res = 0;
			foreach (Word w in _Words)
				res += w.CountResults(u);
			foreach (Folder f in _Folders)
				res += f.CountResults(u);
			return res;
		}

		public int CountWords(bool subfolders)
		{
			return (subfolders ? _Folders.Sum((f) => { return f.CountWords(true); }) : 0) + _Words.Count;
		}

		public void ResetResults(User u)
		{
			foreach (Word w in _Words)
				w.ResetResults(u);
		}

		public double GetState(User u, bool subfolders)
		{
			return (subfolders ? _Folders.Sum((f) =>
			{
				return f.GetState(u, true) * f.CountWords(true);
			})
			: 0) + CountWords(subfolders);
		}

	}
}
