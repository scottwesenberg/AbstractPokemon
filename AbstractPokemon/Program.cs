using System;

namespace Pokemon
{
    // Abstract class
    abstract class Pokemon
    {
        // Properties
        public abstract string Name { get; set; }
        public abstract string Type { get; set; }

        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am a pokemon\n";
        }
    }

    // Derived class
    class Mew : Pokemon
    {
        // Override properties
        public override string Name { get; set; }
        public override string Type { get; set; }

        public Mew()
        {
            Name = string.Empty;
            Type = string.Empty;
        }

        public Mew(string name, string type)
        {
            Name = name;
            Type = type;
        }

        // Override method
        public override string Describe()
        {
            return "I am a(n) " + Type + " type.\nMy name is " + Name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create Mew object
            Mew mew = new Mew("Mew", "Psychic");

            // Display information
            Console.WriteLine(mew.whatAmI());
            Console.WriteLine(mew.Describe());
        }
    }
}