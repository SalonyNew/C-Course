using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__course
{
    public class Area
    {
        public static void Calculate()
        {
            double radius = 5;
            double areaCircle = double.Pi * radius * radius;

            Console.WriteLine("Area of circle: "+ areaCircle);
        }
    }
}
