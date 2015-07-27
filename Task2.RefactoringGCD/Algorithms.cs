using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.RefactoringGCD
{
    public class Algorithms
    {
        private delegate int AlgorithmGCD(int a, int b);

        #region Euclidean algorithm

        public static int GCDEuclidean(int a, int b)
        {
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return a + b;
        }

        public static int GCDEuclidean(out TimeSpan runTime, int a, int b)
        {
            return GCD(out runTime, GCDEuclidean, a, b);
        }

        public static int GCDEuclidean(out TimeSpan runTime, int a, int b, int c)
        {
            return GCD(out runTime, GCDEuclidean, a, b, c);
        }

        public static int GCDEuclidean(out TimeSpan runTime, params int[] array)
        {
            return GCD(out runTime, GCDEuclidean, array);
        }
        #endregion

        #region Binary algorithm

        public static int GCDBinary(int a, int b)
        {
            int shift;
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;

            if (a == 0 || b == 0)
            {
                return a | b;
            }

            for (shift = 0; ((a | b) & 1) == 0; shift++)
            {
                a >>= 1;
                b >>= 1;
            }

            while ((a & 1) == 0)
            {
                a >>= 1;
            }

            do
            {
                while ((b & 1) == 0)
                {
                    b >>= 1;
                }

                if (a < b)
                {
                    b -= a;
                }
                else
                {
                    int diff = a - b;
                    a = b;
                    b = diff;
                }
                b >>= 1;
            } while (b != 0);

            return a << shift;
        }

        public static int GCDBinary(out TimeSpan runTime, int a, int b)
        {
            return GCD(out runTime, GCDBinary, a, b);         
        }

        public static int GCDBinary(out TimeSpan runTime, int a, int b, int c)
        {
            return GCD(out runTime, GCDBinary, a, b, c);
        }

        public static int GCDBinary(out TimeSpan runTime, params int[] array)
        {
            return GCD(out runTime, GCDBinary, array);
        }
        #endregion


        private static int GCD(out TimeSpan runTime, AlgorithmGCD algorithm, int a, int b)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int result = algorithm(a, b);

            stopWatch.Stop();
            runTime = stopWatch.Elapsed;

            return result;
        }

        private static int GCD(out TimeSpan runTime, AlgorithmGCD algorithm, int a, int b, int c)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int intermediateGCD = algorithm(a, b);
            int finalGCD = algorithm(intermediateGCD, c);

            stopWatch.Stop();
            runTime = stopWatch.Elapsed;
            return finalGCD;
        }

        private static int GCD(out TimeSpan runTime, AlgorithmGCD algorithm, int[] array)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            if (array.Length == 0)
                throw new ArgumentException("array is empty", "array");
            if (array.Length == 1)
            {
                stopWatch.Stop();
                runTime = stopWatch.Elapsed;
                return array[0];
            }
            int intermediateGCD = algorithm(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
                intermediateGCD = algorithm(intermediateGCD, array[i]);
            int finalGCD = intermediateGCD;

            stopWatch.Stop();
            runTime = stopWatch.Elapsed;
            return finalGCD;
        }

    }
}
