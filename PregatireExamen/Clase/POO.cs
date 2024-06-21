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
