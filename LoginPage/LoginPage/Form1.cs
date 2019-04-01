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

namespace LoginPage
{
    public partial class Form1 : Form
    {
     

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            SqlConnection cn = new SqlConnection("Data Source=KHAYER_KHAN;Initial Catalog=msdb;Integrated Security=True");
                    cn.Open();
            SqlCommand cmd=new SqlCommand("select * from dbo.Login where  USERNAME = '" + textBox1.Text + "' AND PASSWORD = '" + textBox2.Text + "'",cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            int count = 0;
            while(dr.Read())
            {
                count+=2;
            }
            if(count==2)
            {
                MessageBox.Show("Ok");
                Main f2 = new Main();
                f2.Show();

            }
            else if(count>0)
            {
                MessageBox.Show("Duplicate username and password");

            }
            else
            {
                MessageBox.Show("username and password not correct");
            }
            textBox1.Clear();
            textBox2.Clear();

            }


    }
}
