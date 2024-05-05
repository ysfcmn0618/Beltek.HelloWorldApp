using System;

namespace Beltek.HelloWorldApp
{

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
            //EXCEPTİON HANDLİNG
            // try catch blokların da hata önetimi uglanır oluşan her hata için bit catch bloğu oluşturulur ve yakalanan hata türünü göre hata yönetimi uygulanır.uygulanması gerekir.

            //try
            //{
            //    Console.Write("Adınızı Giriniz :");
            //    string name = Console.ReadLine();
            //    Console.Write("Soyadınızı Giriniz :");
            //    string surname = Console.ReadLine();
            //    Console.Write("Yaşınızı Giriniz :");
            //    byte age = byte.Parse(Console.ReadLine());

            //    Console.WriteLine($"Hoşgeldin Canım {name} {surname} neden geciktin?!!\n {age} yıl beklemeye ne gerek vardı.!!!");

            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("0-255 arası bir değer giriniz!!!");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Yaşınızı sayı olarak giriniz lütfen!!!");
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Bilinmeyem Bir Hata Oluştu!!!!");
            //}

            //*******OPERATORLER (?: kARAR YAPILARI 2 olasılığı karşılaştırırken kullanılır)

            //Console.WriteLine("Bir sayı giriniz :");
            //int sayi1= int.Parse(Console.ReadLine());
            //Console.WriteLine("Bir sayı daha giriniz :");
            //int sayi2= int.Parse(Console.ReadLine());
            //string sonuç = sayi1>sayi2 ? "İlk girilen sayı büyüktür" : "sayı 2 büyüktür yada eşittir";
            //Console.WriteLine(sonuç);


            //Console.WriteLine("Bir sayı giriniz :");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bir sayı daha giriniz :");
            //int sayi2 = int.Parse(Console.ReadLine());

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Sayı 1 büyüktür");
            //}
            //else if (sayi1 < sayi2)
            //{
            //    Console.WriteLine("Sayı 2 büyüktür.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar eşittir");
            //}


            //hava nasıl ? Güzel : dışarı çık ? kötü evde otur ? sadece güzel ve kötü cevaplarını verebilirsiniz.

            //Console.WriteLine("Bu gün hava nasıl?");
            //string weather = Console.ReadLine().ToLower();
            //if (weather == "güzel")
            //{
            //    try
            //    {
            //        Console.WriteLine("Kaç derece hava sıcaklığı : ");
            //        sbyte wearm = sbyte.Parse(Console.ReadLine());

            //        //Kaç derece <10 soğuk evde otur 10-30 Hava güzel dışarı çık >30 çok sıcak evde otur

            //        if (wearm < 10)
            //        {
            //            Console.WriteLine("Hava soğuk evde otur!!");

            //        }
            //        else if (wearm > 10 && wearm < 30)
            //        {
            //            Console.WriteLine("Hava güzel dışarı çık");

            //        }
            //        else
            //        {
            //            Console.WriteLine("Hava çok sıcak evde otur");
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Sıcaklığı rakam olarak giriniz");
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Bu sıcaklıkta nasıl hayatta kalabildin!!!!");
            //    }
            //    catch (Exception)
            //    {

            //        throw;
            //    }
            //}
            //else if (weather == "kötü")
            //{
            //    Console.WriteLine("Evde otur!!!");
            //}
            //else
            //{
            //    Console.WriteLine("Sadece Güzel  ve  Kötü ifadelerini verebilirsiniz!!!");
            //}

            //******SWİTCH CASE YAPIILARI 


            //Console.WriteLine("apmak istediğiniz işlemi seçiniz \n1- Havale işlemleri \n2- Eft işlemleri\n3-Internet bankacılığı\n4- Müşteri hizmetleri");
            //byte chose = byte.Parse(Console.ReadLine());

            //switch (chose)
            //{
            //    case 1: Console.WriteLine("Havale işlemleri"); break;
            //    case 2: Console.WriteLine("Eft işlemleri "); break;
            //    case 3: Console.WriteLine("İnternet bankacılığı"); break;
            //    case 4: Console.WriteLine("Müşteri Hizmetleri"); break;
            //    default:
            //        Console.WriteLine("Yanlış seçim yaptınız");
            //        break;
            //}

            ///***ALAN HESABI YAPTIRMA

            Console.WriteLine("Alanının hesaplanmasını istediğiniz şekli seçiniz: \n1-Kare \n2- Daire \n3-Üçgen");
            byte sekil = byte.Parse(Console.ReadLine());
            int kkenar, rcap, taban, yukseklik;
            switch (sekil)
            {
                case 1:
                    Console.WriteLine("Karenin kenar uzunluğunu giriniz : ");
                    kkenar = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Karenin alanı:{kkenar*kkenar}");
                    break;
                case 2:
                    Console.WriteLine("Yarı çap giriniz : ");
                    rcap = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Dairenin çapı :{Math.PI * rcap * rcap}");
                    break;
                case 3:
                    Console.WriteLine("Taban ölçüsünü giriniz : ");
                    taban = int.Parse(Console.ReadLine());
                    Console.WriteLine("yükseklik ölçüsünü giriniz :");
                    yukseklik = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Üçgenin alanı :{taban * yukseklik / 2}");
                    break;
                default:
                    Console.WriteLine("Şu an başka bir şeklimiz mevcut değil!!!!");
                    break;
            }




            #endregion

            //Console.WriteLine("Merhaba !!");
            //Console.ReadKey();



        }
    }
}
//proje içerisinde genel tanımlamaları otomatik kullanmayı kaldırmak için proje üzerinde sağ tık/özellikler /global using /implisint global using kaldırdığımız da geçerli proje içerisinde System gibi temel namespacelerin otomatik tanımlamasını kaldırır. ve manuel olarak eklenmesi gerekir.
//intellisense
//ctrl + k d kodları düenler
//ctrl +k c comment satırı ekleme
//ctrl + k u uncomment 
//ctrl + . namespace using eklemek için açılır menü 
//ctrl + k s region gibi kod bloklarını oluşturabileceğimiz menü açılır.
//Debug modda breakpointtten programı adım adım ilrletmek için f10 kullanılır