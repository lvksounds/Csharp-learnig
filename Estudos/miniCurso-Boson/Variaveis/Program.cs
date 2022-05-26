using System;

namespace Variaveis
{
    // reajuste salario
    /*
     4 – Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a seguinte regra: 
    Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.
     */
    class Program2
    {
        static void Main()
        {
            double salario = 0;
            double salNovo = 0;
            double perc = 0;
      
            Console.WriteLine("Digite seu salario para cacularmos o reajuste");
            salario = Convert.ToDouble(Console.ReadLine());
            

            if (salario <= 300)
            {
                perc = 50.0/100.0 * salario;
                salNovo = salario + perc;
            }
            else if (salario > 300)
            {
                perc = 30.0/100.0 * salario;
                salNovo = salario + perc;
            }

            Console.WriteLine("Salario reajustado de R${0} para R${1}", salario, salNovo);
        }
    }

}