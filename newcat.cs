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
    public partial class newcat : Form
    {
        readonly SqlConnection con;
        readonly SqlCommand cmd;
        SqlDataReader rdr;
        public newcat()
        {
            InitializeComponent();
            con = new SqlConnection(@"data source=DESKTOP-3MLLO1C; initial catalog=HotelDB; Integrated security=true");
            cmd = new SqlCommand("select * from catdb", con);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cat = textBox1.Text;
            int fare = Convert.ToInt32(textBox2.Text);
            bool var = false;
            con.Open();
            string query = "select * from catdb;";
            cmd.CommandText = query;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (cat == rdr.GetString(0))
                {
                    var = true;
                    MessageBox.Show("cateogary already available");

                }
            }
            con.Close();
            if (!var)
            {
                con.Open();
                query = "insert into catdb values('" + cat + "'," + fare + ")";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("cateogary ADDED SUCCESFULLY");
                con.Close();
            }
        }

        private void bACKTOMAINMENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAINMENU mAINMENU = new MAINMENU();
            this.Visible = false;
            mAINMENU.Show();
        }

        private void aDMINHOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminhome adminhome = new adminhome();
            this.Visible = false;
            adminhome.Show();
        }
    }
}
