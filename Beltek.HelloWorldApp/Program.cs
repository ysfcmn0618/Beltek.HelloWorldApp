namespace Beltek.HelloWorldApp
{
    internal class Program
    {
        static int stat = 10;

        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello, World!");
            //Console.WriteLine("Lütfen Adınızı Giriniz :");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hoşgeldin, "+name);
            //Console.ReadKey();

            const byte abc = 30;
            byte a = 1, c;
            double b = 2, d;
            //Int16 value = 3;
            c = 3;//Explicit = açık açık apılan tanımlamalar / Clearly definiations name 
            d = 4;

            var sayi = 5; //implicit örtülü tanımlama tipi içeriğin tipini sysyem belirler /closed definitions this value type verdict is given to the sysyem


            string name = "Ahmet", surname = "meğmet";
            Console.WriteLine("Welcome " + " " + name + " " + surname);
            Console.WriteLine("Welcome {0} {1}",name,surname);
            Console.WriteLine($"Welcome {name} {surname}");
        }
    }
}
