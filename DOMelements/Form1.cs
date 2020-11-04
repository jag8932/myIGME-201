using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOMelements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.webBrowser1.Navigate("C:/github/jag8932/example.html");
            this.webBrowser1.DocumentCompleted += new
            WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);

        }
        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;
            HtmlElement htmlElement2;
            htmlElement = webBrowser1.Document.Body;
            htmlElement.Style = "font-family: Arial; color: #800000;";
            // htmlElement.Style = "color: #0000a4;";

           
            


            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h1");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerText = "My UFO Page";

            // First h2 tag
            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h2");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerText = "My UFO Info";
            // Second h2 tag
            htmlElement = htmlElementCollection[1];
            htmlElement.InnerText = "My UFO Pictures";

            foreach (HtmlElement htmlElement1 in htmlElementCollection)
            {
                htmlElement1.Style = "color: #800000;";
                if (htmlElement1 == htmlElementCollection[2])
                {
                    htmlElement1.InnerHtml = "Report your UFO sightings here: " + "<a href=\"http://www.nuforc.org\" style=color:blue;>WWW.NUFORC.ORG</a>";
                    
                    // Text shadow doesn't seem to work on window forms. I plugged it into css and it worked
                    // fine. 

                    htmlElement1.Style = "color: green; font-weight: bold; font-size: 2em; text-transform: uppercase; text-shadow: 3px 2px #A44;";
                    
                }
            }
            htmlElement2 = webBrowser.Document.CreateElement("h2");
            htmlElement2.InnerHtml = "<a href=\"http://www.nuforc.org\">NUFORC</a>";


            htmlElement = webBrowser1.Document.CreateElement("footer");
            htmlElement.InnerText = "This is my newly created footer!";
            htmlElement.SetAttribute("id", "footer");
            htmlElement.SetAttribute("class", "footerClass");
            htmlElement.SetAttribute("title", "Footer is Here");


        }

    }
}
