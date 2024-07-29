using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamu_ve_özel_erişim_belirleyicileri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // public -- private -- protected -- internal 

            müşteri musteri1 = new müşteri();
            musteri1.isim = "Enes";
            musteri1.soyisim = "Bayram";
            musteri1.maasdegeri = 2500;
            musteri1.cinsiyet = "Erkek";
            musteri1.musteribilgilerigoster();
            Console.ReadLine();








        }
    }
}
