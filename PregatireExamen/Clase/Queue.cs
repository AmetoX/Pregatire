using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregatireExamen.Clase
{
    public class TriData
    {
        public int l, c, v;

        public TriData(int l, int c, int v)
        {
            this.l = l;
            this.c = c;
            this.v = v;
        }
        public string View()
        {
            return "(" + l + " " + c + " " + v + ")";
        }
    }
    internal class Queue
    {
        TriData[] v;

        public Queue()
        {
            v = new TriData[0];
        }
        public void Push(TriData x)
        {
            TriData[] t = new TriData[v.Length + 1];
            for (int i = 0; i < v.Length; i++) { t[i + 1] = v[i]; }
            t[0] = x;
            v = t;
        }
        public TriData Pop()
        {
            TriData tor = v[v.Length - 1];
            TriData[] t = new TriData[v.Length - 1];
            for (int i = 0; i < v.Length - 1; i++) { t[i] = v[i]; }
            v = t;
            return tor;
        }
        public string view()
        {
            string t = "";
            for (int i = 0; i < v.Length; i++)
            {
                t += v[i].View();
            }
            return t;
        }

        public bool IsEmpty()
        {
            if (v.Length < 1)
                return true;
            return false;
        }
    }
}
