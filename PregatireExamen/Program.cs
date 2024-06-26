using Microsoft.SqlServer.Server;
using PregatireExamen.Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
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
            //Algoritmi
            //srt.print();
            //srt.BubbleSort();
            //srt.MergeSortRun(); asta se poate aplica si la divide and conquer
            //srt.SelectionSort();
            //srt.QuickSOrtRun();          
            //srt.InsertionSort();
            //srt.print();
            //bk produs cartezian
            //bk permutari
            //bk aranjamente
            //bk combinari
            //bk cu caractere
            //bk patrat perfec

            //POO
            //aplicatia -> operatii cu matrice
            //date
            //time
            //stack
            //queue

            // Încapsulare: Crearea instanțelor
            //Animal myDog = new Dog("Buddy", 3);
            //Animal myCat = new Cat("Whiskers", 2);

            // Polimorfism: Apelarea funcțiilor virtuale
            //myDog.MakeSound(); // Output: Dog barks.
            //myCat.MakeSound(); // Output: Cat meows.

            //supraincarcarea metodelor
            //Calculator calc = new Calculator();
            //Console.WriteLine(calc.Add(2, 3));       // Output: 5
            //Console.WriteLine(calc.Add(2, 3, 4));    // Output: 9
            //Console.WriteLine(calc.Add(2.5, 3.5));   // Output: 6.0

            //supraincarcarea operatorilor
            //Complex c1 = new Complex(1.0, 2.0);
            //Complex c2 = new Complex(3.0, 4.0);
            //Complex result = c1 + c2;
            //Console.WriteLine(result);  // Output: 4.0 + 6.0i

            //Time time = new Time();
            //Console.WriteLine(time.ToString());
            //Time time1 = new Time(14, 10, 12);
            //Time time2 = new Time(13, 20, 10);
            //Time time3 = time1 + time2;
            //Console.WriteLine(time3.ToString());

            //Fractie frac1 = new Fractie(1, 2);
            //Fractie frac2 = new Fractie(3, 4);

            //Fractie sum = frac1 + frac2;
            //Fractie difference = frac1 - frac2;
            //Fractie product = frac1 * frac2;
            //Fractie quotient = frac1 / frac2;

            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Difference: {difference}");
            //Console.WriteLine($"Product: {product}");
            //Console.WriteLine($"Quotient: {quotient}");
        }
    }

}
