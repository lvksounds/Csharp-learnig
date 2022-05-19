using System;

namespace Metodo_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma;
            int val1;
            int val2;
            Console.WriteLine("Digite o 1° numero:");
            val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° numero:");
            val2 = int.Parse(Console.ReadLine());

            soma = somaNumeros(val1, val2);
            Console.WriteLine("Resultado da soma: {0}", soma);  
        }

        // soma de dois numeros:
        static int somaNumeros(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
            

        }
    }
}