using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            var primaryDiagonal = new int[n];
            var secondaryDiagonal = new int[n];
            var count = 0;
            var negCount = n;
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
                primaryDiagonal[a_i] = primaryDiagonal[a_i] + a[a_i][count];
                secondaryDiagonal[a_i] = secondaryDiagonal[a_i] + a[a_i][negCount - 1];
                count = count + 1;
                negCount = negCount - 1;
            }
            var primaryDiagonalSumRes = primaryDiagonal.Sum();
            var secondaryDiagonalSumRes = secondaryDiagonal.Sum();
            Console.WriteLine("The absolute value is: {0}", Math.Abs(primaryDiagonalSumRes - secondaryDiagonalSumRes));
        }
    }
}
