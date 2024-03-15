using System;
public class Program
{
    public static void Main()
    {

        Customer C1 = new Customer(10,"abc","def");
       // C1.PrintFullName();
       // C1 = new Customer("ABC","PQR");
        //C1.PrintFullName();
    }
}

public class Customer
{
    int _id;
    string _firstName;
    string _lastName;

    public Customer(int id, string FirstName, string LastName)
    {
        this._id = id;
        this._firstName = FirstName;
        this._lastName = LastName;
        System.Console.WriteLine("First Constructor");
        System.Console.ReadKey();


    }

    public Customer(string FirstName, string LastName) : this(0, "abc", "def")
    {
        this._firstName = FirstName;
        this._lastName = LastName;
        System.Console.WriteLine("Second Constructor");
        System.Console.ReadKey();

    }

    //public void PrintFullName()
    //{
      //  Console.WriteLine("ID is "+ _id + " " + "Full Name is "+ _firstName + " " + _lastName);
        //System.Console.ReadKey();
    //}
    
}