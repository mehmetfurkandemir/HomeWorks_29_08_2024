using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        #region Split method
        //1. Kullanıcıdan alınan bir cümledeki kelime sayısını bulan bir program yazın. (Split metodunu araştırınız.)
            //Console.Write("Bir cümle giriniz: ");
            //string cumle = Console.ReadLine();
            //string[] stringArr = cumle.Split(" ");
            //Console.Write($"girmiş olduğunuz cümlede {stringArr.length} adet kelime bulunmaktadır.")
        #endregion
        #region Büyük harf Küçük harf
            //2. Kullanıcıdan alınan bir metni tüm harfleri büyük olacak şekilde ve tüm harfleri küçük olacak şekilde alt alta tek bir Console.Write ile ekrana yazdıran bir program yazın.

            //Console.Write("Cümleniz: ");
            //string cumle = Console.ReadLine();

            //string buyukHarfCumle = cumle.ToUpper();
            //string kucukHarfCumle = cumle.ToLower();
            //Console.WriteLine(buyukHarfCumle + "\n" + kucukHarfCumle); // "\n" methodu ile alt alta yazdırdım.

        #endregion    
        #region split kaç kez kelime geçti
            //3. Kullanıcıdan alınan bir cümlede belirli bir kelimenin kaç kez geçtiğini bulan bir program yazın. (Split metodunu araştırınız.)
            
            /* Console.WriteLine("Cümle giriniz: ");
            string cumle = Console.ReadLine();
            Console.WriteLine("Aranacak kelime giriniz: ");
            string aranacakKelime = Console.ReadLine();
            string[] stringArr = cumle.Split(" ");
            int sayac = 0;
            for (int i = 0; i < stringArr.Length; i++)
            {
                if(stringArr[i]==aranacakKelime){
                    sayac++;
                }
            }

            Console.WriteLine($"Aramış olduğunuz kelime cümlede {sayac} kez geçmektedir."); */
            
        #endregion
        #region trim method
            //4. Kullanıcıdan alınan bir cümlenin başındaki ve sonundaki boşlukları kaldıran bir program yazın. (Trim metotlarını araştırınız.)

            //Console.Write("Cümlenizi giriniz: ");
            //string cumle = Console.ReadLine();

            //string boslukTrim = cumle.Trim();

            //Console.WriteLine(boslukTrim);
            
        #endregion
        #region Metin arama
            /* Console.Write("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            Console.Write("Aranacak kelimeyi giriniz: ");
            string aranacak = Console.ReadLine();

            cumle.IndexOf(aranacak);
            Console.WriteLine(cumle.IndexOf(aranacak)); */

        #endregion
    }
}

