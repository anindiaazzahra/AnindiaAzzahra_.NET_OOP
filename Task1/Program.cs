using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int userNumber = 0;

            while (userNumber != randomNumber)
            {
                Console.WriteLine("Masukkan angka 1-10 : ");
                userNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Salah");
            }
        }
    }
}
