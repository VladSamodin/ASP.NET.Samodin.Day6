using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.RefactoringJaggedArray.Tests
{
    class AscMaxAbsoluteValueComparer : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            int maxX = x.Max(number => number < 0 ? -number : number);
            int maxY = y.Max(number => number < 0 ? -number : number);
            return maxX - maxY;
        }
    }
}
