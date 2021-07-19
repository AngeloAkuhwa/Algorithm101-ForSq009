using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using static CSharpDelegates.Employee;
using static CSharpDelegates.EmployeeLogic;
using System.Linq;

namespace CSharpDelegates
{
    public class MyDelegateDemo
    {
        // lamda expression,
        //action,
        //func and 
        //prdeicate

        public delegate double calAreaPointer(int r);
        public delegate double calAreaPoint(int r , int t);
        public delegate void DisplayStringMessage(string myMessage);
        public DisplayStringMessage messageWiter = new DisplayStringMessage(Hello);
        public calAreaPointer areaCalculator = CalculateArea;
        

        public static double CalculateArea(int r)
        {
            return 3.14 * r * r;
        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
        public double AnonymousMethod()
        {
            
            calAreaPointer calArea = new calAreaPointer(delegate (int r)
            {
                return 3.14 * r * r;
            });

            double area = calArea(1);
            return area;
        }
        public double UsingLamdaExpressions()
        {
            calAreaPoint cpointer =( r,t) => 3.14 * r * t;
           return cpointer(20,10);
        }

        //using lamda and func
        public double UsingGenericDelegates()
        {
            Func<double,double> cpointer = (r) => 3.14 * r;
            return cpointer(20);
        }

        public void GenericDelegateWithoutReturnType()
        {
            Action<string> cpointer = (myName) => Console.WriteLine(myName); 
            cpointer("my name is Angelo");
        }

        public bool PredicateDelegate()
        {
           Predicate<string> checkLength = myName=> myName.Length > 4;

           return checkLength("my name is Angelo");
        }

        public int CalculatingUsingExpressionTree()
        {
            BinaryExpression b1 = Expression.MakeBinary(ExpressionType.Add, Expression.Constant(10), Expression.Constant(20));
            BinaryExpression b2 = Expression.MakeBinary(ExpressionType.Add, Expression.Constant(3), Expression.Constant(5));
            BinaryExpression b3 = Expression.MakeBinary(ExpressionType.Subtract, b1, b2);
            int result = Expression.Lambda<Func<int>>(b3).Compile()();

            return result;
        }


    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }

        public delegate bool IsPromotable(Employee employee);
        public void PromoteEmployee(List<Employee> employees, IsPromotable isEligibleToPromote)
        {
            foreach (Employee employee in employees)
            {
                if (isEligibleToPromote(employee))
                {
                    Console.WriteLine($"{employee.Name} has been promoted");
                }
            }
        }

        public string this[int empId]
        {
            get { return listEmployees.FirstOrDefault(x => x.Id == empId).Name; }
            set { listEmployees.FirstOrDefault(x => x.Id == empId).Name = value; }
        }
    }
    public static class EmployeeLogic
    {
        public static List<Employee> listEmployees = new List<Employee>
        {
            new Employee{Id = 1, Name = "John", Experience = 5},
            new Employee{Id = 2, Name = "Angelo", Experience = 2},
            new Employee{Id = 3, Name = "Mary", Experience = 4},
            new Employee{Id = 4, Name = "Magdalene", Experience = 8},
            new Employee{Id = 5, Name = "Joseph", Experience = 7}
        };

        

        static IsPromotable employeeToPromote = new IsPromotable(Promote);
        public static bool Promote(Employee emp)
        {
            return emp.Experience > 5;
        }

       //public void EmployeeToPeomote()
       // {
       //     Employee emp = new Employee();
       //     emp.PromoteEmployee(listEmployees, employeeToPromote);
       // }
           
    }
}
