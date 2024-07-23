using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Karar_Yapıları_IF__Else_Kontrol_Yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // öğrencinin notu 50 den büyükse başarılı küçükse başarısız yazdıran program çıktısını kodlayınız

            Console.WriteLine("notu giriniz:");
            float notu = float.Parse(Console.ReadLine());

            if (notu >= 50 && notu<=85)
            {
                Console.WriteLine("Başarılı");
            }
            else if (notu >= 85 && notu<=100)
            {
                Console.WriteLine("Çok Başarılı");
            }
            else if(notu <50 && notu>=0)
            {
                Console.WriteLine("başarısız");
            }
            else
            {
                Console.WriteLine("yanlış giriş");
            }
            Console.ReadLine();

                    
            












        }
    }
}
