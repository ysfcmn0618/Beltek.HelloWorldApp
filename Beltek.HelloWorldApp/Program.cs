using System;

namespace Beltek.HelloWorldApp
{
    //ctrl + k d kodları düenler
    //ctrl +k c comment satırı ekleme
    //ctrl + k u uncomment 
    //ctrl + . namespace using eklemek için açılır menü 
    //ctrl + k s region gibi kod bloklarını oluşturabileceğimiz menü açılır.
    internal class Program
    {


        static void Main(string[] args)
        {
            #region 1. Hafta
            #region Değişkenler
            ////Console.WriteLine("Hello, World!");//ctrl+k+s #region codu bölmelere ayırır region ile açıklama yapabiliriz.
            //Console.WriteLine("Lütfen Adınızı Giriniz :");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hoşgeldin, "+name);
            //Console.ReadKey();

            //const byte abc = 30;
            //byte a = 1, c;
            //double b = 2, d;
            ////Int16 value = 3;
            //c = 3;//Explicit = açık açık apılan tanımlamalar / Clearly definiations name 
            //d = 4;

            //var sayi = 5; //implicit örtülü tanımlama tipi içeriğin tipini sysyem belirler /closed definitions this value type verdict is given to the sysyem 
            #endregion


            #region Tür dönüşümü
            //string name = "Ahmet", surname = "meğmet";
            //Console.WriteLine("Welcome " + " " + name + " " + surname);
            //Console.WriteLine("Welcome {0} {1}", name, surname);
            //Console.WriteLine($"Welcome {name} {surname}");

            //string name, surname;
            //byte age;
            //Console.Write("Hoşgeldiniz Lütfen Adınızı giriniz : ");
            //name = Console.ReadLine();
            //Console.Write("Lütfen Soyadınızı giriniz : ");
            //surname = Console.ReadLine();
            //Console.Write("Lütfen yaşınızı giriniz : ");
            //age = byte.Parse(Console.ReadLine());

            //Console.WriteLine($"Adınız :{name} Soyadınız :{surname} Yaşınız :{age} Verdiğiniz bilgiler için teşekkürler.");

            #region Kontrollü tür dönüşümü
            //checked
            //{
            //    int sayi = 257;
            //    byte number = (byte)sayi;//ctrl+k+s seçilen kod bloğunu küme parantezleri içerisine alır.
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Convert to tür dönüşümü 

            //string sayi = "25";
            //byte number = Convert.ToByte(sayi);
            //Console.WriteLine(number);

            #endregion


            #region Parse tür dönüşümü
            //String değeri byte türüne dönüştüreceğimiz zaman kullanılır parsın uzmanlık alanı stringi byte dönüştürmektir.
            //string sayi = "24";
            //byte _number = byte.Parse(sayi);

            //Console.Write("Adınızı Giriniz :");
            //string name = Console.ReadLine();
            //Console.Write("Soyadınızı Giriniz :");
            //string surname = Console.ReadLine();
            //Console.Write("Yaşınızı Giriniz :");
            //byte age = byte.Parse(Console.ReadLine());

            //Console.WriteLine($"Hoşgeldin Canım {name} {surname} neden geciktin?!!\n {age} yıl beklemeye ne gerek vardı.!!!");

            #endregion

            #endregion


            #endregion

            #region 2. Hafta
            // try catch blokların da hata önetimi uglanır oluşan her hata için bit catch bloğu oluşturulur ve yakalanan hata türünü göre hata yönetimi uygulanır.uygulanması gerekir.
            try
            {
                Console.Write("Adınızı Giriniz :");
                string name = Console.ReadLine();
                Console.Write("Soyadınızı Giriniz :");
                string surname = Console.ReadLine();
                Console.Write("Yaşınızı Giriniz :");
                byte age = byte.Parse(Console.ReadLine());

                Console.WriteLine($"Hoşgeldin Canım {name} {surname} neden geciktin?!!\n {age} yıl beklemeye ne gerek vardı.!!!");

            }
            catch (OverflowException)
            {
                Console.WriteLine("0-255 arası bir değer giriniz!!!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Yaşınızı sayı olarak giriniz lütfen!!!");
            }
            catch (Exception)
            {

                Console.WriteLine("Bilinmeyem Bir Hata Oluştu!!!!");
            }

            #endregion

            Console.WriteLine("Merhaba !!");
            Console.ReadKey();
        }
    }
}
//proje içerisinde genel tanımlamaları otomatik kullanmayı kaldırmak için proje üzerinde sağ tık/özellikler /global using /implisint global using kaldırdığımız da geçerli proje içerisinde System gibi temel namespacelerin otomatik tanımlamasını kaldırır. ve manuel olarak eklenmesi gerekir.
//intellisense 