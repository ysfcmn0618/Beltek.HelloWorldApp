namespace Beltek.Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Başlangıç değerini giriniz = ");
            //byte bas = byte.Parse(Console.ReadLine());
            //Console.WriteLine("Bitiş değerini giriniz = ");
            //byte bitis = byte.Parse(Console.ReadLine());
            //Console.WriteLine("Tek - Çift ?");
            //string secim = Console.ReadLine().ToLower();

            //int sonuc = 0;
            //if (bas > bitis)
            //{
            //    byte temp = bas;
            //    bas = bitis;
            //    bitis = temp;
            //}


            //for (int i = bas; i < bitis; i++)
            //{
            //    if (secim == "çift" && i % 2 == 0  )    //Başlangıç ve bitiş arasındaki çift sayıları yazar
            //    {

            //        Console.WriteLine($"Çift {i}");
            //        i+=2;
            //        sonuc += i;
            //    }
            //    else if ( secim == "tek" &&  i % 2 == 1 )
            //    {
            //        sonuc += i;
            //        Console.WriteLine($"Tek {i}");
            //    }
            //}

            //if (i % 2 == (secim == "tek" ? 1 : 0))   // i nin yai başlangıç değerimizin mod 2 sinden kalan tek mi diye bakar ve "TEK" ise mod 2 sini 1 mi diye kontrl eder  ve şartı yerine getirir .
            //{
            //    sonuc += i;
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine($"İşlemin sonucu :{sonuc}");

            ////üslü sayıların sonucu na göre işlem yapma ****üslü sayıları tam sayıya çevirme
            //Console.WriteLine("Taban değeri giriniz = ");
            //byte taban = byte.Parse(Console.ReadLine());
            //Console.WriteLine("Üst değerini giriniz = ");
            //byte us = byte.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 0; i < us; i++)
            //{
            //    sonuc *= taban;
            //}
            //Console.WriteLine(sonuc);


            ////Faktoriyel hesabı yapma
            //Console.WriteLine("Sayı giriniz = ");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;

            //for (int i = 1; i <= sayi; i++)
            //{
            //    sonuc *= i;
            //    //if (i== sayi)
            //    //{
            //    //    Console.WriteLine($"Sonuç = {sonuc}");
            //    //}
            //}
            //Console.WriteLine($"Sonuç = {sonuc}");


            ////ASAL sayı hesabı
            //int kontrol = 0;
            //Console.Write("Sayı Girin : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 2; i <= sayi / 2; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        kontrol++;
            //        break;
            //    }
            //}

            //Console.WriteLine(kontrol == 0 ? "Girdiğiniz sayı asaldır." : "Girdiğiniz sayı asal değildir.");
            //Console.ReadKey();

            //string user;
            //for (; ; )
            //{
            //    Console.Write("Kullancı adı giriniz : ");
            //    user = Console.ReadLine().ToLower();
            //    Console.Write("Şifre  giriniz : ");
            //    string password = Console.ReadLine().ToLower();
            //    if (user == "admin" && password == "123")
            //    {
            //        Console.WriteLine("Hoşgeldin admin");
            //        break;
            //    }
            //    else
            //        Console.WriteLine("Hatalı giriş tekrar deneyin");

            //}


            //int max = int.MinValue, ciftToplam = 0;
            //for (; ; )//Sonsuz döngü
            //{
            //    Console.WriteLine("Sayı giriniz :");
            //    int sayi = int.Parse(Console.ReadLine());
            //    if (sayi > max)
            //    {
            //        max = sayi;                    
            //    }
            //    if (sayi % 2 == 0)
            //    {
            //        ciftToplam += sayi;
            //    }
            //    Console.WriteLine("Devam etmek istiyormusnuz? (e-h)");
            //    char devam = char.Parse(Console.ReadLine().ToLower());
            //    if (devam == 'h')
            //    {
            //        Console.WriteLine($"Girilen en büyük sayı {max} \nGirilen Çift sayıların Toplamı : {ciftToplam}");
            //        break;//Gerekli şartlar sağlanınca sonsuz döngünün kırıldığı nokta
            //    }
            //}

            //while (true)
            //{

            //}

            //var rnd = new Random();
            //int num = rnd.Next(100);

            //byte hak = 0;
            //while (hak < 3)
            //{
            //    Console.Write("0-100 arası bir sayı giriniz :");
            //    int val = int.Parse(Console.ReadLine());
            //    if (val == num)
            //    {
            //        Console.WriteLine("Bildiniz.");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bilemediniz!!!");
            //        hak++;
            //    }

            //}

            bool devam = false;
            int val, toplam = 0;
            char cevap;
            do
            {
                Console.Write("Bir sayı giriniz :");
                val = int.Parse(Console.ReadLine());
                toplam += val;
                Console.Write("Devam etmek istiyormusnuz (yes/no - y/n):");
                cevap = char.Parse(Console.ReadLine());
                if (cevap == 'y') { devam = true; }
            } while (devam);
            Console.WriteLine($"Girilen sayıların toplamı : {toplam}");
            Console.ReadKey();

        }
    }
}
