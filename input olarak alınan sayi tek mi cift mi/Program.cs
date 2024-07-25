using System;

namespace input_olarak_alınan_sayi_tek_mi_cift_mi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanicadan alinan sayi tek mi cift mi 

            Console.WriteLine("bir sayi giriniz:");
            int sayi = int.Parse(Console.ReadLine());

            tekmi(sayi);
            Console.ReadLine();
        }

        static void tekmi(int a)
        {
            if (a % 2 != 0)
            {
                Console.WriteLine("sayi tektir");
            }
            else
            {
                Console.WriteLine("sayi ciftir");
            }
        }
    }
}
