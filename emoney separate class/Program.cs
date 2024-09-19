using System;

namespace Emoney
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customerA = new Customer("Customer A", 500);
            Customer customerB = new Customer("Customer B", 300);

            Admin admin = new Admin("Admin", 1000);

            string role = "";
            string customerName = "";
            double jumlahSaldo = 0;
            bool loop = true;

            try
            {
                while (loop)
                {
                    Console.WriteLine("Masukkan Role Anda (Admin/Customer) : ");
                    role = Console.ReadLine();
                    if (role == "Admin")
                    {
                        Console.WriteLine("Pilih Customer (A/B) : ");
                        customerName = Console.ReadLine();
                        if (customerName == "A")
                        {
                            Console.WriteLine("Masukkan jumlah saldo yang ingin ditambahkan : ");
                            jumlahSaldo = double.Parse(Console.ReadLine());
                            admin.TambahSaldo(customerA, jumlahSaldo);
                        }
                        else if (customerName == "B")
                        {
                            Console.WriteLine("Masukkan jumlah saldo yang ingin ditambahkan : ");
                            jumlahSaldo = double.Parse(Console.ReadLine());
                            admin.TambahSaldo(customerB, jumlahSaldo);
                        }
                        else
                        {
                            Console.WriteLine("Customer tidak ditemukan.");
                        }
                    }
                    else if (role == "Customer")
                    {
                        Console.WriteLine("Masukkan Nama (A/B) : ");
                        customerName = Console.ReadLine();

                        if (customerName == "A")
                        {
                            customerA.LihatSaldo();
                        }
                        else if (customerName == "B")
                        {
                            customerB.LihatSaldo();
                        }
                        else
                        {
                            Console.WriteLine("Customer tidak ditemukan.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Role tidak valid.");
                        loop = false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
