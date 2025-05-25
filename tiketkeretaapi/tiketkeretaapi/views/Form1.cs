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
using static tiketkeretaapi.PemesananTiketDAL;
using tiketkeretaapi.controllers;

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

            LoginController loginController = new LoginController();
            try
            {
                bool isAuthenticated = loginController.Login(username, password);
                if (isAuthenticated)
                {
                    MessageBox.Show("Login berhasil!");
                    this.Hide();
                    PemesananTiket tiketForm = new PemesananTiket();
                    tiketForm.Show();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
