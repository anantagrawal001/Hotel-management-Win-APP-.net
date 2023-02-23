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
    public partial class adminhome : Form
    {
        public adminhome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bACKTOMAINMENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAINMENU form1 = new MAINMENU();
            this.Visible = false;
            form1.Show();
        }

        private void adminhome_Load(object sender, EventArgs e)
        {

        }

        private void aDDNEWCATEOGARYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SETCATROOM sETCATROOM = new SETCATROOM();
            this.Visible = false;
            sETCATROOM.Show();
        }

        private void mODIFYROOMCATEOGARYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MODIFYROOM sETMODIFYROOM = new MODIFYROOM();
            this.Visible = false;
            sETMODIFYROOM.Show();
        }

        private void aLLOCATEROOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allocateroom allocateroom = new allocateroom();
            this.Visible = false;
            allocateroom.Show();
        }

        private void cREATENEWROOMCATEOGARYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newcat newcat = new newcat();
            this.Visible = false;  
            newcat.Show();
        }

        private void mODIFYROOMCATEOGARYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MODCAT mODCAT  =   new MODCAT();
            this.Visible = false;  
            mODCAT.Show();
        }

        private void rOOMCATEOGARYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
                                                