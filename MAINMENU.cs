using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelmanagement
{
    public partial class MAINMENU : Form
    {
        public MAINMENU()
        {
            InitializeComponent();
        }

        private void cHECKAVAILABLITYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDMINLOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminlogin form2 = new adminlogin();
            this.Visible = false;
            form2.Show();
        }

        private void rEGISTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userregister form4 = new userregister();
            this.Visible = false;
            form4.Show();
        }

        private void uSERLOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USERLOGIN form3 = new USERLOGIN();
            this.Visible = false;
            form3.Show();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
