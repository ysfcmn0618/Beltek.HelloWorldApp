﻿namespace Beltek.HelloWorldApp
{
    internal class Program
    {
        static int stat = 10;

        static void Main(string[] args)
        {
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

            string name, surname;
            byte age;
            Console.Write("Hoşgeldiniz Lütfen Adınızı giriniz : ");
            name = Console.ReadLine();
            Console.Write("Lütfen Soyadınızı giriniz : ");
            surname = Console.ReadLine();
            Console.Write("Lütfen yaşınızı giriniz : ");
            age = byte.Parse(Console.ReadLine());

            Console.WriteLine($"Adınız :{name} Soyadınız :{surname} Yaşınız :{age} Verdiğiniz bilgiler için teşekkürler.");

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
            #endregion

            #endregion




            Console.ReadKey();



        }
    }
}
