using System;

namespace CondicionaisSimples
{
    class Program
    {
        static void Main()
        {
            int n1, n2;
            Console.WriteLine("Insira 2 valores para os teste");
            Console.WriteLine("Primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine(n1);

            }
            else
            {
                Console.WriteLine(n2);
            }
        }
    }
}