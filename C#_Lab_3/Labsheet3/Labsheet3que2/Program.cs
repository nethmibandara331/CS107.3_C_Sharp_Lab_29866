using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet3que2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(101, "John Doe", 50000.00);
            
            Console.WriteLine("Employee information:");
            employee1.DisplayEmployeeInfo();

            Console.WriteLine($"Employee Id: {employee1.Id}");

            employee1.Name = "Jane Smith";
            Console.WriteLine($"Update Full Name: {employee1.Name}");

            employee1.Salary = 55000.00;
            Console.WriteLine($"Update Salary: {employee1.Salary}");
            Console.ReadLine();
        }
    }

    internal class Employee
    {
        public int Id;
        public string Name;
        public double Salary;

        public Employee(int Id,string Name,double Salary) 
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
        }

        public int EmployeeId => Id;//Read only property for Id.It provides access to the property

        public string FullName//Update the full name of the employee using the read-write property
        {
            get => Name;//the get accessor return the value of the FullName
            set=>Name = value;//and the set accessor sets the value of fullname
        }

        public double EmployeeSalary
        {
            get=>Salary;
            set=>Salary = value;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee Id: {Id}");
            Console.WriteLine($"Full Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
        }


    }
}
