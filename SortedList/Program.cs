using System;
using System.Collections.Generic;

namespace SortedList
{
     class Program
    {
        static void Main()
        {
            SortedList<int, string> employees = new SortedList<int, string>()
            {
                {101,"Scott"},
                {102,"Allen"},
                {103,"Smith"},
                {104,"Alice"},
                {105,"John"}

            };

            employees.Add(106, "Salony");
            employees.Remove(106);

            foreach(KeyValuePair<int,string> item in employees)
            {
                Console.WriteLine(item.Key + "," + item.Value);
            }

            string Name= employees[105];
            Console.WriteLine("\nEmployee name at 105:" + Name);

            bool Key = employees.ContainsKey(106);
            Console.WriteLine("\nEmployee exist:" + Key);

            bool Value = employees.ContainsValue("John");
            Console.WriteLine("\nEmployee exist:" + Value);

            Console.ReadKey();
        }
    }
}
