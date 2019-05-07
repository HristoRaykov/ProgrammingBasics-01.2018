using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int ballsToPull = int.Parse(Console.ReadLine());            

            int totalPoints = 0;
            int redBallsPoints = 0;
            int orangeBallsPoints = 0;
            int yellowBallsPoints = 0;
            int whiteBallsPoints = 0;
            int otherColoursCount = 0;
            int blackBallsCount = 0;

            for (int i = 1; i <= ballsToPull; i++)
            {
                string colour = Console.ReadLine();
                switch (colour)
                {
                    case "red":
                        totalPoints += 5;
                        redBallsPoints++;
                        break;
                    case "orange":
                        totalPoints += 10;
                        orangeBallsPoints++;
                        break;
                    case "yellow":
                        totalPoints += 15;
                        yellowBallsPoints++;
                        break;
                    case "white":
                        totalPoints += 20;
                        whiteBallsPoints++;
                        break;
                    case "black":
                        totalPoints /= 2;
                        blackBallsCount++;
                        break;
                    default:
                        otherColoursCount++;
                        break;
                }
            }

            Console.WriteLine($"Total points: {totalPoints}\n" +
                $"Points from red balls: {redBallsPoints}\n" +
                $"Points from orange balls: {orangeBallsPoints}\n" +
                $"Points from yellow balls: {yellowBallsPoints}\n" +
                $"Points from white balls: {whiteBallsPoints}\n" +
                $"Other colors picked: {otherColoursCount}\n" +
                $"Divides from black balls: {blackBallsCount}\n");
        }
    }
}
