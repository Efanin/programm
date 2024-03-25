using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace programm
{
    static class Programm2
    {
        static public void main()
        {
            Random random = new Random();
            int num = 12144321;
            int num1 = num;
            Console.WriteLine(num);
            int num2 = 0;
            for (; num > 0;)
            {
                num2 *= 10;
                num2 += (num % 10);
                num /= 10;
            }
            Console.WriteLine(num1==num2?"palindrom":"not");
        }
    }
}
