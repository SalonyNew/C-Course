using System;

public class Employee
{
    public int _empID;
    public string _empName;
    public string _location;

    public Employee(int empID, string empName, string location)
    {
        this._empID = empID;
        this._empName = empName;
        this._location = location;
    }


}
public class Manager: Employee
{
    public string _departmentName;
    public Manager(int empID, string empName, string locaton, string departmentName):base(empID, empName, locaton) 
    {
        this._departmentName = departmentName;
    }
}

public class SalesMan: Employee
{
    public string _region;

    public SalesMan(int empID, string empName, string location,string region ): base(empID, empName, location)
    {
        this._region = region;
    }
}