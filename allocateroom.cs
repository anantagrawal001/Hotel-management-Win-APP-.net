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
    public partial class allocateroom : Form
    {
        SqlDataReader rdr;
        SqlConnection con;
        SqlCommand cmd;
        public allocateroom()
        {
            InitializeComponent();
            con = new SqlConnection(@"data source=ANANT-LEGION; initial catalog=HotelDB; Integrated security=true");
            cmd = new SqlCommand("select * from roomdb", con);
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int f = Convert.ToInt32(comboBox1.SelectedItem);
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            radioButton9.Visible = true;
            radioButton10.Visible = true;
            radioButton1.Text = (f*100+1).ToString();
            radioButton2.Text = (f*100+2).ToString();
            radioButton3.Text = (f*100+3).ToString();
            radioButton4.Text = (f*100+4).ToString();
            radioButton5.Text = (f*100+5).ToString();
            radioButton6.Text = (f*100+6).ToString();
            radioButton7.Text = (f*100+7).ToString();
            radioButton8.Text = (f*100+8).ToString();
            radioButton9.Text = (f*100+9).ToString();
            radioButton10.Text = (f*100+10).ToString();
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
        int roomn = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(roomn.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                roomn = Convert.ToInt32(((RadioButton)sender).Text);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                roomn = Convert.ToInt32(((RadioButton)sender).Text);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                roomn = Convert.ToInt32(((RadioButton)sender).Text);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                roomn = Convert.ToInt32(((RadioButton)sender).Text);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                roomn = Convert.ToInt32(((RadioButton)sender).Text);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                roomn = Convert.ToInt32(((RadioButton)sender).Text);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                roomn = Convert.ToInt32(((RadioButton)sender).Text);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                roomn = Convert.ToInt32(((RadioButton)sender).Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                roomn = Convert.ToInt32(((RadioButton)sender).Text);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                roomn = Convert.ToInt32(((RadioButton)sender).Text);
        }
    }
}
