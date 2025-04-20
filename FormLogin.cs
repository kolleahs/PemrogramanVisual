using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trainticket;


namespace WinFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle the click event for label1 here
            MessageBox.Show("Login label clicked!");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Handle the click event for label2 here
            MessageBox.Show("Label2 clicked!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            Console.WriteLine($"Text changed: {textBox1.Text}");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void DaftarPenumpang_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2A7QU8GB;Initial Catalog=trainticket;TrustServerCertificate=True;Integrated Security=True;"))
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
                        trainticket.PemesananTiket tiketForm = new trainticket.PemesananTiket();
                        tiketForm.Show();

                     
                    }
                    else
                    {
                        MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
