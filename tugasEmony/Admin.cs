using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugasEmony
{
    public class Admin : User
    {
        public Admin(string nama, string role) : base(nama, role) { }

        public void AddSaldo(double saldo, Customer customer)
        {
            customer.eMoney += saldo; // Menambah saldo
        }
    }
}
