using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beden_Kitle_indeksi_örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kilonuzu giriniz:");
            int kilo= int.Parse(Console.ReadLine());
            Console.WriteLine("boyunuzu giriniz");
            float boy= float.Parse(Console.ReadLine());
            float bke = kilo / (boy * boy);
            if (bke <= 18)
            {
                Console.WriteLine("zayıf");
            }
            else if (bke > 18 && bke < 25)
            {
                Console.WriteLine("NORMAL");
            }
            else if (bke > 25)
            {
                Console.WriteLine("OBEZ");
            }
            else
            {
                Console.WriteLine("yanlıs secim");
            }
            Console.ReadLine();








        }
    }
}
