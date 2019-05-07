using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ArenaTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            string arenaName = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            string condition = Console.ReadLine();

            double totalObjectPrice = 0;

            switch (condition)
            {
                case "Poor":
                    totalObjectPrice = 7000;
                    break;
                case "Normal":
                    totalObjectPrice = 14000;
                    break;
                case "Legendary":
                    totalObjectPrice = 21000;
                    break;
            }

            switch (arenaName)
            {
                case "Nagrand":
                    if (dayOfWeek == "Monday" || dayOfWeek == "Wednesday")
                    {
                        totalObjectPrice *= 0.95;
                    }
                    break;
                case "Gurubashi":
                    if (dayOfWeek == "Tuesday" || dayOfWeek == "Thursday")
                    {
                        totalObjectPrice *= 0.90;
                    }
                    break;
                case "Dire Maul":
                    if (dayOfWeek == "Friday" || dayOfWeek == "Saturday")
                    {
                        totalObjectPrice *= 0.93;
                    }
                    break;
            }

            double pricePerObject = totalObjectPrice / 5;
            
            int counter = 0;
           
            while (counter<5)
            {
                points -= (int)pricePerObject;
                if (points >= 0)
                {
                    counter++;
                }
                else
                {
                    points += (int)pricePerObject;
                    break;
                }
            }

            if (counter == 5)
            {
                Console.WriteLine($"Items bought: {counter}");
                Console.WriteLine($"Arena points left: {points}");
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine($"Items bought: {counter}");
                Console.WriteLine($"Arena points left: {points}");
                Console.WriteLine("Failure!");
            }
        }
    }
}
