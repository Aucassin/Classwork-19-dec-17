using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods__Recursion_part_1
{
    class Program
    {
        static void Calc(int first, int second, char sign, string s)
        {
            Console.WriteLine(s);
        }

        static void Calc(int first, int second, char sign)
        {
            switch (sign)
            {
                case '+':
                    Console.WriteLine(first + second);
                    break;
                case '-':
                    Console.WriteLine(first - second);
                    break;
                case '*':
                    Console.WriteLine(first * second);
                    break;
                case '/':
                    {
                        if (second == 0)
                        {
                            Console.WriteLine("ERROR");
                            break;
                        }
                        Console.WriteLine(first / second);
                        break;
                    }
                default:
                    Console.WriteLine("Polnaya Hren'");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Calc(12,3,'/');
        }
    }
}
