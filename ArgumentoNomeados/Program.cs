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


            Console.WriteLine("Digite o parametro para o numero 02: (texto): ");
            parametro02 = Console.ReadLine();
            Console.WriteLine("Agora digite o parametro opcional (numero): ");
            parametro01 = int.Parse(Console.ReadLine());

            // chamando o paramtro nomeado
            paramOpcional(par2: parametro02, par1: parametro01);

            Console.WriteLine();
        }
        static void paramOpcional(int par1, string par2 = "Inserido pelo metodo")
        {
            string resultado = "Parametro obrigatorio: " + par1.ToString() + " Parametro opcional: " + par2;
            Console.WriteLine(resultado);
        }
    }
}