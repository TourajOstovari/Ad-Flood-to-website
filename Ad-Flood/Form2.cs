using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ad_Flood
{
    public partial class Form2 : Form
    {
        public string Urls { get; set; }
        public Form2()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri(Urls);
            webBrowser1.Update();
        }
    }
}
