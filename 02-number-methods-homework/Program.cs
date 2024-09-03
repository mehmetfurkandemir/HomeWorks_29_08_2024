namespace _02_number_methods_homework;

class Program
{
    static void Main(string[] args)
    {
        #region ondalıklı yuvarlama
            //1. Kullanıcıdan alınan bir ondalıklı sayıyı en yakın tam sayıya yuvarlayan bir program yazın.

            //Console.Write("Ondalıklı sayınızı giriniz: ");
            
            //double number = double.Parse(Console.ReadLine());
            //number = Math.Round(number);

            //Console.WriteLine(number);

        #endregion
        #region hangisi daha büyük
        //2. Kullanıcıdan alınan iki sayıdan hangisinin daha büyük olduğunu bulan bir program yazın.

        //Console.Write("İlk sayınızı giriniz: ");

        //int number1 = int.Parse(Console.ReadLine());

        //Console.Write("İkinci sayınızı giriniz: ");
        //int number2 = int.Parse(Console.ReadLine());
        
        //Console.WriteLine(number1 > number2
        //        ? "Birinci sayı daha büyüktür." 
        //        : number1 < number2 
        //        ? "İkinci sayı daha büyüktür." 
        //        : "İki sayı eşittir.");

        // burak hoca
        // math.Max(number1,number2)
            
        #endregion
        #region mutlak değer
            //Console.Write("Sayınızı giriniz: ");
            //double number = double.Parse(Console.ReadLine());

            //double mutlakDeger = Math.Abs(number);

            //Console.WriteLine("Sayının mutlak değeri: " + mutlakDeger);

            
        #endregion
        #region Karekök
            //Console.Write("Sayınızı giriniz: ");
            //double number = double.Parse(Console.ReadLine());

            //double karekok = Math.Sqrt(number);

            //Console.WriteLine("Karekök: " + karekok );


            //Burak hoca
            //int number = 5;
            //Console.Write(Math.Sqrt(number));

        #endregion
        #region üs alma

        //Console.Write("Alt sayınızı giriniz: ");
        //double alt = double.Parse(Console.ReadLine());

        //Console.Write("Üst sayınızı giriniz: ");
        //double ust = double.Parse(Console.ReadLine());

        //double sayininUssu = Math.Pow(alt, ust);

        //Console.WriteLine("Sonuç: " + sayininUssu);

        //Burak Hoca
        //int number = 4;
        //Console.Write(Math.Pow(number,3));

            
        #endregion
        #region Trigonometrik sinüs
                // Math.Sin() yöntemi

                //Console.WriteLine("Bir sayı giriniz: ");
                //double aci = double.Parse(Console.ReadLine());
                
                //double sinus = Math.Sin(aci);
                //Console.WriteLine("Sonuç: " + sinus);
        #endregion
        #region Radyan cinsinden sayı

        //(Math.PI / 180); methodu
        //Console.WriteLine("Bir sayı giriniz: ");

        //double derece = double.Parse(Console.ReadLine());

        //double radyan = derece * (Math.PI / 180);

        //Console.WriteLine("Açının radyan cinsinden değeri: " + radyan);
            
        #endregion
        #region logaritma
        //Math.Log(); methodu
        //Console.WriteLine("Bir sayı giriniz:");
        //double sayi = double.Parse(Console.ReadLine());
        //double logaritma = Math.Log(sayi);
        //Console.WriteLine("Sayının logaritması: " + logaritma);

            
        #endregion
        #region küçük sayı bulma

        //Console.Write("İlk sayıyı giriniz:");
        //double sayi1 = double.Parse(Console.ReadLine());

        //Console.WriteLine("İkinci sayıyı giriniz:");
        //double sayi2 = double.Parse(Console.ReadLine());

        //double kucukSayi = Math.Min(sayi1, sayi2);
        //Console.WriteLine("Küçük olan sayı: " + kucukSayi);
            
        #endregion
        #region ondalıklı sayıyı yuvarlama

        //Console.WriteLine("Bir ondalıklı sayı giriniz:");
        //double sayi = double.Parse(Console.ReadLine());

        //Console.WriteLine("Ondalık basamak sayısını giriniz:");
        //int ondalikBasamak = int.Parse(Console.ReadLine());
        //double sonucSayi = Math.Round(sayi, ondalikBasamak);
        //Console.WriteLine($"Sonuç: {sonucSayi}");


        #endregion
    }
}
