using System; 

namespace Metodos_sobrecarregados
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Digite um n° para calcular o seu quadrado");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: {0}", potencia(num1));

            Console.WriteLine("Digite dois numeros para calcular a potencia X ^ Y: ");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Resultado = {0}", potencia(num1, num2));

        }

        public static double potencia( double valor)
        {
            double resultado = valor * valor;
            return resultado;
        }

        public static double potencia(double valor1, double valor2)
        {
            return Math.Pow(valor1, valor2);
        }
    }
}