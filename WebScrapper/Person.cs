using System;
namespace WebScrapper
{
    public class Person
    {
        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // constructor method
        public Person (string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public void Walk()
        {
            Console.WriteLine("I, {0} am walking.", this.FirstName);
        }

        public void Eat()
        {
            Console.WriteLine("I, {0} am eating", this.FirstName);
        }

        public void Sleep()
        {
            Console.WriteLine("I, {0} am sleeping", this.FirstName);
        }
    }
}
