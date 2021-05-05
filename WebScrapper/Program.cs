using System;

namespace WebScrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Josh";
            person.LastName = "Gulledge";

            Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
            Console.WriteLine(person.HasDocuments);

            person.FirstName = "";
            Console.WriteLine(person.FirstName);
        }
    }
}
