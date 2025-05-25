using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiketkeretaapi.Models;

namespace tiketkeretaapi.controllers
{
    class LoginController
    {
        private readonly LoginRepository loginRepo;

        public LoginController()
        {
            loginRepo = new LoginRepository();
        }

        public bool Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Username dan Password tidak boleh kosong.");
            }

            return loginRepo.AuthenticateUser(username, password);
        }
    }
}
