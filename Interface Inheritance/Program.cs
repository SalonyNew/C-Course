class Program
{
    static void Main()
    {
        Employee emp1 = new Employee(101,"Alice","Pune");
        System.Console.WriteLine(emp1._empID);
        System.Console.WriteLine(emp1._empName);
        System.Console.WriteLine(emp1._location);

        Manager man1 = new Manager(102, "Scott", "Mumbai", "CSE");
        System.Console.WriteLine(man1._empID);
        System.Console.WriteLine(man1._empName);
        System.Console.WriteLine(man1._location);
        System.Console.WriteLine(man1._departmentName);

        SalesMan man2 = new SalesMan(103, "Shaggy", "Indore","MadhyaPradesh");
        System.Console.WriteLine(man2._empID);
        System.Console.WriteLine(man2._empName);
        System.Console.WriteLine(man2._location);
        System.Console.WriteLine(man2._region);
        System.Console.ReadKey();

    }
}