using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloIntKaelanK
{
    public partial class frmHelloInt : Form
    {
        public frmHelloInt()
        {
            InitializeComponent();
        }

        private void FrmHelloInt_Load(object sender, EventArgs e)
        {

        }

        private void RadFrench_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to French
            this.lblGreeting.Text = "Bonjour le monde";
        }

        private void RadSpanish_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to Spanish
            this.lblGreeting.Text = "Hola Mundo";
        }

        private void RadGerman_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to German
            this.lblGreeting.Text = "Hallo Welt";
        }

        private void RadEnglish_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to English
            this.lblGreeting.Text = "Hello World";
        }
    }
}
