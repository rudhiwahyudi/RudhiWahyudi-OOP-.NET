using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugasEmony
{
    public class Customer : User
    {
        public Customer(string nama, string role, double eMoney) : base(nama, role) { }

        public void LihatSaldo()
        {
            Console.WriteLine(eMoney);
        }
    }
}
