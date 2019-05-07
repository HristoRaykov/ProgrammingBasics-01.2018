using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SpecialCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundredsBorder = int.Parse(Console.ReadLine());
            int decadesBorder = int.Parse(Console.ReadLine());
            int unitsBorder = int.Parse(Console.ReadLine());

            for (int hundreds = 1; hundreds <= hundredsBorder; hundreds++)
            {
                if (hundreds%2==0)
                {
                    for (int decades = 1; decades <= decadesBorder; decades++)
                    {
                        if (decades==2 || decades==3 || decades==5 || decades==7)
                        {
                            for (int units = 1; units <= unitsBorder; units++)
                            {
                                if (units%2==0)
                                {
                                    Console.WriteLine($"{hundreds} {decades} {units}");
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
