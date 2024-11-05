using System;
using System.Collections.Generic;

namespace Inheritance
{
    internal class Program
    {
        static void Main()
        {
            PersonCollege person = new PersonCollege("Иван", 20);
            Console.WriteLine(person.GetName());
            person.MovePersonToCollege();
            person.SetCost(0.0);


            Professor pr = new Professor("Александр", 24, Lesson.Math);
            Console.WriteLine(pr.GetName());
            pr.MovePersonToCollege();
            pr.SetCost(25000.0);

            PersonCollege refStudent = new Student(22, "Василиcа");
            Console.WriteLine(refStudent.GetName());
            refStudent.MovePersonToCollege();
            refStudent.SetCost(5000.0);

            List<PersonCollege> persons = new List<PersonCollege>();
            persons.Add(person);
            persons.Add(refStudent);
            persons.Add(pr);

            PrintHappyDay(persons);

            Console.ReadKey();
        }

        static void PrintHappyDay(List<PersonCollege> p)
        {
            foreach (PersonCollege person in p) 
            {
                Console.WriteLine(person.GetName() 
                                  + ", age: " + person.GetAge()
                                  + ", bonus: " + person.GetBonus());
            }
        }
    }
}
