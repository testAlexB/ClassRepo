using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main()
        {
            PersonCollege person = new PersonCollege("Иван", 20);
            Console.WriteLine(person.GetName());
            person.MovePersonToCollege();
            Console.ReadKey();
        }
    }
}
