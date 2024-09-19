using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugasEmony
{
    //class User 
    public class User
    {
        public string Nama;
        public string Role;
        public double eMoney;
        public User(string nama, string role)
        {
            Nama = nama;
            Role = role;
            eMoney = 0; // Insialisasi Saldo
        }

        public double emony()
        {
            return eMoney;
        }
    }
}
