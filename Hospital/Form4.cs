using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital
{
    public partial class Form4 : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        public Form4()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void GetList()
        {
             cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yarik\source\repos\Hospital\Hospital\Database1.mdf;Integrated Security=True");
            cn.Open();
            da = new SqlDataAdapter("Select *From zapis", cn);
            ds = new DataSet();
            da.Fill(ds, "zapis");
            dataGridView1.DataSource = ds.Tables["zapis"];
              cn.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "insert into zapis(Id,vrach,FIO,number_polis,data,vremya) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            cmd.ExecuteNonQuery();
            cn.Close();
            GetList();
            MessageBox.Show("Запись прошла успешно ", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "update zapis set vrach ='" + textBox2.Text + "',FIO='" + textBox3.Text + "',number_polis='" + textBox4.Text + "',data='" + textBox5.Text + "',vremya='" + textBox6.Text + "' where Id=" + textBox1.Text + "";
            cmd.ExecuteNonQuery();
            cn.Close();
            GetList();
            MessageBox.Show("Обновление прошло успешно ", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "delete from zapis where Id =" + textBox1.Text + "";
            cmd.ExecuteNonQuery();
            cn.Close();
            GetList();
            MessageBox.Show("Удаление прошло успешно ", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
