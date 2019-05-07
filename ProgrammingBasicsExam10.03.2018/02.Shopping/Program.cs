using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfChocos = int.Parse(Console.ReadLine());
            double litresOfMilk = double.Parse(Console.ReadLine());

            int numbersOfMandarin = (int)Math.Floor(numberOfChocos * 0.65);

            double totalExpences = numberOfChocos * 0.65 + litresOfMilk * 2.7 + numbersOfMandarin * 0.2;

            if (budget >= totalExpences)
            {
                double moneyLeft = budget - totalExpences;
                Console.WriteLine($"You got this, {moneyLeft:f2} money left!");
            }
            else
            {
                double moneyNeeded = totalExpences - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} more!");
            }


        }
    }
}
