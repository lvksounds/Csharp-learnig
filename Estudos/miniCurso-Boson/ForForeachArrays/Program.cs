using System;

namespace ForForEachArrays
{
    class Program
    {
        static void Main()
        {
            // Inserindo valores em um array com loop For

            int[] meuArr = new int[5];

            for (int i = 0; i < meuArr.Length; i++)
            {
                Console.WriteLine("Insira um numero.");
                meuArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            // printando os valores em cada indice do array
            for (int i = 0; i  < meuArr.Length; i++)
            {
                Console.WriteLine("Posição {0}: {1}", i, meuArr[i]);
            }

            // iteração com foreach

            foreach (int i in meuArr)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}