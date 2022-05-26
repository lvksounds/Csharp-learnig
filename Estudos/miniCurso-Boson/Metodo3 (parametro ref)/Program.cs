using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Métodos_03___parametros_ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Digite um numero:");
            num1 = int.Parse(Console.ReadLine());
            incrementa(ref num1);

            Console.WriteLine("O valor incrementado é {0}", num1);

        }

        static void incrementa(ref int valor) // o argumento está sendo passado como ref, nao criando a necessidade de ser copiado
        {
            valor++;
        }
    }
}