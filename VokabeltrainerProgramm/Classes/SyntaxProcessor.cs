using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Collections;

namespace PhillipKuhrt.VoTra.Classes
{
    /// <summary>
    /// In der obersten Ebene können Einträge durch '#' getrennt werden:
    /// '...#...#...' als 'entweder ... oder ... oder ...'
    /// In den dadurch getrennten Einträgen:
    /// '(...;...;...)' als 'entweder ... oder ... oder ...'
    /// '(;...;...;...)' als 'optional ... oder ... oder ...'
    /// 
    /// Wortwörtlich:
    /// ';...'
    /// ';...#...#;...#..."
    /// Beginnt ein durch '#' getrennter Eintrag mit';', werden weitere '(' / ';' / ')' innerhalb dieses Eintrags nicht verarbeitet.
    /// z.B.: ';x_(1/2)=(-b+-sqrt(b^2-4ac))/(2a)'
    /// </summary>
    public static class SyntaxProcessor
    {


        public static string GetWord(string Input)
        {
            Random r = new Random();
            List<string> LS = DoSyntax(Input);
            string S = LS[r.Next(LS.Count)];
            return S;
        }
        public static bool CorrectWord(string Input, string Answer)
        {
            return DoSyntax(Input).Contains(CheckSpaces(Answer));
        }


        /// <summary>
        /// Verarbeitet einen Eingabestring
        /// </summary>
        public static List<string> DoSyntax(string Input)
        {
            System.Diagnostics.Debug.IndentLevel++;
            System.Diagnostics.Debug.WriteLine("Input: " + Input.ToString());
            List<string> temp = new List<string>();
            foreach (string s in Input.Split('#'))      //Nach # Aufteilen in oberste Einträge
                if (s.StartsWith(";"))                  //Beginnt ein Eintrag mit ;
                    temp.Add(s.Remove(0, 1));            //'Wortwörtlich', d.h. ohne Bearbeitung von ( ; ) übernehmen.
                else                                    //sonst
                    foreach (string s2 in Item(s))      //Für jedes Ergebnis der Syntax
                        temp.Add(s2);                   //Ergebnis übernehmen.
            if (temp.Count == 0)
                temp.Add("");
            System.Diagnostics.Debug.WriteLine("Output: " + temp.ToString());
            System.Diagnostics.Debug.IndentLevel--;
            temp = CheckSpaces(temp);
            temp = RemoveEmptyElements(temp);
            return temp;
        }

        /// <summary>
        /// Entfernt leere Strings aus der Liste
        /// </summary>
        private static List<string> RemoveEmptyElements(List<string> temp)
        {
            temp.RemoveAll(
                new Predicate<string>
                    (s => s == "")
                    );
            if (temp.Count == 0)
                temp.Add("");
            return temp;
        }

        /// <summary>
        /// Ersetzt doppelte Leerzeichen durch einfache und entfernt Leerzeichen am Anfang und Ende
        /// </summary>
        private static List<string> CheckSpaces(List<string> input)
        {
            List<string> output = new List<string>();
            foreach (var item in input)
            {
                output.Add(CheckSpaces(item));
            }
            return output;
        }

        /// <summary>
        /// Ersetzt doppelte Leerzeichen durch einfache und entfernt Leerzeichen am Anfang und Ende
        /// </summary>
        private static string CheckSpaces(string input)
        {
            input = input.Trim();
            while (input.Contains("  "))
            {
                int i = input.IndexOf("  ");
                input = input.Substring(0, i) + input.Substring(i + 1);
            }
            //Alternativ, testen:
            //while (input.Contains("  "))
            //{
            //	input=input.Replace("  "," ");
            //}
            return input;
        }

        /// <summary>
        /// Sucht Klammern und verarbeitet die Ergebnisse mehrerer Klammern.
        /// </summary>
        private static List<string> Item(string Input)
        {
            System.Diagnostics.Debug.IndentLevel++;
            System.Diagnostics.Debug.WriteLine("Input: " + Input.ToString());
            List<string> temp = new List<string>();
            int i = Input.IndexOf("(");
            if (i == -1)
            {
                temp.Add(Input);
            }
            else
            {
                string s1 = Input.Substring(0, i);
                string s2 = Input.Substring(i + 1);
                Tuple<string, string> s2tmp = SplitAtEqualCloseBracket(s2);
                string s21 = s2tmp.t1;
                string s22 = s2tmp.t2;
                temp.Add(s1);
                temp = Multi(temp, InsideBrackets(s21), Item(s22));

            }
            System.Diagnostics.Debug.WriteLine("Output: " + temp.ToString());
            System.Diagnostics.Debug.IndentLevel--;
            return temp;
        }

        /// <summary>
        /// Erzeugt das Kreuzprodukt mehrerer Listen
        /// </summary>
        private static List<string> Multi(params List<string>[] Input)
        {
            System.Diagnostics.Debug.IndentLevel++;
            System.Diagnostics.Debug.WriteLine("Input: " + Input.ToString());
            List<List<string>> LLS = new List<List<string>>(Input);
            if (LLS.Count < 1)
                throw new ArgumentException();
            List<string> temp = Input[0];
            LLS.RemoveAt(0);
            while (LLS.Count > 0)
            {
                temp = MultiTwo(temp, LLS[0]);
                LLS.RemoveAt(0);
            }
            System.Diagnostics.Debug.WriteLine("Output: " + temp.ToString());
            System.Diagnostics.Debug.IndentLevel--;
            return temp;
        }

        /// <summary>
        /// Erzeugt das Kreuzprodukt zweier Listen
        /// </summary>
        private static List<string> MultiTwo(List<string> LA, List<string> LB)
        {
            System.Diagnostics.Debug.IndentLevel++;
            System.Diagnostics.Debug.WriteLine("Input1: " + LA.ToString());
            System.Diagnostics.Debug.WriteLine("Input2: " + LB.ToString());
            if (LA.Count == 0 || LB.Count == 0)
                throw new ArgumentException();
            List<string> temp = new List<string>();
            foreach (string sa in LA)
                foreach (string sb in LB)
                    temp.Add(sa + sb);
            System.Diagnostics.Debug.WriteLine("Output: " + temp.ToString());
            System.Diagnostics.Debug.IndentLevel--;
            return temp;
        }

        /// <summary>
        /// Trennt den Text innerhalb von Klammern
        /// </summary>
        private static List<string> InsideBrackets(string Input)
        {
            System.Diagnostics.Debug.IndentLevel++;
            System.Diagnostics.Debug.WriteLine("Input: " + Input.ToString());
            int CurrentBracketLevel = 0;
            List<string> temp = new List<string>();
            temp.Add("");
            if (Input != null)
                while (Input.Length > 0)
                {
                    char c = Input[0];
                    if (c == ';' && CurrentBracketLevel == 0)
                        temp.Add("");
                    else
                    {
                        if (c == '(')
                            CurrentBracketLevel++;
                        else if (c == ')' && CurrentBracketLevel > 0)
                            CurrentBracketLevel--;
                        temp[temp.Count - 1] += c;
                    }
                    Input = Input.Substring(1);
                }
            List<string> temp2 = new List<string>();
            foreach (string s in temp)
                foreach (string s2 in Item(s))
                    temp2.Add(s2);
            System.Diagnostics.Debug.WriteLine("Output: " + temp.ToString());
            System.Diagnostics.Debug.IndentLevel--;
            return temp2;
        }

        /// <summary>
        /// Sucht die zugehörige schließende Klammer
        /// </summary>
        private static Tuple<string, string> SplitAtEqualCloseBracket(string Input)
        {
            System.Diagnostics.Debug.IndentLevel++;
            System.Diagnostics.Debug.WriteLine("Input: " + Input.ToString());
            Tuple<string, string> SP = new Tuple<string, string>();
            SP.t1 = "";
            SP.t2 = "";
            int CurrentBracketLevel = 0;
            while (Input.Length > 0)
            {
                if (Input[0] == ')')
                    if (CurrentBracketLevel == 0)
                    {
                        SP.t2 = Input.Substring(1);
                        break;
                    }
                    else
                        CurrentBracketLevel--;
                else if (Input[0] == '(')
                    CurrentBracketLevel++;
                SP.t1 += Input[0];
                Input = Input.Substring(1);
            }
            System.Diagnostics.Debug.WriteLine("Output: " + SP.ToString());
            System.Diagnostics.Debug.IndentLevel--;
            return SP;
        }

    }
}
