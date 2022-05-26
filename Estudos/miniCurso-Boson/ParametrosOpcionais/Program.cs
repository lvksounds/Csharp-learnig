using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ParametroOpcionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int parametro01;
            string parametro02;

            Console.WriteLine("Sem passar o parametro opcional:");
            Console.WriteLine("Digite o parametro obrigatorio (numero): ");
            parametro01 = int.Parse(Console.ReadLine());
            paramOpcional(parametro01);

            Console.WriteLine();

            Console.WriteLine("Passando parametro opcional: ");
            Console.WriteLine("Digite o parametro obrigatorio: (numero): ");
            parametro01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite o parametro opcional (texto): ");
            parametro02 = Console.ReadLine();

            paramOpcional(parametro01, parametro02);

            Console.WriteLine();
        }
        static void paramOpcional(int par1, string par2 = "Inserido pelo metodo")
        {
            string resultado = "Parametro obrigatorio: " + par1.ToString() + " Parametro opcional: " + par2;
            Console.WriteLine(resultado);
        }
    }
}