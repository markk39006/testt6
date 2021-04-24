using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int g = 1;
            while (g <= c)
            {
                
                for (int i = 1; i <= b; i++)
                {
                    for (int j = 1; j <= g*a; j++)
                    {
                        Console.Write(x);

                    }
                    Console.WriteLine();
                }
                g++;
            }
          
        }
    }
}
