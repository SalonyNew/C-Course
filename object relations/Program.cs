using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using College;

namespace object_relations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.RollNo = 1;
            student.StudentName = "Scott";
            student.Email = "scott@gmail.com";

            student.branch = new Branch();
            student.branch.BranchName = "CSE";
            student.branch.NoOfSemester = 8;

            Console.WriteLine(student.RollNo);
            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.Email);
            Console.WriteLine(student.branch.BranchName);
            Console.WriteLine(student.branch.NoOfSemester);

            Console.ReadKey();            
        }
    }
}
