using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class ClassTest
    {
        public static bool test(int[] row, int[] row1)
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
