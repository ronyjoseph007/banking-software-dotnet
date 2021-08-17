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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data source=DESKTOP-GHBONFT\SQLEXPRESS;Database=sbibank;Integrated Security =true");
        
        public Form3(string acc)

        {
            InitializeComponent();
            label2.Text= acc;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //process
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from logincredentials where accno='"+label2.Text+"' and password='"+textBox1.Text+"'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                panel2.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid details");
            }
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //save
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update logincredentials set password='"+textBox2.Text+"' where accno='"+label2.Text+"'",con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password changed successfully");
            }
            else
            {
                MessageBox.Show("Password missmatch");
            }
        }
        //close
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(label2.Text);
            form.Show();
            this.Hide();
        }
    }
}
