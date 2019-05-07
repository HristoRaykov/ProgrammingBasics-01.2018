using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasicsExam10._03._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanceAB = double.Parse(Console.ReadLine());
            double truckSpeed = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double carSpeed = truckSpeed + y * 18 / 5;

            double truckTime = Math.Ceiling(distanceAB / truckSpeed);
            double carTime = Math.Ceiling(distanceAB / carSpeed);

            Console.WriteLine($"The truck arrived after {truckTime} hours");
            Console.WriteLine($"The car arrived after {carTime} hours");
        }
    }
}
