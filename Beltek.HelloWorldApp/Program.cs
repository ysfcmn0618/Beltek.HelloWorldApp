namespace Beltek.HelloWorldApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Lütfen Adınızı Giriniz :");
            string name = Console.ReadLine();
            Console.WriteLine("Hoşgeldin, "+name);
            Console.ReadKey();
        }
    }
}
