using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm.LinQ
{
    static class Arr5
    {
        public static void main()
        {
            int[] arr = new int[3].Select(x => new Random().Next(100)).ToArray().Print();
            arr.Sum().Print();
            if (arr.SequenceEqual(arr.OrderBy(x => x).ToArray())) Console.WriteLine("up");
            else if (arr.SequenceEqual(arr.OrderByDescending(x => x).ToArray())) Console.WriteLine("down");
            else Console.WriteLine("dont ordered");
        }
    }
}
