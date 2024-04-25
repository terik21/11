using System;
namespace pc {
    class Programm { 
        static void Main()
        {
            int countp = int.Parse(Console.ReadLine());
            comp(countp);
        }
        public static void comp(int i)
        {
            if (i % 10 == 1 && (i % 100 > 20 || i % 100 < 2))
            {
                Console.WriteLine($"{i} компьютер");
            }
            else if (i % 10 < 5 && (i % 100 > 20 || i % 100 < 5)) 
            { 
                Console.WriteLine($"{i} компьютера"); 
            }
            else
            {
                Console.WriteLine($"{i} компьютеров");
            }
        }
    }
}