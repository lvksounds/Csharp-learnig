using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            //Declarando um array
            int[] numeros;

            // instanciando o array
            numeros = new int[6]; // nome_array = new tipo[tamanho maximo do array]

            //tambem é possivel sollicitar o tamanho do array ao usuario via teclado
            
            Console.WriteLine("Digite um tamanho para o array.");
            int tamanho = Int32.Parse(Console.ReadLine());
            int[] valores = new int[tamanho];
        }
    }
}