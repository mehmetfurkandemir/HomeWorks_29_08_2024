namespace _07_switch_homework.md;

class Program
{
    static void Main(string[] args)
    {
        #region 1) haftanın günü
            /* Console.Write("Bir sayı giriniz: ");
            int sayi;
            sayi = int.Parse(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                Console.WriteLine("Lütfen 1 ile 7 arasında bir sayı giriniz!");
                break;
            } */
        #endregion
        #region 2) ay adı yazdırmak
        
        /* Console.WriteLine("Bir sayı giriniz (1-12): ");

        int ayAdi;
        ayAdi = int.Parse(Console.ReadLine());  
        switch (ayAdi)
        {
            case 1:
                Console.WriteLine("Ocak");
                break;
            case 2:
                Console.WriteLine("Şubat");
                break;
            case 3:
                Console.WriteLine("Mart");
                break;
            case 4:
                Console.WriteLine("Nisan");
                break;
            case 5:
                Console.WriteLine("Mayıs");
                break;
            case 6:
                Console.WriteLine("Haziran");
                break;
            case 7:
                Console.WriteLine("Temmuz");
                break;
            case 8:
                Console.WriteLine("Ağustos");
                break;
            case 9:
                Console.WriteLine("Eylül");
                break;
            case 10:
                Console.WriteLine("Ekim");
                break;
            case 11:
                Console.WriteLine("Kasım");
                break;
            case 12:
                Console.WriteLine("Aralık");
                break;
            default:
                Console.WriteLine("Lütfen 1 ile 12 arasında bir sayı giriniz!");
                break;
        }    */       
        #endregion
        #region 3) hesap mak.
        /* double sayi1,sayi2, sonuc = 0;
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
        #region 4) sesli sessiz harf

            /* Console.Write("Bir harf giriniz: ");
            char harf;
            harf = char.Parse(Console.ReadLine());

            switch (harf)
            {
                case 'a':
                case 'e':
                case 'ı':
                case 'i':
                case 'o':
                case 'ö':
                case 'u':
                case 'ü':
                    Console.WriteLine($"{harf} sesli bir harftir");
                break;
                default:
                    Console.WriteLine($"{harf} sessiz bir harftir.");
                break;
            } */
            
        #endregion
        #region 5) mevsim adı
        // Kullanıcıdan alınan bir sayıya göre (1-4 arası) mevsim adını yazdıran bir program yazın.
        
            /* Console.WriteLine("1 ile 4 arasında bir sayı giriniz: ");
            int sayi;
            sayi = int.Parse(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("İlkbahar");
                    break;
                case 2:
                    Console.WriteLine("Yaz");
                    break;
                case 3:
                    Console.WriteLine("Sonbahar");
                    break;
                case 4:
                    Console.WriteLine("Kış");
                    break;
                default:
                    Console.WriteLine("Lütfen 1 ile 4 arasında bir sayı giriniz.");
                    break;
            }  */
            
        #endregion
        #region 6) geçme kalma A B C D F
            //6. Kullanıcıdan alınan bir nota göre (A, B, C, D, F) geçme veya kalma durumunu belirleyen bir program yazın.
        /* Console.WriteLine();
            Console.WriteLine("Harf notunuzu giriniz (A, B, C, D, F)");
            char not;
            not = char.Parse(Console.ReadLine());

            switch (not)
            {
                case 'A':
                    Console.WriteLine("Geçtiniz!");
                    break;
                case 'B':
                    Console.WriteLine("Geçtiniz!");
                    break;
                case 'C':
                    Console.WriteLine("Geçtiniz!");
                    break;
                case 'D':
                    Console.WriteLine("Geçtiniz!");
                    break;
                case 'F':
                    Console.WriteLine("Kaldınız!");
                    break;
                default:
                    Console.WriteLine("Lütfen A ile F arasında bir harf notu giriniz!");
                    break;
            } */
        #endregion
        #region 7) Türk Para Birimi

            //Kullanıcıdan alınan bir sayıya göre (1-5 arası) Türk para biriminin adını yazdıran bir program yazın (1 Kr, 5 Kr, 10 Kr, 25 Kr, 50 Kr).

            /* Console.WriteLine("1 ile 5 arasında bir sayı giriniz: ");
            int sayi;
            sayi = int.Parse(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("1 Kr");
                    break;
                case 2:
                    Console.WriteLine("5 Kr");
                    break;
                case 3:
                    Console.WriteLine("10 Kr");
                    break;
                case 4:
                    Console.WriteLine("25 Kr");
                    break;
                case 5:
                    Console.WriteLine("50 Kr");
                    break;
                default:
                    Console.WriteLine("Lütfen 1 ile 5 arasında bir sayı giriniz!");
                    break;
            } */

        #endregion
        #region 8) Geometrik Şekil

            //Kullanıcıdan alınan bir sayıya göre (0-6 arası) bir geometrik şeklin adını yazdıran bir program yazın (0: Nokta, 1: Çizgi, 2: Açı, 3: Üçgen, 4: Kare, 5: Beşgen, 6: Altıgen).
            
            /* Console.WriteLine("Bir sayı giriniz (1-6): ");
            int sayi;
            sayi = int.Parse(Console.ReadLine());

            switch (sayi)
            {
                case 0:
                    Console.WriteLine("Nokta");
                    break;
                case 1:
                    Console.WriteLine("Çizgi");
                    break;
                case 2:
                    Console.WriteLine("Açı");
                    break;
                case 3:
                    Console.WriteLine("Üçgen");
                    break;
                case 4:
                    Console.WriteLine("Kare");
                    break;
                case 5:
                    Console.WriteLine("Beşgen");
                    break;
                case 6:
                    Console.WriteLine("Altıgen");
                    break;

                default:
                    Console.WriteLine("Lütfen 1 ile 6 arasında bir sayı giriniz!");
                    break;
            } */
        #endregion
        #region 9) Sayı Sıfatı
            // Kullanıcıdan alınan bir sayıya göre (1-5 arası) Türkçe sayı sıfatını yazdıran bir program yazın (1:

            /* Console.WriteLine("1-5 arasında bir sayı giriniz: ");
            int sayi;
            sayi = int.Parse(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Birinci");
                    break;
                case 2:
                    Console.WriteLine("İkinci");
                    break;
                case 3:
                    Console.WriteLine("Üçüncü");
                    break;
                case 4:
                    Console.WriteLine("Dördüncü");
                    break;
                case 5:
                    Console.WriteLine("Beşinci");
                    break;
                default:
                    Console.WriteLine("Lütfen 1 ile 5 arasında bir sayı giriniz!");
                    break;
            } */
            

        #endregion
        #region 10) Matematiksel İşlem

            //Kullanıcıdan alınan bir karaktere göre (+, -, *, /, %) matematiksel işlemin adını yazdıran bir program yazın

            /* Console.WriteLine("Bir karakter giriniz (+, -, *, /, %)");
            char islem;
            islem = char.Parse(Console.ReadLine());

            switch (islem)
            {
                case '+':
                    Console.WriteLine("Toplama İşlemi");
                    break;
                case '-':
                    Console.WriteLine("Çıkarma İşlemi");
                    break;
                case '*':
                    Console.WriteLine("Çarpma İşlemi");
                    break;
                case '/':
                    Console.WriteLine("Bölme İşlemi");
                    break;
                case '%':
                    Console.WriteLine("Mod İşlemi");
                    break;

                default:
                    Console.WriteLine("Lütfen geçerli bir karakter");
                    break;
            }    */    

        #endregion
    }
}
