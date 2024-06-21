using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevideAndCounquer
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Cautare binara
            //  -daca trebuie doar existenta unui element
            //  -daca trebuie pozitia pe care se afla elementul
            //  -iderativ
            //  -recursiva

            //vectorul trebuie sa fie sortat

            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            v[0] = rnd.Next(10);
            for(int i = 1; i < n; i++)
            {
                v[i]= v[i-1] + rnd.Next(5);
            }

            int x = int.Parse(Console.ReadLine());//nr pe care il cautam
            bool t = bs(v,0,n-1,x);

            if (t)
            {
                Console.WriteLine(x + " - Exista");
            }
            else
            {
                Console.WriteLine(x + " - Nu exista");
            }

            for(int i = 0; i < n; i++)
            {
                Console.Write(v[i]+" " );
            }
            Console.WriteLine();

        }

        public static bool bs(int[]v, int st, int dr, int x) // st - stanga, dr - dreapta, m - mijloc
        {
            //timp executie 0(log(n))
            if (st <= dr)
            {
                int m = (st + dr) / 2;
                if (v[m] == x)
                {
                    return true;
                }
                else if (x < v[m])
                {
                    return bs(v, st, m - 1, x);
                }
                else return bs(v, m + 1, dr, x);
            }
            else
            {
                return false;
            }
        }
    }
}
