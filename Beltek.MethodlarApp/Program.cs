using System.Reflection.Metadata.Ecma335;

namespace Beltek.MethodlarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aşağıdaki parametreler ile yapmak istediğiniz işlemi belirtiniz.\n '+' Toplama işlemi için \n '-' çıkarma  \n'*' çarpma \n '/' Bölme işlemi \n '2' Üst değer hesabı \n 'A' Asal Durum");
            string islem = Console.ReadLine();
            double var1 = SayiAl(islem);
            double var2 = SayiAl(islem);
            Math.Pow(var1, var2);
            switch (islem)
            {
                case "+":
                    ////Console.Write("Toplamak istediğiniz 1. sayıyı giriniz :");
                    //var1 = SayiAl1();
                    ////Console.Write("Toplamak istediğiniz 2. sayıyı giriniz :");
                    //var2 = SayiAl2();// int.Parse(Console.ReadLine());
                    Console.WriteLine($"Toplam = {Topla(var1, var2)}");
                    break;
                case "-":
                    ////Console.Write("Çıkarmak istediğiniz 1. sayıyı giriniz :");
                    ////var1 = int.Parse(Console.ReadLine());
                    //var1 = SayiAl1();
                    ////Console.Write("Çıkarmak istediğiniz 2. sayıyı giriniz :");
                    ////var2 = int.Parse(Console.ReadLine());
                    //var2 = SayiAl2();
                    Console.WriteLine($"Sonuç = {Cikar(var1, var2)}");
                    break;
                case "*":
                    ////Console.Write("Çarpmak istediğiniz 1. sayıyı giriniz :");
                    ////var1 = int.Parse(Console.ReadLine());
                    //var1 = SayiAl1();
                    ////Console.Write("Çarpmak istediğiniz 2. sayıyı giriniz :");
                    ////var2 = int.Parse(Console.ReadLine());
                    //var2 = SayiAl2();
                    Console.WriteLine($"Sonuç = {Carp(var1, var2)}");
                    break;
                case "/":
                    ////Console.Write("Bölmek istediğiniz sayıyı giriniz :");
                    ////var1 = int.Parse(Console.ReadLine());
                    //var1 = SayiAl1();
                    ////Console.Write("Böleni giriniz :");
                    ////var2 = int.Parse(Console.ReadLine());
                    //var2 = SayiAl2();
                    Console.WriteLine($"Sonuç = {Bol(var1, var2)}");
                    break;
                case "2":
                    Console.WriteLine($"Sonuç = {UsluSayi(var1, var2)}");
                    break;
                case "A":
                    Console.WriteLine($"Sonuç 1. sayı için = {AsalMi(var1)}");
                    Console.WriteLine($"Sonuç 2. sayı için = {AsalMi(var2)}");
                    break;

            }
        }
        /// <summary>
        /// Toplama işlemi 3 farklı overload ile işleme alınmıştır 2 ve 3 farklı sayı girilip toplanması ve bir array toplama işlemi olarak tasarlanmıştır
        /// </summary>
        /// <param name="var1"></param>
        /// <param name="var2"></param>
        /// <returns></returns>
        static double Topla(double var1, double var2) => var1 + var2;
        static double Topla(double var1, double var2, double var3) => var1 + var2 + var3;
        static double Topla(params double[] var)
        {
            double toplam = 0;
            //for (int i = 0; i < var.Length; i++)
            //{
            //    toplam += var[i];
            //}

            foreach (var item in var)
            {
                toplam += item;
            }
            return toplam;
        }


        static double Cikar(double var1, double var2) => var1 + var2;

        static double Carp(double var1, double var2) => var1 + var2;

        static double Bol(double var1, double var2) => var1 + var2;

        static double UsluSayi(double taban, double us)
        {
            double var1 = taban;
            for (int i = 1; i < us; i++)
            {
                var1 *= taban;
            }
            return var1;
        }

        //static double SayiAl1()
        //{
        //    Console.Write("1. Sayıyı giriniz =");
        //    return double.Parse(Console.ReadLine());
        //}
        //static double SayiAl2()
        //{
        //    Console.Write("2. Sayıyı giriniz =");
        //    return double.Parse(Console.ReadLine());
        //}
        static double SayiAl(string islem)
        {
            switch (islem)
            {
                case "+": islem = "Toplanacak"; break;
                case "-": islem = "Çıkarılacak"; break;
                case "*": islem = "Çarpılacak"; break;
                case "/": islem = "Bölme işlemi için"; break;
                case "2": islem = "Üstlü sayı hesabı için "; break;
            }


            Console.Write($"{islem} Sayı giriniz =");
            return double.Parse(Console.ReadLine());
        }

        static bool AsalMi(double sayi)
        {
            int kontrol = 0;
            //bool sonuc;
            for (int i = 2; i <= sayi / 2; i++)
            {
                if (sayi % i == 0)
                {
                    kontrol++;
                    break;
                }
            }

            //if (kontrol == 0 ? sonuc= true : sonuc= false);
            return kontrol == 0; //== ifadesi bool değer dondüğü için direkt olarak kontrolun 0 olum olmadığını kontrol edip sonuç doner ve işlemi gerçekleştirmiş olur.bu yolla bir değişken tanımlama ve bir if ifadesinden kurtulmuş oluyoruz
        }



    }
}

//Method Signature - Method imzası : Method parametrelerinin sayıları ve veri tipleri,method imzasını oluşturur.
/// 3 slash yan yana methodun üstüne eklendiğinde methoda özet açıklama yazmak için kullanılır . ve kullanılmalı yazılan methodun nasıl kullanılacağına dair bilgi girilmeli.
// methot overloading aynı isimde birden fazla method tanımlanması methotdun işlevselliğini arttırmak için kullanılır