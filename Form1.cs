using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWebView2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.webView.Source = new Uri(Application.StartupPath + "/index.html", System.UriKind.Absolute);
            this.Resize += new System.EventHandler(this.Form_Resize);
        }
        private void Form_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
        }
    }
}
