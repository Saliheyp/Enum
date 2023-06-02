using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);
        }
    }
    enum Gunler{
        Pazartesi,
        Sali,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
}