using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Parametreli_metot_oluşturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parametre alan- geriye değer döndürmeyen metot yazma 



            toplamayap(5,7);
            isimsoyisim("sefa", " ozelci");

            carpmayap(3, 7);
            Console.ReadLine();









        }
        static void toplamayap(int sayi1, int sayi2)
        {
            Console.WriteLine("gönderilen sayilarin toplami:"+ (sayi1 + sayi2));


        }
        static void carpmayap(int sayi1,int sayi2 )
        {
            Console.WriteLine("gönderilen sayilarin carpimi:"+(sayi1*sayi2));
        }
        static void isimsoyisim(string isim, string soyisim)
        {
            Console.WriteLine("isim ve soyisim:" + isim + soyisim);
        }
    }
}
