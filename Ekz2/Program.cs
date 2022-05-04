using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ekz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mat = new int[4][];
            mat[0] = new int[] {1, 3, 5};
            mat[1] = new int[] {2, 4, 6};
            mat[2] = new int[] {9, 8, 7};
            mat[3] = new int[] {8, 7, 9};
            Console.WriteLine("Массив: ");

            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat.Length; j++)
                {
                   Console.WriteLine(mat[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = i + 1; j < mat.Length; j++)
                {
                    if (test(mat[i], mat[j]))
                    {
                        Console.WriteLine("Похожие строки {0} и {1} \t", i + 1, j + 1);
                       

                    }
                }
            }
            
        }
        private static bool test(int[] row, int[] row1)
        {
            Array.Sort(row);
            Array.Sort(row1);
            for (int i = 0; i < row.Length; i++)
            {
                if (row[i] != row1[i]) return false;
            }
            return true;
        }
    }
}
