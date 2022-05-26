using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumAlgorithm
{
    public static class Utilidade
    {
       public static List<List<int>> FindTwoSum(int[] array, int sum)
        {
            List<List<int>> result = new List<List<int>>();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    var isSum = (array[i] + array[j]) == sum;
                    if (isSum)
                    {
                        result.Add(new List<int> { array[i], array[j] });
                    }
                }
            }

            return result;
        }
    }
}