using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregatireExamen.Clase
{
    internal class Stack
    {
        int[] val;
        public Stack() { val = new int[0]; }
        public void Push(int v)
        {
            int[] t = new int[val.Length + 1];
            for (int i = 0; i < val.Length; i++) { t[i + 1] = val[i]; }
            t[0] = v;
            val = t;
        }
        public int Pop()//scot primul element introdus(ultimul element din vector) [queue]
        {
            int tor = val[val.Length - 1];
            int[] t = new int[val.Length - 1];
            for (int i = 0; i < val.Length - 1; i++) { t[i] = val[i]; }
            val = t;
            return tor;
        }
        public int Pop2()//scot ultimul element introdus(primul element din vector) [stack]
        {
            int tor = val[0];
            int[] t = new int[val.Length - 1];
            for (int i = 0; i < val.Length - 1; i++) { t[i] = val[i + 1]; }
            val = t;
            return tor;
        }
        public void Pop3(int v)//scot elemente de pe o pozitie anume
        {
            int[] t = new int[val.Length - 1];
            for (int i = 0; i < val.Length - 1; i++)
            {
                if (i >= v)
                {
                    int aux = val[i];
                    val[i] = val[i + 1];
                    val[i + 1] = aux;
                    t[i] = val[i];
                }
                else
                    t[i] = val[i];
            }
            val = t;
        }

        }
        public bool IsEmpty()
        {
            if (val.Length < 1)
                return true;
            return false;
        }
        public void View()
        {
            for (int i = 0; i < val.Length; i++) { Console.Write(val[i] + " "); }
            Console.WriteLine();
        }
    }
}
