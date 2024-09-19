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

    public class Customer : User
    {
        public Customer(string nama, double emoney) : base(nama, "Customer", emoney) { }

        public void LihatSaldo()
        {
            Console.WriteLine($"Saldo {Nama}: {Emoney}");
        }
    }

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
            Boolean loop = true;

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