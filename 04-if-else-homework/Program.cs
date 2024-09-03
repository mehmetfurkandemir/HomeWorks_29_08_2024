namespace _04_if_else_homework;

class Program
{
    static void Main(string[] args)
    {
        #region 1 pozitif - negatif - sıfır kontrolü
            /* Console.Write("Bir sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Sayınız pozitif bir sayıdır.");
            }
            else if (number == 0)
            {
                Console.WriteLine("Sayınız sıfırdır.");
            }
            else
                Console.WriteLine("Sayınız negatif bir sayıdır"); */

        #endregion
        #region 2 üç sayı büyükten küçüğe

       /*  Console.Write("ilk sayı: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("ikinci sayı: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("üçüncü sayı: ");       
        int number3 = int.Parse(Console.ReadLine());

        if (number1 > number2 && number1 > number3)
        {
            //number1 en büyük number2 orta
            if (number2 > number3)
            {
                Console.WriteLine($"{number1} {number2} {number3}");
            } 
        }
        
        if (number2 > number1 && number2 > number3)
        {
            //number2 en büyük number3 orta
            if (number3 > number1)
            {
                Console.WriteLine($"{number2} {number3} {number1}");
            }
        }

        if (number3 > number2 && number3 > number1)
        {
            //number3 en büyük number2 orta
            if (number2 > number1)
            {
                Console.WriteLine($"{number3} {number2} {number1}" );
            }
        }

        if (number1 > number2 && number1 > number3)
        {
            //number1 en büyük number2 orta
            if (number3 > number2)
            {
                Console.WriteLine($"{number1} {number3} {number2}");
            } 
        }

        if (number2 > number1 && number2 > number3)
        {
            //number2 en büyük number3 orta
            if (number1 > number3)
            {
                Console.WriteLine($"{number2} {number1} {number3}");
            }
        }

        if (number3 > number2 && number3 > number1)
        {
            //number3 en büyük number2 orta
            if (number1 > number2)
            {
                Console.WriteLine($"{number3} {number1} {number2}" );
            }
        } */

            
        #endregion
        #region 3 sesli harf kontrolü
            /* Console.WriteLine("Yazınız: ");
            char karakter = Console.ReadLine()[0];
            
            bool sesliHarf = (karakter == 'a' || karakter == 'e' || karakter == 'ı' || karakter == 'i' || karakter == 'o' || karakter == 'ö' || karakter == 'u' || karakter == 'ü');
            if (sesliHarf)
            {
                System.Console.WriteLine($"{karakter} sesli harfir.");
            }
            else
            {
                System.Console.WriteLine($"{karakter} sessiz harftir.");
            } */

        #endregion
        #region 4 artık yıl
        /* Console.Write("Yıl giriniz: ");
            int yil = int.Parse(Console.ReadLine());
            bool artikYil = (yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0);
        

            Console.WriteLine(artikYil  ? $"{yil} artık yıldır." 
                                        : $"{yil} artık yıl değildir."); */
            
        #endregion
        #region 5 geometri üçgen
            /* Console.Write("İlk kenar uzunluğu giriniz: ");
            int aci1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci kenar uzunluğu giriniz: ");
            int aci2 = int.Parse(Console.ReadLine());
            Console.Write("Üçüncü kenar uzunluğu giriniz: ");
            int aci3 = int.Parse(Console.ReadLine());

            if (aci1 + aci2 > aci3 && aci2 + aci3 > aci1 && aci1 + aci3 > aci2)
            {
                Console.WriteLine("Bu açılar ile üçgen oluşturulabilir!");
            }
            else
            {
                Console.WriteLine("Bu açılar ile üçgen oluşturulamaz!");
            } */
        #endregion
        #region 6 harf karşılığı not
            /* Console.Write("Notunuzu giriniz: ");
            int not = int.Parse(Console.ReadLine());

            if (not >= 90 && not <= 100)
            {
                Console.WriteLine("Harf notunuz = AA'dır.");
            }
            if (not >= 85 && not <= 89)
            {
                Console.WriteLine("Harf notunuz = BA'dır.");
            }
            if (not >= 80 && not <=84)
            {
                Console.WriteLine("Harf notunuz = BB'dir.");
            }
            if (not >=70 && not <= 79)
            {
                Console.WriteLine("Harf notunuz = CB'dir.");
            }
            if (not >= 60 && not <= 69)
            {
                Console.WriteLine("Harf notunuz = CC'dir.");
            }
            if (not >= 55 && not <= 59)
            {
                Console.WriteLine("Harf notunuz = DC'dir.");
            }
            if (not >= 50 && not <= 54)
            {
                Console.WriteLine("Harf notunuz = DD'dir.");
            }
            if (not >= 40 && not <= 49)
            {
                Console.WriteLine("Harf notunuz = FD'dir.");
            }
            if (not >= 0 && not <= 39)
            {
                Console.WriteLine("Harf notunuz = FF'dir.");
            } */
        #endregion
        #region 7 en büyük sayı

       /*  Console.WriteLine("Bir sayı giriniz: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("İkinci sayıyı giriniz: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Üçüncü sayıyı giriniz: ");
        int number3 = int.Parse(Console.ReadLine());

        int enBuyuk = number1;

        if (number2 > enBuyuk)
        {
            enBuyuk = number2;
        }

        if (number3 > enBuyuk)
        {
            enBuyuk = number3;
        }

        Console.WriteLine("En büyük sayı: " + enBuyuk); */

            
        #endregion
        #region 8 3 ve 5 e tam bölünen (mod alma %)
            /* Console.WriteLine("Sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());

            if(number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Sayınız 3 ve 5'e tam bölünür.");
            }
            else
            {
                Console.WriteLine("Sayınız 3 ve 5'e tam bölünmez.");
            } */
        #endregion
        #region 9 4 işlem

        /* Console.WriteLine("ilk sayı: ");
        double sayi1 = double.Parse(Console.ReadLine());

        Console.WriteLine("ikinci sayı: ");
        double sayi2 = double.Parse(Console.ReadLine());

        Console.WriteLine("işlem girin (+,-,*,/): ");
        char islem = Console.ReadLine()[0];

        double sonuc = 0;
        bool islemGecerli = true;

        switch (islem)
        {
            case '+':
            sonuc = sayi1 + sayi2;
            break;
            case '-':
            sonuc = sayi1 - sayi2;
            break;
            case '*':
            sonuc = sayi1 * sayi2;
            break;
            case '/':
            sonuc = sayi1 / sayi2;
            break;
            default:
            System.Console.WriteLine("İşlem geçersiz");
            islemGecerli = false;
            break;

        }
 */
            
        #endregion
        #region 10 asal kontrol ?

            /* Console.WriteLine("Sayı: ");
            int asalSayi = int.Parse(Console.ReadLine());

            if (asalSayi == 0 && asalSayi == 1)
            {
                Console.WriteLine("Girmiş olduğunuz sayı asal sayıdır");
            }

            if (asalSayi < 0)
            {
                Console.WriteLine("Girmiş olduğunuz sayı asal sayı değildir");
            }


            if (asalSayi % asalSayi == 1 && asalSayi % 1 == asalSayi) */


        #endregion
    }
}
