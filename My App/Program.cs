// See https://aka.ms/new-console-template for more information
//using My_App;

//Console.WriteLine("Hello, World!");

class Demo
{
    static void Main()
    {
        Employee Emp1, Emp2, Emp3, Emp4, Emp5, Emp6, Emp7, Emp8, Emp9, Emp10;

        Emp1 = new Employee();
        Emp2 = new Employee();
        Emp3 = new Employee();
        Emp4 = new Employee();
        Emp5 = new Employee();
        Emp6 = new Employee();
        Emp7 = new Employee();
        Emp8 = new Employee();
        Emp9 = new Employee();
        Emp10 = new Employee();

        Emp1.Name = "ABC";
        Emp1.EmployeeID = 101;
        Emp1.Salary = 1000;
        Emp1.Track = ".NET";

        Emp2.Name = "DEF";
        Emp2.EmployeeID = 102;
        Emp2.Salary = 1200;
        Emp2.Track = "GOLANG";

        Emp3.Name = "GHI";
        Emp3.EmployeeID = 103;
        Emp3.Salary = 1400;
        Emp3.Track = ".NET";

        Emp4.Name = "HYU";
        Emp4.EmployeeID = 104;
        Emp4.Salary = 1000;
        Emp4.Track = "DEVOPS";


        Emp5.Name = "DFG";
        Emp5.EmployeeID = 105;
        Emp5.Salary = 1090;
        Emp5.Track = "NODEJS";

        Emp6.Name = "GTH";
        Emp6.EmployeeID = 106;
        Emp6.Salary = 2200;
        Emp6.Track = ".NET";

        Emp7.Name = "KIL";
        Emp7.EmployeeID = 107;
        Emp7.Salary = 9000;
        Emp7.Track = "DATASCIENCE";

        Emp8.Name = "DRF";
        Emp8.EmployeeID = 108;
        Emp8.Salary = 1000;
        Emp8.Track = ".NET";

        Emp9.Name = "ERT";
        Emp9.EmployeeID = 109;
        Emp9.Salary = 5000;
        Emp9.Track = "ANGULAR";

        Emp10.Name = "TGH";
        Emp10.EmployeeID = 1010;
        Emp10.Salary = 1000;
        Emp10.Track = ".NET";


        System.Console.WriteLine("*___Employee1 Details___*");
        System.Console.WriteLine("Name" + Emp1.Name);
        System.Console.WriteLine("EmployeeID" + Emp1.EmployeeID);
        System.Console.WriteLine("Salary" + Emp1.Salary);
        System.Console.WriteLine("Track" + Emp1.Track);

        System.Console.ReadKey();

    }

}




