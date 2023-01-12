using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitBrowser();
        }

        public ChromiumWebBrowser browser;

        public void InitBrowser()
        {
            CefSettings settingsBrowser = new CefSettings();
            settingsBrowser.Locale = "pt-br";
            Cef.Initialize(settingsBrowser);
            browser = new ChromiumWebBrowser("http://192.168.0.206:3333");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

    }
}
