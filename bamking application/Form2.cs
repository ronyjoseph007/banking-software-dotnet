﻿using System;
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
    public partial class Form2 : Form
    {
        String accno;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GHBONFT\SQLEXPRESS;Database=sbibank;Integrated Security=true");
        public Form2(string acc)
        {
            InitializeComponent();
            accno = acc;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //confirm
        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from accdetails where accnum='" + accno + "' and pin_num='" + textBox2.Text + "'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select * from accdetails where accnum='"+accno+"'",con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    int balance = int.Parse(dr1.GetValue(3).ToString());
                    int withdraw = int.Parse(textBox1.Text);
                    int updat_bal = balance - withdraw;
                    con.Close();
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("update accdetails set balance='"+updat_bal+"' where accnum='"+accno+"'",con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("amount debited successfully");

                }

            }
        }
        //continue
        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from accdetails where accnum='"+accno+"'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int bal = int.Parse(dr.GetValue(3).ToString());
                int withdraw = int.Parse(textBox1.Text);
                if (withdraw < bal)
                {
                    panel5.Visible = true;
                }
                else
                {
                    MessageBox.Show("Insufficient Balance");
                }
                con.Close();
            }

        }
        //balance
        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from accdetails where accnum='"+accno+"'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label3.Text = dr.GetValue(3).ToString();
            }
            con.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //withdraw
        private void button2_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel4.Visible = true;
            panel3.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //deposit
        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel6.Visible = true;
        }
        //continue_deposit
        private void button9_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int a = int.Parse(textBox4.Text);
            int b = 200 * a;
            textBox7.Text = b.ToString();
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int a = int.Parse(textBox5.Text);
            int b = 500 * a;
            textBox8.Text = b.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int a = int.Parse(textBox6.Text);
            int b = 2000 * a;
            textBox9.Text = b.ToString();
        }
        //confirm_deposit
        private void button10_Click(object sender, EventArgs e)
        {
            int aa = int.Parse(textBox7.Text);
            int bb = int.Parse(textBox8.Text);
            int cc = int.Parse(textBox9.Text);
            int deposit = int.Parse(textBox3.Text);
            int dd = aa + bb + cc;
            if (dd == deposit)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from  accdetails where accnum='"+accno+"'",con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int bal = int.Parse(dr.GetValue(3).ToString());
                    int upbal = bal + deposit;
                    con.Close();
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("update accdetails set balance='"+upbal+"' where accnum='"+accno+"'",con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Amount deposited successfully");
                    con.Close();

                }
            }
            else
            {
                MessageBox.Show("Ceck the denominator");
            }
        }
    }
}
