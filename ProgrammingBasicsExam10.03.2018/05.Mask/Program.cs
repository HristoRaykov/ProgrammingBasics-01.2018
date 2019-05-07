using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mask
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n-1; row++)
            {
                string str = new string(' ', n - 2 - row) + '/' + new string(' ', row) + "|  |" +
                    new string(' ', row) + '\\' + new string(' ', n - 2 - row);
                Console.WriteLine(str);
            }
            Console.WriteLine(new string('-',2*n+2));

            for (int row = 1; row <= n/2+5; row++)
            {
                if (row == 1)
                {
                    if (n%2==0)
                    {
                        string str = '|' + new string(' ', n / 2 - 1) + '_' + new string(' ', n) +
                        '_' + new string(' ', n / 2 - 1) + '|';
                        Console.WriteLine(str);
                    }
                    else
                    {
                        string str = '|' + new string(' ', n / 2 - 1) + '_' + new string(' ', n+1) +
                                                '_' + new string(' ', n / 2 - 1) + '|';
                        Console.WriteLine(str);
                    }
                    
                }
                else if (row==2)
                {
                    if (n%2==0)
                    {
                        string str = '|' + new string(' ', n / 2 - 1) + '@' + new string(' ', n) +
                        '@' + new string(' ', n / 2 - 1) + '|';
                        Console.WriteLine(str);
                    }
                    else
                    {
                        string str = '|' + new string(' ', n / 2 - 1) + '@' + new string(' ', n+1) +
                        '@' + new string(' ', n / 2 - 1) + '|';
                        Console.WriteLine(str);
                    }
                    
                }
                else if (row == n/2+3)
                {
                    string str = '|' + new string(' ', n - 1) + "OO" + new string(' ', n - 1) +
                        '|';
                    Console.WriteLine(str);
                }
                else if (row == n / 2 + 4)
                {
                    string str = '|' + new string(' ', n - 2) + "/  \\" + new string(' ', n - 2) + '|';
                    Console.WriteLine(str);
                }
                else if (row == n / 2 + 5)
                {
                    string str = '|' + new string(' ', n - 2) + "||||" + new string(' ', n - 2) + '|';
                    Console.WriteLine(str);
                }
                else
                {
                    string str = '|' + new string(' ', 2*n) + '|';
                    Console.WriteLine(str);
                }
            }

            for (int row = 1; row <= n + 1; row++)
            {
                string str = new string('\\',row) + new string('`', 2 * (n + 1 -row)) + new string('/', row);
                Console.WriteLine(str);
            }

        }
    }
}
