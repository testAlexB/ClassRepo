namespace Inheritance
{
    public class PersonCollege
    {
        protected string name_;
        protected int age_;

        public PersonCollege(string n, int a)
        {
            name_ = n; 
            age_ = a;    
        }

        public string GetName()
        { 
            return name_;
        }
    }
}
