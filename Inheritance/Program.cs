﻿using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main()
        {
            PersonCollege person = new PersonCollege("Иван", 20);
            Console.WriteLine(person.GetName());
            person.MovePersonToCollege();


            Professor pr = new Professor("Александр", 24, Lesson.Math);
            Console.WriteLine(pr.GetName());
            pr.MovePersonToCollege();

            Console.ReadKey();
        }
    }
}
