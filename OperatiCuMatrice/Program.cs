using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatiCuMatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix A = new Matrix(@"..\..\matrice.txt");
            Matrix B = new Matrix(A);
            Matrix C = A + B;
            Matrix D = A * B;
            foreach (string s in A.View())
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            foreach (string s in C.View())
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            if (D != Matrix.Empty)
            {
                foreach (string s in D.View())
                {
                    Console.WriteLine(s);
                }
            }

        }
    }
}
