using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dönüş_ile_değer_döndürme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // parametre Alan - Geriye Değer Döndüren Metot Tanımlama
            // return anahtar kelimesi 
            // metot sonu 
            
           int donendeger = toplamayap(6,7);
            Console.WriteLine(donendeger);
            string isimsoyisim = isimsoyisimdondur("sefa", "ozelci");
            Console.WriteLine(isimsoyisim);

            Console.ReadLine(); 
            









        }
        static int toplamayap(int sayi1, int sayi2)
        {
            int sonuc= sayi1 + sayi2;
            
            return sonuc;
        }
        static string isimsoyisimdondur(string isim, string soyisim)
        {
            return isim + " " + soyisim;

        }
    }
}
