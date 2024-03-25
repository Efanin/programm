using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm.LinQ
{
    static class Arr7
    {
        public static void main()
        {
            double count = 0;
            for (int i = 0; i < 100; i++)
            {
                count += chance(250);
            }
            (count / 100).Print();
        }
        static double chance(int count)
        {
            for (int i = 0; ; i++)
            {
                int[][] arr = new int[count][]
                    .Select(x => new int[] { new Random().Next(365), new Random().Next(365) }).ToArray();



                foreach (var item in arr)
                {
                    if (item[0] == item[1])
                    {
                        if (i == 0)
                        {
                            return 1.0;
                        }
                        else
                        {
                            return 1.0 / (double)i;
                        }
                    }
                }


            }
            return 1.0;
        }
    }
}
