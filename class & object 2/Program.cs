using System;

namespace userTechno
{
    class User
    {
        static void Main(string[] args)
        {
            UserTechno11 userTechno11 = new UserTechno11();
            userTechno11.NamaUser = ""Pablo";

            Console.WriteLine($"Name: {userTechno11.NamaUser}");
        }
    }
    public class UserTechno11
    {
        string nama;
        string role;
        int emony;

        public string NamaUser
        {
            get;
            set;
        }
        public string RoleUser
        {
            get { return role}
            set { role = value; }
        }

    }
}