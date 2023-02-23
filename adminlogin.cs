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
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            
            InitializeComponent();
            label5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vuser = "admin", vpass = "1234";
            string user=textBox1.Text;
            string pass=textBox2.Text;
            textBox2.MaxLength = 14;
            
            if (pass == vpass && user == vuser)
            {
                adminhome form3 = new adminhome();
                this.Visible = false;
                form3.Show();
            }
            else
            {
                label5.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
        }

        private void adminlogin_Load(object sender, EventArgs e)
        {

        }

        private void uSERLOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USERLOGIN form2 = new USERLOGIN();
            this.Visible = false;
            form2.Show();
        }

        private void bACKTOMAINMENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAINMENU form1 = new MAINMENU();
            this.Visible = false;
            form1.Show();
        }
    }
}
