using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Q
    {
        int a, b;
        public Q(int a, int b)
        {
            this.a = a; this.b = b;
        }
        public Q() { }

        public override string ToString()
        {
            return a + "/" + b;
        }
        // A(a/b) + B(a/b)
        public static Q operator +(Q A, Q B)
        {
            Q toR = new Q(); 
            toR.a = A.a * B.b + B.a * A.b;
            toR.b = A.b * B.b;
            toR.ired();
            return toR;
        }
        public Q ired()
        {
            int t = MyMath.cmmdc(a, b);
            Q toR = new Q();
            toR.a = a / t;
            toR.b = b/ t;
            return toR;
        }

        //public static bool operator ==(Q A , Q B)//trebuie sa facem si opusul !=
        //{
        //    return (A.a == B.a && A.b == B.b);
        //}
    }
}
