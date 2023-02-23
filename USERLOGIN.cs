using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotelmanagement
{
    public partial class USERLOGIN : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;
        public USERLOGIN()
        {
            InitializeComponent();
            con = new SqlConnection(@"data source=DESKTOP-3MLLO1C; initial catalog=HotelDB; Integrated security=true");
            cmd = new SqlCommand("select * from userdb", con);
            label8.Visible = false;
        }        
        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAINMENU form1 = new MAINMENU();
            this.Visible = false;
            form1.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userregister form2 = new userregister();
            this.Visible = false;
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text;
            string dob = textBox3.Text;
            string pass = textBox2.Text;
            con.Open();
            rdr = cmd.ExecuteReader();
            bool var = false;
            while (rdr.Read())
            {
                if (uname == rdr.GetString(0) && dob == rdr.GetString(1) && pass == rdr.GetString(7))
                {
                    var = true;
                    userhome userhome = new userhome();
                    this.Visible = false;
                    userhome.Show();
                }
            }
            if (!var)
            {
                label8.Visible = true;
                textBox1.Text = textBox2.Text = textBox3.Text = "";
                textBox1.Focus();
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox3.Text=monthCalendar1.SelectionRange.Start.ToString();
            monthCalendar1.Visible = false;
        }
    }
}
