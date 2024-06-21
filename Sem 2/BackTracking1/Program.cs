using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTracking1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //produs cartezian; interval [1,5] la putera a 5a
            int n = 5; 
            int p = 3;
            int[] s = new int[n];
            bool[] b = new bool[n];

            //PK(0, n, s);
            //Permutari(0, n, s, b);
            //Aranjamente(0, n, p, s, b);

            //s[0] = 0;
            //Combinari(1, n, p, s);
        }

        public static void PK(int k, int n, int[] sol)
        {
            if (k >= n)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(sol[i] + " ");                  
                }
                Console.WriteLine();
            }
            else
            {//generator de permutari
                for (int i = 0; i <= 5; i++)
                {
                    sol[k] = i + 1;
                    PK(k + 1, n, sol);
                }
            }
        }
        
        public static void Permutari(int k, int n, int[] s, bool[] b)
        {
            if(k>= n)           
            {
                for(int i = 0; i < n; i++)
                {
                    Console.Write(s[i]+" ");
                }
                Console.WriteLine();
            }
            else
            {//generator de permutari
                for (int i = 0; i < n; i++)
                {
                    if (!b[i])
                    {
                        s[k] = i + 1; b[i] = true;
                        Permutari(k+1, n, s, b);
                        b[i] = false;
                    }
                }
            }
        }

        public static void Aranjamente(int k, int n, int p, int[]s, bool[] b)
        {
            if (k >= p)
            {
                for (int i = 0; i < p; i++)
                {
                    Console.Write(s[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {//generator de permutari
                for (int i = 0; i < n; i++)
                {
                    if (!b[i])
                    {
                        s[k] = i + 1; b[i] = true;
                        Aranjamente(k + 1, n, p, s, b);
                        b[i] = false;
                    }
                }
            }
        }

        public static void Combinari(int k,int n, int p, int[] s)
        {
            if (k > p)
            {
                for (int i = 1; i <= p; i++)
                {
                    Console.Write(s[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {//generator de permutari
                for (int i = s[k-1]+1; i <= n; i++)
                {
                    s[k] = i;
                    Combinari(k + 1, n, p, s);
                }
            }
        }
    }
}
