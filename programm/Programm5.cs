using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm
{
    static class Programm5
    {
        static public void main()
        {
            int x = 10;
            for(int i = x-1;i!=2;i--)
            {
                float d = (float)x / (float)i;
                d *= 10;
                if (d % 10 == 0)
                {
                    
                    Console.WriteLine("dont simple");
                    return;
                }
            }
            Console.WriteLine("simple");
        }
    }
}
