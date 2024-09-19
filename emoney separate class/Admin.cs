using System;

namespace Emoney
{
    public class Admin : User
    {
        public Admin(string nama, double emoney) : base(nama, "Admin", emoney) { }

        public void TambahSaldo(Customer customer, double jumlah)
        {
            if (jumlah > 0)
            {
                customer.Emoney += jumlah;
                Console.WriteLine($"Saldo {customer.Nama} berhasil ditambah {jumlah}, saldo sekarang: {customer.Emoney}");
            }
            else
            {
                Console.WriteLine("Jumlah saldo yang ditambahkan harus lebih dari 0.");
            }
        }
    }
}
