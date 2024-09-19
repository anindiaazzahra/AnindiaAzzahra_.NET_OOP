using System;

namespace Emoney
{
    public class User
    {
        private string nama;
        private string role;
        private double emoney;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public double Emoney
        {
            get { return emoney; }
            set
            {
                if (value >= 0)
                {
                    emoney = value;
                }
                else
                {
                    throw new ArgumentException("Saldo tidak boleh negatif");
                }
            }
        }

        public User(string nama, string role, double emoney)
        {
            Nama = nama;
            Role = role;
            Emoney = emoney;
        }
    }
}
