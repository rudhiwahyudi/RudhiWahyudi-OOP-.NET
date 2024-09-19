
using System;


namespace tugasEmony
{
 
    public class main
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin("Widodo", "Admin");
            Customer Granger = new Customer("Granger", "Customer", 20000);
            Customer Yanti = new Customer("Yanti", "Customer", 1500000);

            do
            {
                Console.WriteLine("Masukan Role : ");
                string role = Console.ReadLine();

                switch (role)
                {
                    case "Admin":
                        Console.WriteLine("Pilih Granger atau Yanti");
                        string nama = Console.ReadLine();

                        if (nama == "Granger")
                        {
                            Console.WriteLine("Masukan saldo yang akan ditambah : ");
                            int saldo = Convert.ToInt32(Console.ReadLine());
                            admin.AddSaldo(saldo, Granger);
                            break;
                        }

                        else if (nama == "Yanti")
                        {
                            Console.WriteLine("Masukan saldo yang akan ditambah : ");
                            int saldo = Convert.ToInt32(Console.ReadLine());
                            admin.AddSaldo(saldo, Yanti);
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Customer tidak ditemmukan");
                            break;
                        }
                    case "Customer":
                        Console.WriteLine("Masukan nama Customer : ");
                        string customer = Console.ReadLine();
                        if (customer == "Granger")
                        {
                            Granger.LihatSaldo();
                            break;
                        }
                        else if (customer == "Yanti")
                        {
                            Yanti.LihatSaldo();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Customer tidak terdaftar");
                            break;
                        }
                    default:
                        Console.WriteLine("Role Tidak ditemukan");
                        break;
                }
                
            }
            while (true);
        }
    }

}



