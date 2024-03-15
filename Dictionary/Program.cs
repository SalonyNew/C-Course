using System;
using System.Collections.Generic;
using System.Runtime.Remoting;


namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            Customr customr1 = new Customr()
            {
                ID = 101,
                Name = "Scott",
                Salary = 1000
            };
            Customr customr2 = new Customr()
            {
                ID = 102,
                Name = "Sky",
                Salary = 11000
            };
            Customr customr3 = new Customr()
            {
                ID = 103,
                Name = "Alice",
                Salary = 12000
            };

            Dictionary<int, Customr> dictionaryCustomr = new Dictionary<int, Customr>();
            dictionaryCustomr.Add(customr1.ID, customr1);
            dictionaryCustomr.Add(customr2.ID, customr2);
            dictionaryCustomr.Add(customr3.ID, customr3);

            Customr customr101 = dictionaryCustomr[103];
            foreach (KeyValuePair<int,Customr> kvp in dictionaryCustomr)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Customr cust = kvp.Value;
                Console.WriteLine("ID ={0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine();
                Console.ReadKey();

            }
        }
    }

    public class Customr
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }

}
