using Microsoft.VisualBasic;

namespace _06_homework_for.MD;

class Program
{
    static void Main(string[] args)
    {
        #region 1 Ortalamasını Alma ??
            //??
        #endregion
        #region 2 Çarpım Tablosu (for loop ile yaptım)

            /* int girilenSayi, i, sonuc;
            Console.Write("Bir sayı giriniz: ");
            girilenSayi = int.Parse(Console.ReadLine());

            for(i=0; i<=10; i++)
            {
                sonuc = girilenSayi * i;
                Console.WriteLine("{0}x{1}={2}", girilenSayi, i, sonuc);
            } */
        
        #endregion
        #region 3 Sıralama ??
        
            //??
            
        #endregion
        #region 4 Çarpanlarını bulma
            /* Console.WriteLine("Çarpanını bulmak istediğiniz bir sayı giriniz");
            int number = 0;
            int carpan = int.Parse(Console.ReadLine());

            Console.Write("Çarpanlar: ");

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + " ");
                    carpan += i;
                }
            } */
            
        #endregion
        #region 5 Sayıyı tersine çevirme

            //https://www.yazilimkodlama.com/programlama/c-klavyeden-girilen-sayiyi-ters-cevirme/
            //while loop ile yaptım.

            /* Console.WriteLine("Terse çevirmek istediğiniz sayıyı giriniz: ");
            int sayi;
            int yazilacakRakam;
            sayi = int.Parse(Console.ReadLine());

            while (sayi > 10)
            {
                yazilacakRakam = sayi % 10;
                Console.Write(yazilacakRakam);
                sayi /= 10;
            }
            Console.WriteLine(sayi); */
            
        #endregion
        #region 6 Pozitif bölen

            /* int sayi, sayac = 0;
            Console.Write("Sayınızı giriniz: ");
            sayi = int.Parse(Console.ReadLine());
            for(int i = 1; i <= sayi; i++){
                if(sayi % i == 0){
                    Console.WriteLine(i);
                    sayac++;
                }
            }
            Console.WriteLine("Sayının bölenleri: " + sayac); */
            
        #endregion
        #region 7 Mükemmel sayı

            /* Console.Write("Sayınızı giriniz: ");
            int sayi;
            sayi = int.Parse(Console.ReadLine());
            int toplam = 0;

            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            if (toplam == sayi)
            {
                Console.WriteLine($"Girmiş olduğunuz {sayi} sayısı mükemmel sayıdır.");
            }
            else
            {
                Console.WriteLine($"Girmiş olduğunuz {sayi} sayısı mükemmel sayı değildir.");
            } */
            
        #endregion
        #region 8 Fibonacci

            /* Console.Write("Bir sayı girin: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c;

            Console.Write("Fibonacci Serisi: ");
            Console.Write($"{a} {b}");

            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write($" {c}");
                a = b;
                b = c;
            } */

        #endregion
    }
}
