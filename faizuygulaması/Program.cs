using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Faiz Hesaplama Programına Hoş Geldiniz!");

        while (true)
        {
            // Kullanıcıdan girişleri al
            Console.Write("Ana Para: ");
            double anaPara = Convert.ToDouble(Console.ReadLine());

            Console.Write("Faiz Oranı (%): ");
            double faizOrani = Convert.ToDouble(Console.ReadLine());

            Console.Write("Gün Sayısı: ");
            int gun = Convert.ToInt32(Console.ReadLine());

            // Faiz hesaplama formülü
            double faiz = (anaPara * faizOrani * gun) / 360;

            // Sonucu ekrana yazdır
            Console.WriteLine("Hesaplanan Faiz: " + faiz.ToString("C"));

            // Devam etmek isteyip istemediğini sor
            Console.Write("Başka bir hesaplama yapmak ister misiniz? (E/H): ");
            string devam = Console.ReadLine();

            if (devam.ToUpper() != "E")
                break; // Eğer devam etmek istemiyorsa döngüden çık

            Console.Clear(); // Ekranı temizle
        }
    }
}
