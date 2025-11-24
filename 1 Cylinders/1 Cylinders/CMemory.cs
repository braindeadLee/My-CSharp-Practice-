using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinders
{
    internal class CMemory
    {

        public static void Run()
        {
            int[] a1, a2, a3;

            a1 = new int[] { 1, 2, 3 };
            a2 = a1;
            a3 = new int[5];

            Console.WriteLine($"a1[0] = {a1[0]}");
            Console.WriteLine($"a2[0] = {a2[0]}");

            a1[0] = 4;
            Console.WriteLine($"a1[0] = {a1[0]}");
            Console.WriteLine($"a2[0] = {a2[0]}");

            a2[0] = 5;
            Console.WriteLine($"a1[0] = {a1[0]}");
            Console.WriteLine($"a2[0] = {a2[0]}");

            a1.CopyTo(a3, 0);

            Console.WriteLine($"a3[0] = {a3[0]}");
            Console.WriteLine($"a3[1] = {a3[1]}");
            Console.WriteLine($"a3[2] = {a3[2]}");
        

        }
    }
}
