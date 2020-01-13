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

namespace HtmlElement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string tt = "tttt";
            tt = "oooo";
            tt = "33";
            string agreement = System.Environment.CurrentDirectory + @"\html";
            string com = Path.Combine(agreement, "PickAgreementContent.html");
            webBrowser1.Navigate(com);
        }
       
    }
}
