using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrol_yapıları_örnek_soru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan 3 tane not alan ve bu notların ortalamasını bulan ve ortalaması
            // eğer 80-100 arasındaysa A+ yazdıran
            // 60-80 arasındaysa A yazdıran
            // 40-60 arasındaysa B+ yazdıran
            // 40 dan küçükse F yazdıran örneğin kod parçalarını yazınız.

            Console.WriteLine("1.nci notu giriniz:");
            float not1=float.Parse(Console.ReadLine());
            Console.WriteLine("2.nci notu giriniz:");
            float not2= float.Parse(Console.ReadLine());
            Console.WriteLine("3.ncü notu giriniz:");
            float not3=float.Parse(Console.ReadLine());

            float ortalama = (not1 + not2 + not3) / 3;

            if (ortalama > 80 && ortalama <= 100)
                Console.WriteLine("A+");
            else if (ortalama > 60 && ortalama <= 80)
                Console.WriteLine("A");
            else if (ortalama >40 &&  ortalama <=60)
                Console.WriteLine("B+");
            else if (ortalama<=40 && ortalama>=0)
                Console.WriteLine("F");
            else
                Console.WriteLine("yanlış giriş");
            Console.ReadLine();



















        }
    }
}
