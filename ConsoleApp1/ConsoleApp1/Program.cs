using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Imprime los numero del x hasta y de -1");
            Console.WriteLine("De donde arrancamos del ciclo (MAYOR) : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("de donde terminamos el ciclo (menos): ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("de cuanto en cuanto: ");
            z = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i > y; i -= z)
            {
                Console.WriteLine("i = " + i);


            }

        }
    }
}
