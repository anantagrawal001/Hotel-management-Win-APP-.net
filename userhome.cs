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
    public partial class userhome : Form
    {
        public userhome()
        {
            InitializeComponent();
        }

        private void bOOKAROOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookroom bookroom = new bookroom();
            this.Visible = false;
            bookroom.Show();
        }

        private void userhome_Load(object sender, EventArgs e)
        {

        }
    }
}
