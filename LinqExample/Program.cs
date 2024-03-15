using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
    }
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){EmpID= 101,EmpName= "Harry",Job="Designer",Salary= 1000},
                new Employee(){EmpID= 102,EmpName= "Scott",Job="Developer",Salary= 1200},
                new Employee(){EmpID= 103,EmpName= "Alexa",Job="Analyst",Salary= 1300},
                new Employee(){EmpID= 104,EmpName= "William",Job="Manager",Salary= 1300},
                new Employee(){EmpID= 105,EmpName= "Jack",Job="Manager",Salary= 1400}
            };

            //IOrderedEnumerable<Employee>sortedEmployees=employees.OrderBy(emp => emp.Job).ThenBy(emp=>emp.EmpName);
            //foreach(Employee item in sortedEmployees)
            //{
            //    Console.WriteLine(item.EmpID+","+item.EmpName+","+item.Job+","+item.Salary);
            //}

            List<Employee> filteredEmployees = employees.Where(emp => emp.Job == "Manager").ToList();
            Console.WriteLine(filteredEmployees[0].EmpID + "," + filteredEmployees[0].EmpID);

            Employee firstManager = employees.First(emp => emp.Job == "Manager");
            Console.WriteLine(firstManager.EmpID+","+ firstManager.EmpName);

            Employee firstManager2 = employees.FirstOrDefault(emp => emp.Job == "Clerk");
            if(firstManager2!= null)
            {
                Console.WriteLine(firstManager2.EmpID + "," + firstManager2.EmpName);
            }
            else
            {
                Console.WriteLine("No clerk found");
            }

            Employee lastEmployee= employees.Last(emp => emp.Job == "Manager");
            Console.WriteLine(lastEmployee.EmpID+","+ lastEmployee.EmpName+","+lastEmployee.Job);

            Employee lastEmployee1 = employees.LastOrDefault(emp => emp.Job == "Clerk");
            if (lastEmployee1 != null)
            {
                Console.WriteLine(lastEmployee.EmpID + "," + lastEmployee.EmpName + "," + lastEmployee.Job);
            }
            else
            {
                Console.WriteLine("No Clerk found");
            }

            Employee ResultEmp = employees.Where(emp => emp.Job == "Manager").ElementAt(0);
            Console.WriteLine(ResultEmp.EmpID + "," + ResultEmp.EmpName + "," + ResultEmp.Job);

            Employee ResultEmp2 = employees.Where(emp => emp.Job == "Manager").ElementAtOrDefault(3);
            if (ResultEmp2 != null)
            {
                Console.WriteLine(ResultEmp2.EmpID + "," + ResultEmp2.EmpName + "," + ResultEmp2.Job);
            }
            else
            {
                Console.WriteLine("No element found");
            }

            Employee Firstelem = employees.Single(emp => emp.Job == "Manager");
            Console.WriteLine (Firstelem.EmpID + "," + Firstelem.EmpName + "," + Firstelem.Job);
            Console.ReadKey();
        }
    }
}
