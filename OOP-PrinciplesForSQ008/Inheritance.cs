using System;

namespace OOP_PrinciplesForSQ008
{
    public class Inheritance
    {
        //public Inheritance()//:this("call parent class constructor with arguments")
        //{
        //    Console.WriteLine("parent class called");
        //}
        //public Inheritance(string message)
        //{
        //    Console.WriteLine(message);
        //}
    }
    public class ChildClass:Inheritance
    {
        //public ChildClass():base("my name is angelo")
        //{
        //    Console.WriteLine("child class called");
        //}
    }

    public class PartTimeEmployee
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public float HourlySalary;

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
    public class FullTimeEmployee
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public float HourlySalary;

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
