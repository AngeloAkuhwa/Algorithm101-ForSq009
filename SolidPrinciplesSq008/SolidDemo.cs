using System;

namespace SolidPrinciplesSq008
{
    //solid principles
    //Single responsibility principle (SRP)
    //open and close
    //liskov substitution LSK
    //interface segregation ISP
    //depency inversion DI
    public class SolidDemo
    {

    }
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string GetFullName()
        {
            return FirstName + LastName;
        }
    }

    public class TempEmp:Employee
    {
        //public new string GetFullName()
        //{
        //    return FirstName + LastName  + "Temp";
        //}
        //code
    }
}
