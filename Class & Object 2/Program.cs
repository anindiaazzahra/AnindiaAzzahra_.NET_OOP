using System;

namespace UserBootcamp
{
    class User
    {
        static void Main(string[] args)
        {
            UserBootcamp11 _userBootcamp11 = new UserBootcamp11();
            _userBootcamp11.NamaUser = "Zahra";
            Console.WriteLine("Nama : " + _userBootcamp11.NamaUser);


        }
    }

    public class UserBootcamp11
    {
        String name;
        String role;
        String emoney;

        // public String NamaUser

        public String NamaUser
        {
            // get => name; set => name
            get { return name; }
            set { name = value; }
        }

        public String RoleUser
        {
            get { return role; }
            set { role = value; }
        }

        public String Emoney
        {
            get { return emoney; }
            set { emoney = value; }
        }
    }
}
