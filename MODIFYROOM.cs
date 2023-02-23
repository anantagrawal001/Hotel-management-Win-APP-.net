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
    public partial class MODIFYROOM : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;
        public MODIFYROOM()
        {
            InitializeComponent();
            con = new SqlConnection(@"data source=ANANT-LEGION; initial catalog=HotelDB; Integrated security=true");
            cmd = new SqlCommand("select * from roomdb", con);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            for (int i = 1; i < 11; i++)
            {
                comboBox2.Items.Add((Convert.ToInt32(comboBox1.SelectedItem) * 100) + i );
            }
            con.Open();
            string query = "select * from catdb;";
            cmd.CommandText = query;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
                comboBox3.Items.Add(rdr.GetString(0));
            con.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int roomn = Convert.ToInt32(comboBox2.SelectedItem);
            string cat = comboBox3.SelectedItem.ToString();
            con.Open();
            string query = "select * from roomdb;";
            cmd.CommandText = query;
            bool var = false;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr.GetInt32(1) == roomn)
                    var = true;
            }
            con.Close();
            if (var)
            {
                con.Open();
                query = "update roomdb set room_cat = '" + cat + "' where roomno = " + roomn + ";";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("room modified");
            }
            else
                MessageBox.Show("room not found");
            con.Close();
            adminhome adminhome = new adminhome();
            this.Visible = false;
            adminhome.Show();
        }
    }
}
