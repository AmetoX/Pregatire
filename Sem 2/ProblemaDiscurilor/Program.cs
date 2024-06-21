using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDiscurilor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  |   |   |         [-]
            //  |   |   |        [--]
            //  |   |   |       [---]
            // --- --- ---
            //  A   B   C
            // sa ducem discurile de pe A pe C 
            //1.Se poate muta un singur disc o data
            //2.Nu se poatepune un disc de diam. mai mare 
            //

            Hanoi(7, 'A', 'B', 'C');
        }

        static void Hanoi(int n, char A, char B, char C)
        {
            if (n == 1)
            {
                Console.WriteLine(A + "-->" + C);
            }
            else
            {
                Hanoi(n - 1, A, C, B);
                Hanoi(1, A, B, C);
                Hanoi(n - 1, B, C, A);
            }
        }
    }
}
