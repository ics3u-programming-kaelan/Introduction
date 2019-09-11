/*
 * Created by: Kaelan K
 * Created on: 11-09-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Name of Program
 * This program calculates the perimeter of a rectangle,
 * the area of a circle and the volume of a sphere.
 * It displays the answers in labels when the respective button is clicked
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerAreaVolKaelanK
{
    public partial class frmPerAreaVol : Form
    {
        public frmPerAreaVol()
        {
            InitializeComponent();
        }

        private void FrmPerAreaVol_Load(object sender, EventArgs e)
        {

        }


        private void BtnQPerimeter_Click(object sender, EventArgs e)
        {
            lblAPerimeter.Text = Convert.ToString(8 + 8 + 5 + 5) + " cm";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lblAArea.Text = Convert.ToString(Math.PI * Math.Pow(7,2)) + " cm²";
        }

        //
        private void BtnQVolume_Click(object sender, EventArgs e)
        {
            lblAVolume.Text = Convert.ToString((double)4 / (double)3 * Math.PI * Math.Pow(4,3)) + " cm³";
        }
    }
}
