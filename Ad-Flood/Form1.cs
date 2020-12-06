using System;
using System.Threading;
using System.Windows.Forms;

namespace Ad_Flood
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 1; i++)
                {
                    Form3 f3 = new Form3();
                    f3.URL_Web = textBox1.Text;
                    f3.Show();
                }

            }
            catch (Exception)
            {
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(0);
            }


        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
            button1_Click(sender, e);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        }
    }
}
