using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PhillipKuhrt.VoTra.Forms.Main
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            this.Text = String.Format("Info über {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
        }

        #region Assemblyattributaccessoren

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void AboutBox_Load(object sender, EventArgs e)
        {
            string text = "";
            text += "Kontakt:\r\n";
            text += "\tphkuhrt@yahoo.de\r\n";
            text += "\r\n";
            text += "Die Icons stammen von\r\n";
            text += "\tDavid Hopkins von SEM Labs unter der Creative Commons (by) Lizenz\r\n";
            text += "\t\thttp://semlabs.co.uk/journal/category/icons/\r\n";
            text += "\tDavid Vignoni unter der GNU LGPL 2.1\r\n";
            text += "\t\thttp://www.Icon-King.com/Projects/Nuvola/\r\n";
            text += "\tEveraldo Coelho and YellowIcon unter der GNU LGPL 2.1\r\n";
            text += "\t\thttp://www.Everaldo.com/crystal/\r\n";
            text += "\tIconBuffet\r\n";
            text += "\t\thttp://IconBuffet.com/\r\n";
            text += "\tWikimedia Commons unter der GNU LGPL 2.1\r\n";
            text += "\t\thttp://Commons.Wikimedia.org/\r\n";

            //Teile des Codes stammen von:
            //   -Matthias Hertel unter der Creative Commons Attribution 2.0 Germany License (http://creativecommons.org/licenses/by/2.0/de/)"



            textBoxDescription.Text = text;
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
