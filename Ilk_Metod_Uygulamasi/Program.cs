using System;

class Program
{
    static void Main()
    {
        // 1. Geriye değer döndürmeyen void metot
        SarkiyiYazdir();

        // 2. Geriye tamsayı döndüren metot
        int kalan = RastgeleSayiMod2();
        Console.WriteLine($"\nRastgele sayının 2'ye bölümünden kalan: {kalan}");

        // 3. Parametre alan ve geriye değer döndüren metot
        int carpim = CarpimHesapla(6, 7);
        Console.WriteLine($"\n6 ile 7'nin çarpımı: {carpim}");

        // 4. Parametre alan ve geriye değer döndürmeyen metot
        KullaniciKarsilama("Berk Can", "Dağdelen");
    }

    // 1. Geriye değer döndürmeyen metot
    static void SarkiyiYazdir()
    {
        Console.WriteLine("🎵 Bu akşam ölürüm beni kimse tutamaz...");
    }

    // 2. Geriye tamsayı döndüren metot
    static int RastgeleSayiMod2()
    {
        Random rnd = new Random();
        int sayi = rnd.Next(1, 101); // 1-100 arası rastgele sayı
        return sayi % 2;
    }

    // 3. Parametre alan ve geriye değer döndüren metot
    static int CarpimHesapla(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }

    // 4. Parametre alan ve geriye değer döndürmeyen metot
    static void KullaniciKarsilama(string isim, string soyisim)
    {
        Console.WriteLine($"\nHoş Geldiniz {isim} {soyisim}!");
    }
}
