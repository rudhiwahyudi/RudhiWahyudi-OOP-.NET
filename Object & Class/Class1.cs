using System;

namespace EMoneyApp
{
    // Kelas User
    public class User
    {
        public string Nama { get; set; }
        public string Role { get; set; }
        protected decimal eMoney;

        public User(string nama, string role)
        {
            Nama = nama;
            Role = role;
            eMoney = 0; // Inisialisasi saldo
        }

        public decimal GetSaldo()
        {
            return eMoney;
        }
    }

    // Kelas Admin
    public class Admin : User
    {
        public Admin(string nama) : base(nama, "Admin") { }

        public void TambahSaldo(Customer customer, decimal jumlah)
        {
            if (jumlah > 0)
            {
                customer.AddSaldo(jumlah);
                Console.WriteLine($"{jumlah} ditambahkan ke saldo {customer.Nama}. Saldo sekarang: {customer.GetSaldo()}");
            }
            else
            {
                Console.WriteLine("Jumlah harus lebih besar dari 0.");
            }
        }
    }

    // Kelas Customer
    public class Customer : User
    {
        public Customer(string nama) : base(nama, "Customer") { }

        public void AddSaldo(decimal jumlah)
        {
            eMoney += jumlah; // Menambah saldo
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek Admin dan Customer
            Admin admin = new Admin("Admin1");
            Customer customer = new Customer("Customer1");

            // Menambah saldo untuk customer
            admin.TambahSaldo(customer, 1000);

            // Melihat saldo customer
            Console.WriteLine($"Saldo {customer.Nama}: {customer.GetSaldo()}");

            // Menambah saldo negatif (akan ditolak)
            admin.TambahSaldo(customer, -500);

            Console.ReadLine();
        }
    }
}