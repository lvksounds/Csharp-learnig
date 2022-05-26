using System;

namespace TwoSumAlgorithm
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[] { 2, 5, 8, 3, -2, 9, 0 };
            int targetSum = 3;
            
            Console.WriteLine(Utilidade.FindTwoSum(arr, targetSum));
        }

        static void ConvertToString(List<List<int>> listOfLists)
        {
            string result = String.Empty;
            result += "[";
        }
    }
}