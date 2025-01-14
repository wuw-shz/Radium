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

namespace Radium
{
    public partial class Radium : Form
    {
        public Radium()
        {
            InitializeComponent();
        }

        private void Radium_Load(object sender, EventArgs e)
        {
            Editor.Navigate(new Uri(string.Format("file:///{0}/Monaco/index.html", Directory.GetCurrentDirectory())));
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
