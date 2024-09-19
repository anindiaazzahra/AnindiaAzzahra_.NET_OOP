using System;

namespace Emoney
{
    public class Customer : User
    {
        public Customer(string nama, double emoney) : base(nama, "Customer", emoney) { }

        public void LihatSaldo()
        {
            Console.WriteLine($"Saldo {Nama}: {Emoney}");
        }
    }
}
