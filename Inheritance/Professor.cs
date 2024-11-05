using System;

namespace Inheritance
{
    public enum  Lesson
    {
        Math = 0,
        Russian,
        English
    }
    public class Professor : PersonCollege
    {
        private Lesson lesson_;
        public Professor(string n, int a, Lesson l) : base(n, a)
        {
            lesson_ = l;
        }

        public new void MovePersonToCollege() /// переопределение метода базового класса
        {
            Console.WriteLine("               " + name_ + ", " + LessonToString(lesson_));
        }

        public static string LessonToString(Lesson l)
        {
            switch (l)
            {
                case Lesson.Math:
                    return "Математика";

                case Lesson.Russian:
                    return "Русский язык";

                case Lesson.English:
                    return "Английский язык";
            }

            return "Неизвестно";
        }

        public override double GetBonus()
        {
            return 1.8 * cost_;
        }
    }
}
