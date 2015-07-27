using System;
using System.Linq;
using Task1.RefactoringJaggedArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace Task1.RefactoringJaggedArray.Tests
{
    [TestClass]
    public class JaggedArrayTests
    {
        [TestMethod]
        public void Sort_ArrayAndAscLengthCompison_ArraySortedByLengthByAsc()
        {
            int[][] array = new int[][]
            { 
                new int[] {-1, 2},
                new int[] {0, 1, 1, 0},
                new int[] {0, 0, 0, 0, 0},
                new int[] {3},
                new int[] {2, 4, 1}
            };

            int[][] expected = new int[][]
            {
                new int[] {3},
                new int[] {-1, 2},
                new int[] {2, 4, 1},
                new int[] {0, 1, 1, 0},
                new int[] {0, 0, 0, 0, 0}
            };

            JaggedArray.Sort(array, (x, y) => x.Length - y.Length);
            IStructuralEquatable actual = array;

            Assert.IsTrue(actual.Equals(expected, StructuralComparisons.StructuralEqualityComparer));
        }

        [TestMethod]
        public void Sort_ArrayAndDescLengthCompison_ArraySortedByLengthByAsc()
        {
            int[][] array = new int[][]
            { 
                new int[] {-1, 2},
                new int[] {0, 1, 1, 0},
                new int[] {0, 0, 0, 0, 0},
                new int[] {3},
                new int[] {2, 4, 1}
            };

            int[][] expected = new int[][]
            {
                new int[] {0, 0, 0, 0, 0},
                new int[] {0, 1, 1, 0},
                new int[] {2, 4, 1},
                new int[] {-1, 2},
                new int[] {3}
            };

            JaggedArray.Sort(array, (x, y) => y.Length - x.Length);
            IStructuralEquatable actual = array;

            Assert.IsTrue(actual.Equals(expected, StructuralComparisons.StructuralEqualityComparer));
        }

        [TestMethod]
        public void Sort_ArrayAndAscMaxAbsolutValueCompison_ArraySortedByMaxAbsoluteValueByAsc()
        {
            int[][] array = new int[][]
            { 
                new int[] {-1, 2},
                new int[] {0, 1, 1, 0},
                new int[] {0, 0, 0, 0},
                new int[] {3, -5, 2, 0},
                new int[] {2, 4, 1}
            };

            int[][] expected = new int[][]
            {
                new int[] {0, 0, 0, 0},
                new int[] {0, 1, 1, 0},
                new int[] {-1, 2},
                new int[] {2, 4, 1},
                new int[] {3, -5, 2, 0}
            };

            JaggedArray.Sort(array, (x, y) => x.Max(new Func<int, int>(Abs)) - y.Max(new Func<int, int>(Abs)));
            IStructuralEquatable actual = array;

            Assert.IsTrue(actual.Equals(expected, StructuralComparisons.StructuralEqualityComparer));
        }

        [TestMethod]
        public void Sort_ArrayAndDescMaxAbsolutValueCompison_ArraySortedByMaxAbsoluteValueByDesc()
        {
            int[][] array = new int[][]
            { 
                new int[] {-1, 2},
                new int[] {0, 1, 1, 0},
                new int[] {0, 0, 0, 0},
                new int[] {3, -5, 2, 0},
                new int[] {2, 4, 1}
            };

            int[][] expected = new int[][]
            {
                new int[] {3, -5, 2, 0},
                new int[] {2, 4, 1},
                new int[] {-1, 2},
                new int[] {0, 1, 1, 0},
                new int[] {0, 0, 0, 0}
            };

            JaggedArray.Sort(array, (x, y) => y.Max(new Func<int, int>(Abs)) - x.Max(new Func<int, int>(Abs)));
            IStructuralEquatable actual = array;

            Assert.IsTrue(actual.Equals(expected, StructuralComparisons.StructuralEqualityComparer));
        }

        [TestMethod]
        public void Sort_ArrayAndAscSumElementsCompison_ArraySortedBySumElementsByAsc()
        {
            int[][] array = new int[][]
            { 
                new int[] {-1, 2},
                new int[] {0, 1, 1, 0},
                new int[] {0, 0, 0, 0},
                new int[] {3, -5, 2, 3},
                new int[] {2, 4, 1}
            };

            int[][] expected = new int[][]
            {
                new int[] {0, 0, 0, 0},
                new int[] {-1, 2},
                new int[] {0, 1, 1, 0},
                new int[] {3, -5, 2, 3},
                new int[] {2, 4, 1}
            };

            JaggedArray.Sort(array, (x, y) => x.Sum() - y.Sum());
            IStructuralEquatable actual = array;

            Assert.IsTrue(actual.Equals(expected, StructuralComparisons.StructuralEqualityComparer));
        }

        [TestMethod]
        public void Sort_ArrayAndDescSumElementsCompison_ArraySortedBySumElementsByDesc()
        {
            int[][] array = new int[][]
            { 
                new int[] {-1, 2},
                new int[] {0, 1, 1, 0},
                new int[] {0, 0, 0, 0},
                new int[] {3, -5, 2, 3},
                new int[] {2, 4, 1}
            };

            int[][] expected = new int[][]
            {
                new int[] {2, 4, 1},
                new int[] {3, -5, 2, 3},
                new int[] {0, 1, 1, 0},
                new int[] {-1, 2},
                new int[] {0, 0, 0, 0}                
            };

            JaggedArray.Sort(array, (x, y) => y.Sum() - x.Sum());
            IStructuralEquatable actual = array;

            Assert.IsTrue(actual.Equals(expected, StructuralComparisons.StructuralEqualityComparer));
        }

        [TestMethod]
        public void Sort_ArrayAndAscMaxAbsolutValueComparer_ArraySortedByMaxAbsoluteValueByAsc()
        {
            int[][] array = new int[][]
            { 
                new int[] {-1, 2},
                new int[] {0, 1, 1, 0},
                new int[] {0, 0, 0, 0},
                new int[] {3, -5, 2, 0},
                new int[] {2, 4, 1}
            };

            int[][] expected = new int[][]
            {
                new int[] {0, 0, 0, 0},
                new int[] {0, 1, 1, 0},
                new int[] {-1, 2},
                new int[] {2, 4, 1},
                new int[] {3, -5, 2, 0}
            };

            JaggedArray.Sort(array, new AscMaxAbsoluteValueComparer());
            IStructuralEquatable actual = array;

            Assert.IsTrue(actual.Equals(expected, StructuralComparisons.StructuralEqualityComparer));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Sort_NullAndDescSumElementsCompison_ArgumentNullException()
        {
            JaggedArray.Sort(null, (x, y) => y.Sum() - x.Sum());
        }

        private static int Abs(int number)
        {
            return number < 0 ? -number : number;
        }
    }
}
