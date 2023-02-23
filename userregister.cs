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
    public partial class userregister : Form
    {
        readonly SqlConnection con;
        readonly SqlCommand cmd;
        SqlDataReader rdr;
        public userregister()
        {
            InitializeComponent();
            con = new SqlConnection(@"data source=DESKTOP-3MLLO1C; initial catalog=HotelDB; Integrated security=true");
            cmd = new SqlCommand("select * from userdb", con);
            monthCalendar1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userregister_Load(object sender, EventArgs e)
        {

        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAINMENU form1 = new MAINMENU();
            this.Visible = false;
            form1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USERLOGIN form2 = new USERLOGIN();
            this.Visible = false;
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string dob = textBox2.Text;
            string add = textBox3.Text;
            string email = textBox4.Text;
            string mob = textBox5.Text;
            string id = textBox6.Text;
            string pass = textBox7.Text;
            string idc = Convert.ToString(comboBox1.SelectedItem);
            bool var = false;
            con.Open();
            string query = "SELECT * FROM userdb;";
            cmd.CommandText = query;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (mob == rdr.GetString(2))
                {
                    var = true;
                    MessageBox.Show("User already registred !! ");              
                }
            }
            con.Close();
            if (!var)
            {
                con.Open();
                query = "insert into userdb values('" + name + "','" + dob + "','" + mob + "','" + email + "','" + add + "','" + idc + "','" + id +"','" + pass + "')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("user registred successfully");
                con.Close();
            }
            USERLOGIN form2 = new USERLOGIN();
            this.Visible = false;
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox2.Text = monthCalendar1.SelectionRange.Start.ToString();
            monthCalendar1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
