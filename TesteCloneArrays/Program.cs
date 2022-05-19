using System;

namespace TesteClonagemArrays
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[] { 23, 45, 1, 23, 776, 2 };
            int[] arr2 = new int[arr.Length];
            arr.CopyTo(arr2, 0);

            foreach (int i in arr2)
            {
                Console.WriteLine(i);   
            }
        }
    }
}