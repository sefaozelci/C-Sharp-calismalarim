using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 10, 20, 30, 20, 30, 40, 50, 70, 55, 65, 5, 20, 35, 65, 80 };
            int adet = 0;

            Console.WriteLine("bir sayi giriniz:");
            int sayi= int.Parse(Console.ReadLine());

            foreach (int i in sayilar)
            {
                if (sayi == i)
                {
                    adet++;
                }
               
            }
            if (adet == 0)
            {
                Console.WriteLine("girdiginiz sayi yoktur");
                Console.ReadLine();
            }
            if (adet != 0)
            {
                Console.WriteLine(adet + " adet vardır");
                Console.ReadLine();
            }



        }
    }
}
