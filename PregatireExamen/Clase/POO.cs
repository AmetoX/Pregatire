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
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        ~POO() // se pune in clasa obiectului
        {
            Console.WriteLine("Deconstructor called for the POO object");
        }
        #endregion
    }

    /// <summary>
    /// supraincarcarea operatorilor
    /// </summary>
    public class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Supraincărcarea operatorului +
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }

    /// <summary>
    /// supraincarcarea metodelor
    /// </summary>
    public class Calculator
    {
        // Metodă pentru adunarea a doi întregi
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Supraincărcarea metodei pentru adunarea a trei întregi
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Supraincărcarea metodei pentru adunarea a doi numere în virgulă mobilă
        public double Add(double a, double b)
        {
            return a + b;
        }
    }


    /// <summary>
    /// încapsulare, moștenire și polimorfism prin funcții virtuale.
    /// </summary>
    public abstract class Animal
    {
        // Încapsulare: Membrii privați
        private string name;
        private int age;

        // Proprietăți publice pentru acces la membrii privați
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Constructor
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Funcție virtuală sau poate fi si abstraca-> nu mai defin nimic in interiorul ei
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    // Clasa derivată (moștenire)
    public class Dog : Animal
    {
        // Constructor
        public Dog(string name, int age) : base(name, age)
        {
        }

        // Suprascrierea funcției virtuale
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    // Clasa derivată (moștenire)
    public class Cat : Animal
    {
        // Constructor
        public Cat(string name, int age) : base(name, age)
        {
        }

        // Suprascrierea funcției virtuale
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows.");
        }
    }
}
