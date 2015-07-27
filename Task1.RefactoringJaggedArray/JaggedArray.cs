using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.RefactoringJaggedArray
{
    public class JaggedArray
    {
        public static void Sort(int[][] array, IComparer<int[]> comparer)
        {
            Sort(array, comparer.Compare);
        }

        public static void Sort(int[][] array, Comparison<int[]> comparison)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                int indexMin = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparison(array[j], array[indexMin]) < 0)
                    {
                        indexMin = j;
                    }
                }
                Swap<int[]>(ref array[i], ref array[indexMin]);
            }
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T buffer = a;
            a = b;
            b = buffer;
        }
    }
}
