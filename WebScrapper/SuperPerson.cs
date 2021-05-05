using System;
namespace WebScrapper
{
    public class SuperPerson : Person
    {
        public SuperPerson(string FirstName, string LastName) :
            base(FirstName, LastName)
        {

        }

        public void Fly()
        {
            Console.WriteLine("I, {0} am flying", this.FirstName);
        }
    }
}
