using System;

namespace Param_valor
{
    class Program
    {
        static void Main()
        {
            int numero;
            Console.WriteLine("Digite um numero:");
            numero = int.Parse(Console.ReadLine());
            
            // chamando metodo
            quadrado(numero);

            // mostrando que a variavel original nao foi alterada
            Console.WriteLine("Numero digitado foi: {0}", numero);

        }

        public static void quadrado(int num1)
        {
            int quad = num1 * num1;
            Console.WriteLine(quad.ToString());
        }
    }
}