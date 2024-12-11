using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form2 : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yarik\source\repos\Hospital\Hospital\Database1.mdf;Integrated Security=True");
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpassword11.Text != string.Empty || txtpassword1.Text != string.Empty || txtusername1.Text != string.Empty)
            {
                if (txtpassword1.Text == txtpassword11.Text)
                {
                    cmd = new SqlCommand("select * from reg where Login='" + txtusername1.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Login Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        var command = new SqlCommand("INSERT INTO reg(Login,Pass) Values('" + txtusername1.Text + "','" + txtpassword1.Text + "')", cn);
                        command.ExecuteNonQuery();
                        cmd.Parameters.AddWithValue("Login", txtusername1.Text);
                        cmd.Parameters.AddWithValue("Pass", txtpassword1.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 registrati = new Form1();
            registrati.ShowDialog();
        }
    }
}
