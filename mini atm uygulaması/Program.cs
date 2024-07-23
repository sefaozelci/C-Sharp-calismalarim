using System;

class Program
{
    static void Main()
    {
        int bakiye = 5000;

        Console.WriteLine("Ne tür bir işlem yapmak istersiniz:");
        Console.WriteLine("1- Bakiye görüntüleme");
        Console.WriteLine("2- Para yatırma");
        Console.WriteLine("q- Çıkış yap");

        string secim = Console.ReadLine();

        if (secim == "1")
        {
            Console.WriteLine("Güncel bakiye: " + bakiye);
        }
        else if (secim == "2")
        {
            Console.WriteLine("Yatırmak istediğiniz tutarı giriniz:");
            int tutar = int.Parse(Console.ReadLine());
            bakiye += tutar; // Bakiyeye yatırılan tutarı ekleyelim
            Console.WriteLine("Kalan tutar: " + bakiye);
        }
        else if (secim.ToLower() == "q")
        {
            Console.WriteLine("ATM'den çıkış yapılıyor...");
        }
        else
        {
            Console.WriteLine("Yanlış seçim.");
        }
    }
}
