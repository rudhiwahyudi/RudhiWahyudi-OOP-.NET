using System;


namespace Object___Class
{
    class User
    {
        //Atribute 
        string nama = "Rudhi";
        string role = "System Analyst";
        int emony = 100000000;

        //Method
        public void UserDetail()
        {
            Console.WriteLine("name" + nama + "ini detail user");
        }

        //Membuat object 
        static void Main(string[] args)
        {
            // Kelas itu merupakan blueprint dari sebuah objek 
            User usertechno = new User();
            usertechno.UserDetail();
            Console.WriteLine("nama "  + usertechno.nama);   
            Console.WriteLine("Role " + usertechno.role);
            Console.WriteLine("e-mony " + usertechno.emony);
        }
    }
}
