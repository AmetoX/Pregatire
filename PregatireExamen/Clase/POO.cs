using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregatireExamen.Clase
{
    public class POO
    {
        public POO() { }









        #region pentru distrugerea obiectului
        public void garbage_colector() 
        {
            // se pun in functia main , cred
            // se pun in functia main , cred
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        ~POO() // se pune in clasa obiectului
        {
            Console.WriteLine("Dconstructor called");
        }
        #endregion
    }
}
