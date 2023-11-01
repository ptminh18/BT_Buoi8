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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public SqlConnection conn;
        string str = "Data Source = A209PC40;Initial Catalog = changcan1ainua;Integrated Security = true";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                string InsertString = "insert into Khoa values('" + textBox1.Text + "','" + textBox2.Text + "');";
                SqlCommand cmd = new SqlCommand(InsertString, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thanh Cong");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                string DeleteString = "delete Khoa where MaKhoa ='" + textBox1.Text +"'";
                SqlCommand cmd = new SqlCommand(DeleteString, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thanh Cong");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                string UpdateString = "update Khoa set MaKhoa ='" + textBox1.Text + "'where MaKhoa = '04'";
                SqlCommand cmd = new SqlCommand(UpdateString, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thanh Cong");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
