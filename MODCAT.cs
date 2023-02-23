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
    public partial class MODCAT : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;
        public MODCAT()
        {
            InitializeComponent();
            con = new SqlConnection(@"data source=ANANT-LEGION; initial catalog=HotelDB; Integrated security=true");
            cmd = new SqlCommand("select * from catdb", con);
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Enabled = false;
            button1.Visible = false;
            con.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                comboBox1.Items.Add(rdr.GetString(0));
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            comboBox1.Enabled = false;
            button1.Visible =true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cat = comboBox1.SelectedItem.ToString();
            con.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (cat == rdr.GetString(0)) // comparing rolln with  first column of table
                {
                    textBox2.Text = textBox3.Text = Convert.ToString(rdr.GetInt32(1));
                    textBox1.Text = comboBox1.SelectedItem.ToString();
                }
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string catO = comboBox1.SelectedItem.ToString();
            string cat = textBox1.Text;
            int fare = Convert.ToInt32(textBox2.Text);
            string query = "UPDATE catdb SET room_cat='" + cat + "',fare = " + fare + "WHERE room_cat = '"+catO+"';";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data updated");
            con.Close();
            adminhome adminhome = new adminhome();
            this.Visible = false;
            adminhome.Show();
        }

        private void bACKTOMAINMENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAINMENU mAINMENU = new MAINMENU();
            this.Visible = false;
            mAINMENU.Show();
        }

        private void aDMINHOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminhome ad = new adminhome();
            this.Visible=false;
            ad.Show();
        }
    }
}

