namespace _05_if_else_homework2.MD;

class Program
{
    static void Main(string[] args)
    {
        #region 1 KDV
            /* Console.WriteLine("Para değerini giriniz:");
            decimal tutar = decimal.Parse(Console.ReadLine());

            decimal kdvOran;
            decimal kdvTutar;
            decimal kdvFiyat;

            if (tutar <= 1000)
            {
                kdvOran = 0.20m;
            }
            else
            {
                kdvOran = 0.08m;
            }

            kdvTutar = tutar * kdvOran;
            kdvFiyat = tutar + kdvTutar;

            Console.WriteLine($"KDV Oranı: {kdvOran * 100}"); */

        #endregion
        #region 2 Heron formülü ?
            
        #endregion
        #region 3 Taksimetre

            /* const decimal acilisUcreti = 30m;
            const decimal kmBasinaUcret = 20m;
            const decimal minTutar = 100m;
            
            Console.Write("Gidilen mesafeyi km cinsinden giriniz: ");
            decimal mesafe = decimal.Parse(Console.ReadLine());

            decimal toplam = acilisUcreti + (mesafe * kmBasinaUcret);
            
            if (toplam < minTutar)
            {
                toplam = minTutar;
            }

            Console.WriteLine($"Ödeme: {toplam} TL"); */

        #endregion
        #region 4 Daire hesap

/*         Console.Write("Yarıçap değerini giriniz: ");
        int yaricap = int.Parse(Console.ReadLine());

        //Alan için

        Console.WriteLine($"Alan: {yaricap * yaricap * 3,14}");

        //Çevre için

        Console.WriteLine($"Çevre: {2 * yaricap * 3,14}"); */

            
        #endregion
        #region 5 Vücut Kitle indeksi

        /* Console.Write("Kilonuzu giriniz: ");
        int kilo = int.Parse(Console.ReadLine());
        Console.Write("Boyunuzu giriniz: ");
        int boy = int.Parse(Console.ReadLine());

        Console.WriteLine($"Kitle Endeksiniz: {kilo / boy * boy}"); */
            
        #endregion
        #region 6 Manav

        /* double armutFiyat = 45.50;
        double bamyaFiyat = 81.40;
        double domatesFiyat = 45.00;
        double muzFiyat = 65.00;
        double patlicanFiyat = 45.00;

        Console.Write("Armut: ");
        double armutKg = Convert.ToDouble(Console.ReadLine());
        Console.Write("Bamya: ");
        double bamyaKg = Convert.ToDouble(Console.ReadLine());
        Console.Write("Domates: ");
        double domatesKg = Convert.ToDouble(Console.ReadLine());
        Console.Write("Muz: ");
        double muzKg = Convert.ToDouble(Console.ReadLine());
        Console.Write("Patlıcan: ");
        double patlicanKg = Convert.ToDouble(Console.ReadLine());

        double toplam = armutFiyat + armutKg + bamyaFiyat + bamyaKg + domatesFiyat + domatesKg + muzFiyat + muzKg + patlicanFiyat + patlicanKg;

        Console.WriteLine($"Toplam tutar: {toplam} TL"); */


        #endregion
        #region 7 Switch Case Hesap makinesi

       /*  double sayi1,sayi2, sonuc = 0;
        char islem;
        Console.Write("1. Sayıyı Giriniz: ");
        sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("2. Sayıyı Giriniz: ");
        sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("İşleminizi Seçin: \n + \n - \n * \n /");

        islem = Convert.ToChar(Console.ReadLine());

        switch(islem)
        {
            case '+':
                sonuc = sayi1 + sayi2;
                Console.WriteLine("Sonuç = " + sonuc);
                break;
            case '-':
                sonuc = sayi1 - sayi2;
                Console.WriteLine("Sonuç = " + sonuc);
                break;
            case '*':
                sonuc = sayi1 * sayi2;
                Console.WriteLine("Sonuç = " + sonuc);
                break;
            case '/':
                sonuc = sayi1 / sayi2;
                Console.WriteLine("Sonuç = " + sonuc);
                break;
            default:
            Console.WriteLine("Hatalı işlem!");
            break;
        } */
        
        

            
        #endregion
        #region 8 Çin Zodyağı

            /* Console.WriteLine("Doğum yılınızı giriniz: ");
            int dogum = int.Parse(Console.ReadLine());

            if (dogum % 12 == 0){
                Console.WriteLine("Çin Zodyağınız: Maymun");
            }
            else if (dogum % 12 == 1){
                Console.WriteLine("Çin Zodyağınız: Horoz");
            }
            else if (dogum % 12 == 2){
                Console.WriteLine("Çin Zodyağınız: Köpek");
            }
            else if (dogum % 12 == 3){
                Console.WriteLine("Çin Zodyağınız: Domuz");
            }
            else if (dogum % 12 == 4){
                Console.WriteLine("Çin Zodyağınız: Fare");
            }
            else if (dogum % 12 == 5){
                Console.WriteLine("Çin Zodyağınız: Öküz");
            }
            else if (dogum % 12 == 6){
                Console.WriteLine("Çin Zodyağınız: Kaplan");
            }
            else if (dogum % 12 == 7){
                Console.WriteLine("Çin Zodyağınız: Tavşan");
            }
            else if (dogum % 12 == 8){
                Console.WriteLine("Çin Zodyağınız: Ejderha");
            }
            else if (dogum % 12 == 9){
                Console.WriteLine("Çin Zodyağınız: Fare");
            } */

        #endregion
        #region 9 Artık Yıl

            /* Console.Write("Yıl giriniz: ");
            int yil = int.Parse(Console.ReadLine());
            bool artikYil = (yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0);
        

            Console.WriteLine(artikYil  ? $"{yil} artık yıldır." 
                                        : $"{yil} artık yıl değildir."); */


        #endregion
    }
}
