using PregatireExamen.Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregatireExamen
{
    internal class Program
    {
        static AlgoritmiSortare srt =  new AlgoritmiSortare();
        static POO obj = new POO();
        static void Main(string[] args)
        {
        //Algoritmi de sortare
            srt.print();
            //srt.BubbleSort();
            //srt.MergeSortRun();
            //srt.SelectionSort();
            //srt.QuickSOrtRun();          
            //srt.InsertionSort();
            //srt.print();

            //POO
            //operatii cu matrice
            // Încapsulare: Crearea instanțelor
            Animal myDog = new Dog("Buddy", 3);
            Animal myCat = new Cat("Whiskers", 2);

            // Polimorfism: Apelarea funcțiilor virtuale
            myDog.MakeSound(); // Output: Dog barks.
            myCat.MakeSound(); // Output: Cat meows.

        }
    }
}
