using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruby_Hospital
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
            constomizedesing();
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {

            ////int w = Screen.PrimaryScreen.Bounds.Width;
            // int h = Screen.PrimaryScreen.Bounds.Height;
            // this.Location = new Point(0, 0);
            // this.Size = new Size(w, h);


        }
        private void constomizedesing()
            {
            panel_Regi.Visible = false;
            panel_opd.Visible = false;
            panel_IPD.Visible = false;
            }

        private void panel_Regi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
