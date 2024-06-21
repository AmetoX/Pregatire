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
            //aplicatia -> operatii cu matrice

            // Încapsulare: Crearea instanțelor
            Animal myDog = new Dog("Buddy", 3);
            Animal myCat = new Cat("Whiskers", 2);

            // Polimorfism: Apelarea funcțiilor virtuale
            myDog.MakeSound(); // Output: Dog barks.
            myCat.MakeSound(); // Output: Cat meows.

            //supraincarcarea metodelor
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(2, 3));       // Output: 5
            Console.WriteLine(calc.Add(2, 3, 4));    // Output: 9
            Console.WriteLine(calc.Add(2.5, 3.5));   // Output: 6.0

            //supraincarcarea operatorilor
            Complex c1 = new Complex(1.0, 2.0);
            Complex c2 = new Complex(3.0, 4.0);
            Complex result = c1 + c2;
            Console.WriteLine(result);  // Output: 4.0 + 6.0i

        }
    }
}
