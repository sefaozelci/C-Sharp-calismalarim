using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamu_ve_özel_erişim_belirleyicileri
{
    public class müşteri
    {
        public string isim;

        public string soyisim;

        public int maasdegeri;

        public string cinsiyet;
        public int yas;

        public void musteribilgilerigoster()
        {
            Console.WriteLine("ismi:"+isim);
            Console.WriteLine("soyisim:"+soyisim);
            Console.WriteLine("Maaş Değeri:"+maasdegeri);
            Console.WriteLine("Yaş Değeri"+yas);
        }

        private void isimsoyisimyazdir(string musteriisim, string musterisoyisim)
        {
            Console.WriteLine("Müşterinin İsim ve Soyisimi:"+musteriisim+" "+ musterisoyisim);

        }

    }
}
