using System;

namespace Modificadores_de_Acesso
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            double peso;

            animal bicho = new animal();
            idade = bicho.ObterIdade();
            peso = bicho.ObterPeso;

            Console.WriteLine("A idade do objeto é: {0} e seu peso {1:F}", idade, peso);
        }
    }
}