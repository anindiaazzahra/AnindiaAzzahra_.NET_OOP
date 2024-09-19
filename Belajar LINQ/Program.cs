using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belajar_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] bootcamp =
            //{
            //    "Nama 1", "Nama 2", "Nama 3", "Nama 4"
            //};
            
            //var query = from n in bootcamp select n;

            //foreach (string peserta in query)
            //{
            //    Console.WriteLine(peserta);
                
            //}

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var query = from n in numbers where n > 5 orderby n descending select n;

            foreach (var number in query)
            {
                Console.WriteLine(number); 
            }

            randomize number tebak tebakan 1 sampe 10 dicocokin sama inputan user di dalem loop kalau bener/ numbers numbernya sama baru dia keluar dari loop
        }
    }
}
