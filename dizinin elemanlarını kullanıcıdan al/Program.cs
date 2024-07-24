using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizinin_elemanlarını_kullanıcıdan_al
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[4];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("dizinin " + (i + 1) + " indeksini giriniz:");
                sayilar[i] = int.Parse(Console.ReadLine());
                


            }

            for (int i = 0;i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]+);

            }

            Console.ReadLine();











            }
    }
}
