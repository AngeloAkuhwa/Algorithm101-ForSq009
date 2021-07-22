using System;
using System.Collections.Generic;

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

    public class PartTimeEmployee:Employee
    {
        public float HourlySalary;
        public override string GetFullName()
        {
            return FirstName + LastName + "PartTimeEmployee";
        }
    }
    public class FullTimeEmployee:Employee
    {
   
        public float MonthlySalary;
        public override string GetFullName()
        {
            return FirstName + LastName + "FullTime Employee";
        }

    }
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Emailb { get; set; }
        public Address Address { get; set; }
        public abstract string GetFullName();
        
    }

    public class Address
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public Employee Employee { get; set; }
        public string City { get; set; }
        public string Town  { get; set; }
        public string State  { get; set; }
    }
}
