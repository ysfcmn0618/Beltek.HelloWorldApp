namespace Beltek.DizilerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = new int[3];
            //sayilar[0] = 10;
            //sayilar[1] = 20;
            //sayilar[2] = 30;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            //Array.Sort(sayilar);
            //foreach (int i in sayilar)
            //{
            //    Console.WriteLine(i);
            //}

            Console.Write("Kaç isim sıralamak istiyorsunuz :");
            int totalName = int.Parse(Console.ReadLine());
            string[] names = new string[totalName];

            for (int i = 0; i < totalName; i++)
            {
                Console.Write($"{i + 1}. ismi giriniz :");
                names[i] = Console.ReadLine();
            }
            Array.Sort(names);
            Console.WriteLine("Girile isimlerin alfabetik sıralaması :");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{names[i]}");
            }

        }
    }
}
//İndex dizi elemanlarını temsil eden sayılardır ve 0 dan başlar.
//Dizi -Array : Birden fazla aynı türden veriyi bellek de tutmak için kıllanılır.
//Diziler kullanılırken eleman sayıları bilinmelidir.
//Dizilerin referansları STACK bölgesinde değerleri ;HEAP bölgesinte tutulurlar.
