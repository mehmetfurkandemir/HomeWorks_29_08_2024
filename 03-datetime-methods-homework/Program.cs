namespace _03_datetime_methods_homework;

class Program
{
    static void Main(string[] args)
    {
        #region 1) haftanın hangi günü
            //Console.WriteLine("Tarih giriniz: ");

            /* DateTime time = DateTime.Now;
            Console.WriteLine(time.DayOfWeek); */       


        #endregion
        #region 2) datetime now

        //DateTime zaman = DateTime.Now;
        //Console.WriteLine(zaman);
            
        #endregion
        #region 3) tarih ekleme timespan
        //Console.WriteLine("Tarih giriniz: ");

        //DateTime kullanicininTarihi = DateTime.Parse(Console.ReadLine());
        //DateTime toplamTarih = kullanicininTarihi.AddDays(5);
        //Console.WriteLine($"5 gün eklenmiş hâli: {toplamTarih}");

        #endregion
        #region 4) tarih farkı

        //Console.WriteLine("İlk tarihi giriniz :");
        //DateTime ilkTarih = DateTime.Parse(Console.ReadLine());

        //Console.WriteLine("İkinci tarihi giriniz (gün/ay/yıl formatında):");
        //DateTime ikinciTarih = DateTime.Parse(Console.ReadLine());

        //int gunFarki = Math.Abs((ikinciTarih - ilkTarih).Days);

        //Console.WriteLine("İki tarih arasındaki gün farkı: " + gunFarki);
            
        #endregion
        #region 5) yılın kaçıncı günü

/* 
        DateTime time = DateTime.Now;
        Console.WriteLine(time.DayOfYear); */

        #endregion
        #region 6) kontrol

        /* DateTime time = DateTime.Now;
        bool leap = DateTime.IsLeapYear(time.Year);
        string a=leap ? "artık yıl":"artık yıl değildir";
        Console.WriteLine(a); */

            
        #endregion
        #region 7) datetime object (try catch)

        /* try {
            Console.Write("Tarih giriniz");
        DateTime time = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(time.ToString("dd/MM/yyyy"));
        
        }catch(Exception ex){
            Console.WriteLine($"girmiş olduğunuz tarih geçerli değildir. {ex.Message}" );
        }finally{
            Console.WriteLine("Ne olursa olsun çalışacak blok");
        } */

            
        #endregion
        #region 8) Ay adını yazdırmak

        //DateTime day = DateTime.Now;

        //string ayAdi = day.ToString("MMMM");

        //Console.WriteLine(ayAdi);
            
        #endregion
        #region 9) Compare

            /* DateTime time = new DateTime(2000,12,15);
            DateTime time2 = new DateTime(2020,12,15);

            int a = DateTime.Compare(time, time2);
            Console.WriteLine(a); */
            
            
            
        #endregion
        #region 10) 12 - 24 formatı
            //DateTime time = new DateTime(2021,12,15,12,00,00,00);
            //time.AddMilliseconds(1);
            //Console.WriteLine(time.ToString("dd/MM/yyyy HH:mm tt"));
        #endregion
    }
}
