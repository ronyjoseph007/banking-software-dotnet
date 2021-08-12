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
    public partial class Form2 : Form
    {
        String accno;
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

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel3.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
