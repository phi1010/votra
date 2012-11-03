using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace PhillipKuhrt.VoTra.Data
{
    public class Result
    {

        public override string ToString()
        {
            return (_User + " - " + _DateTime.ToString() + " - " + _Correct.ToString());
        }

        internal Result Clone(Word Parent)
        {
            return new Result(_Correct, Parent, _User,_Language_Assignment,_Text_Assignment,_Text_Answer) { _DateTime = _DateTime };
        }

        public Result(Boolean correct, Word parent, User user,Language lang,string Assignment,string Answer)
        {
            _DateTime = DateTime.Now;
            _Correct = correct;
            _User = user;
            Parent = parent;
            Language_Assignment = lang;
            Text_Assignment = Assignment;
            _Text_Answer = Answer;
            
        }
        internal Result()
        {
            _DateTime = DateTime.Now;
            _Correct = false;
            _User = null;
            Parent = null;
            Language_Assignment = Language.German;
            Text_Assignment = "";
            _Text_Answer = "";
        }

        #region Variablen
        private DateTime _DateTime;
        private Boolean _Correct;
        private User _User;
        private Word _Parent;
        private Language _Language_Assignment;
        private string _Text_Assignment;
        private string _Text_Answer;
        #endregion

        #region Felder
        public Word Parent
        {
            get
            {
                return _Parent;
            }
            internal set
            {
                if (_Parent != null)
                    _Parent._Results.Remove(this);
                _Parent = value;
                if (_Parent != null)
                    _Parent._Results.Add(this);
            }
        }
        public User User
        {
            get
            {
                return _User;
            }
            internal set
            {
                _User = value;
            }
        }
        public DateTime DateTime
        {
            get
            {
                return (_DateTime);
            }
            internal set
            {
                _DateTime = value;
            }
        }
        public Boolean Correct
        {
            get
            {
                return (_Correct);
            }

            internal set
            {
                _Correct = value;
            }
        }
        public string Text_Assignment
        {
            get
            {
                return _Text_Assignment;
            }
            internal set
            {
                _Text_Assignment = value;
            }
        }
        public string Text_Answer
        {
            get
            {
                return _Text_Answer;
            }
            internal set
            {
                _Text_Answer = value;
            }
        }
        public Language Language_Assignment
        {
            get
            {
                return _Language_Assignment;
            }
            internal set
            {
                _Language_Assignment = value;
            }
        }
        #endregion



    }
}
