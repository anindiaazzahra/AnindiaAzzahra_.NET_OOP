using System;

namespace UserManagement
{
    class User
    {
        // Atribute
        string nama = "Zahra";
        string role = "CEO";
        int emoney = 1000000000;

        // Method
        public void UserDetail()
        {
            Console.WriteLine("Ini detail usernya");
        }

        // Membuat Object 
        static void Main(string[] args)
        {
            // Class merupakan blueprint dari sebuah object
            User userBootcamp = new User();
            userBootcamp.UserDetail();
            Console.WriteLine("Nama : " + userBootcamp.nama);
            Console.WriteLine("Role : " + userBootcamp.role);
            Console.WriteLine("E-Money : " + userBootcamp.emoney);
        }
    }
}
