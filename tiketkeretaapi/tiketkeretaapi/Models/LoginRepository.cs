using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiketkeretaapi.Models

{
    class LoginRepository
    {
        public bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (SqlConnection con = koneksi.GetConnection())
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM admin WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Untuk kebutuhan debugging atau log
                Console.WriteLine("Login error: " + ex.Message);
                return false;
            }
        }
    }
}
