using System;

namespace Inheritance
{
    public class PersonCollege
    {
        protected string name_;
        protected int age_;
        protected double cost_;

        public PersonCollege(string n, int a)
        {
            name_ = n; 
            age_ = a;    
        }

        public string GetName()
        { 
            return name_;
        }

        public int GetAge()
        {
            return age_; 
        }    

        public void SetCost(double cost)
        {
            cost_ = cost;
        }

        public void MovePersonToCollege()
        {
            Console.WriteLine("               " + name_);
        }

        public virtual double GetBonus()
        {
            return cost_;
        }
    }
}
