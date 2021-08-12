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

namespace bamking_application
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-GHBONFT\SQLEXPRESS; Database=sbibank; Integrated Security=true;");
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel4.Visible = true;
            panel3.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            
            SqlCommand cmd = new SqlCommand("select * from ACCDETAILS where accnum='" + textBox3.Text + "' and cardnum= '" + textBox4.Text + "' and pin_num='" + textBox5.Text + "' ",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                panel5.Visible = true;
            }
            else
            {
                MessageBox.Show(" invalid account details");
            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from logincredentials where accno='" + textBox1.Text + "' and password='"+textBox2.Text+"' ",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("welcome user");
                Form2 form = new Form2(textBox1.Text);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid details");
                con.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
