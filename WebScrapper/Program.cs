using System;

namespace WebScrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Josh", "Gulledge");

            person1.Sleep();

            SuperPerson person2 = new SuperPerson("Clark", "Kent");
            person2.Sleep();
            person2.Fly();
        }
    }
}
