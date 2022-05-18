using System;

namespace ClonandoArray
{
    class Program
    {
        static void Main()
        {
            // copiando array com o for
            int[] arr = new int[] { 6, 5, 2, 6, 10, 4 };
            int[] arrClone = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arrClone[i] = arr[i];
            }

            foreach(int i in arrClone)
            {
                Console.WriteLine(i);
            }

            // copiando com o metodo CopyTo

            int[] numeros = new int[] { 1, 2, 3, 4, 5 };
            int[] copiaNumeros = new int[numeros.Length];
            numeros.CopyTo(copiaNumeros, 0);

            foreach (int i in copiaNumeros)
            {
                Console.WriteLine(i);
            }
        }
    }
}