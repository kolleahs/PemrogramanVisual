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

namespace tiketkeretaapi
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Console.WriteLine($"Text changed: {textBox1.Text}");
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            Console.WriteLine($"Text changed: {textBox2.Text}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2A7QU8GB;Initial Catalog=tiketkeretaapi;TrustServerCertificate=True;Integrated Security=True;"))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM admin WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login berhasil!");
                        this.Hide(); // Sembunyikan form login
                        // Tampilkan form PemesananTiket
                        tiketkeretaapi.PemesananTiket tiketForm = new tiketkeretaapi.PemesananTiket();
                        tiketForm.Show();

                     
                    }
                    else
                    {
                        MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
