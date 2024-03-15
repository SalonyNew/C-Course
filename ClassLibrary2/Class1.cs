using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Sample: System.IDisposable
    {
        public Sample()
        {
            Console.WriteLine("Database Connected");
        }

        public void DisplayDataFromDatabase()
        {
            Console.WriteLine("Reading data from database");
        }

        //Dispose
        public void Dispose()
        {
            Console.WriteLine("Database Disconnected");
        }
    }
}
