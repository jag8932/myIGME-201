﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GifFinder
{

    /* Name: Jacob Goodwillie
     * Date: 11/4/2020
     * Description: The gif finder app finds gifs on the web based on
     * what the user searches and displays them in a cascading or tile
     * layout. */

    public partial class GifFinder : Form
    {

        SearchForm searchForm;
        public GifFinder()
        {
            InitializeComponent();
            // This code gets the javascript code which is used
            // to find the gifs.
            try
            {
                // Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident / 7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; wbx 1.0.0)
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 11001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            searchForm = new SearchForm();
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(Timer1_Tick);
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("https://people.rit.edu/dxsigm/gif-finder.html");

            this.tileToolStripMenuItem.Click += new EventHandler(TileToolStripMenuItem_Click);
            this.cascadeToolStripMenuItem.Click += new EventHandler(CascadeToolStripMenuItem_Click);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem_Click);
            this.newSearchToolStripMenuItem.Click += new EventHandler(NewSearchToolStripMenuItem_Click);
        }


        // Event handler functions which tell the program how to display
        // the images.
        private void TileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.searchForm.ShowDialog();

            if(searchForm.response == "OK")
            {
                HtmlElement htmlElement;

                htmlElement = webBrowser1.Document.GetElementById("searchterm");
                htmlElement.SetAttribute("value", searchForm.searchTerm);

                htmlElement = webBrowser1.Document.GetElementById("limit");
                htmlElement.SetAttribute("value", Convert.ToString(searchForm.maxItems)); ;

                webBrowser1.Document.InvokeScript("searchButtonClicked");

                timer1.Start();
            }
        }
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            HtmlElement htmlElement = webBrowser1.Document.GetElementById("lastelement");

            if (htmlElement != null)
            {
                HtmlElementCollection htmlElementCollection;
                htmlElementCollection = webBrowser1.Document.GetElementsByTagName("img");

                foreach(HtmlElement htmlElement1 in htmlElementCollection)
                {
                    ImageForm imageForm = new ImageForm(this, htmlElement1.GetAttribute("src"), htmlElement1.GetAttribute("title"));
                    imageForm.Show();
                }
                htmlElement.OuterHtml = "";
            }
            else
            {
                timer1.Start();
            }

            
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}