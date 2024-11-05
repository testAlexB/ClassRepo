using System;

namespace Inheritance
{
    public class Student  : PersonCollege
    {
        public Student(int age, string name) : base(name, age)
        {
            name_ = "Студент: " + name_;
        }

        public new void MovePersonToCollege() /// переопределение метода базового класса
        {
            Console.WriteLine("Поехал в колледж " + name_);
        }
    }
}
