using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jevtana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ChromiumWebBrowser chrome;
        private void Form1_Load(object sender, EventArgs e)
        {
            /* string curDir = Directory.GetCurrentDirectory();
             Uri lnk = new Uri(String.Format("file:///{0}/www/index.html", curDir));
             webBrowser1.Navigate(lnk);
             */
            string curDir = Directory.GetCurrentDirectory();

            CefSettings settings = new CefSettings();


            Cef.AddCrossOriginWhitelistEntry("file:///{0}/www/index.html", "http", "localhost:49203", true);
            Cef.Initialize(settings);
            chrome = new ChromiumWebBrowser(String.Format("file:///{0}/www/index.html", curDir));
            chrome.BrowserSettings.FileAccessFromFileUrls = CefState.Enabled;
            chrome.BrowserSettings.UniversalAccessFromFileUrls = CefState.Enabled;
            chrome.BrowserSettings.WebSecurity = CefState.Disabled;
            chrome.BrowserSettings.Javascript = CefState.Enabled;
            this.panel1.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;

        }
    }
}
