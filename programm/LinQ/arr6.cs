using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm.LinQ
{
    static class arr6
    {
        public static void main()
        {
            int[] arr = new int[3].Select(x => new Random().Next(100)).ToArray().Print();
            int[] up_order = arr.OrderBy(x => x).ToArray();
            int[] down_order = arr.OrderByDescending(x => x).ToArray();
            if (arr.SequenceEqual(up_order))
                "up".Print();
            else if (arr.SequenceEqual(down_order))
                "down".Print();
            else
                "none order".Print();
        }
    }
}
