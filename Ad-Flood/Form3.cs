using System;
using System.Windows.Forms;

namespace Ad_Flood
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string URL_Web { get; set; }
        private void Form3_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(URL_Web);
            webBrowser1.ScriptErrorsSuppressed = true;


        }
        public static bool turn = false;
        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                if (webBrowser1.ReadyState == WebBrowserReadyState.Complete || webBrowser1.ReadyState == WebBrowserReadyState.Interactive)
                {
                    HtmlElementCollection html;
                    html = webBrowser1.Document.Links;
                    //html = webBrowser1.Document.GetElementsByTagName("img");
                    if (html.Count > 0)
                    {

                        //html[0].InvokeMember("Click");
                        string temp = html[0].GetAttribute("href");
                        {

                            {
                                if (turn == false)
                                {
                                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", string.Concat(temp));
                                    turn = true;
                                    //webBrowser1.Navigate(new Uri(temp));
                                    timer1.Enabled = false;
                                }
                                else
                                {
                                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", string.Concat(temp));
                                    timer1.Enabled = false;
                                    turn = false;
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
