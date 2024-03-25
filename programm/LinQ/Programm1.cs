using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm.LinQ
{
    static class Programm1
    {
        static public void main()
        {
            Random random = new Random();
            int num = random.Next(9999999);
            Console.WriteLine(num);
            int num2 = 0;
            for (int i = 1; num > 0; i *= 10)
            {
                num2 += (num % 10 + 3) % 10 * i;
                num /= 10;
            }
            Console.WriteLine(num2);

        }
    }
}
