using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm
{
    static class Programm4
    {
        static public void main()
        {
            Random random = new Random();
            int num = random.Next(100);
            int x=-1;
            Console.WriteLine("Guess the number");
            while (num != x)
            {
                try { x = int.Parse(Console.ReadLine()); }
                catch { continue; }
                Console.WriteLine(num>x?"biggest":"smalled");
            }
            Console.WriteLine("nice");
        }
    }
}
