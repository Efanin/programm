using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm
{
    static class Programm6
    {
        static public void main()
        {
            double e = 0;
            for (int i = 1; ;i++)
            {
                double f = 1.0;
                for(int j=1;j<i;j++)
                {
                    f *= j;
                }
                e += 1.0 / f;
                Console.WriteLine(e);
            }
        }
    }
}
