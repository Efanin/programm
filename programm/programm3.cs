using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace programm
{
    static class Programm3
    {
        static public void main()
        {
            double pi=4;
            for (long i =3; true;i+=4)
            {
                //Thread.Sleep(10);
                //Console.Clear();
                pi -= 4.0 / i;
                pi += 4.0 / (i+2);
                if(i%((1000000*4)+3)==0)
                    Console.WriteLine(pi);
            }

        }
    }
}
