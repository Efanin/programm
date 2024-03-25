using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm.LinQ
{
    static class Arr8
    {
        public static void main()
        {
            int[] arr = new int[10].Select(x => new Random().Next(150)).ToArray().Print();
            //int[] arr1 = arr.Where(x => x % 2 == 0).OrderBy(x => x).ToArray().Print();
            //int[] arr2 = arr.Where(x => x % 2 == 1).OrderBy(x => x).ToArray().Print();
            //arr.Reverse().ToArray().Print();
            //arr.Where(x=>x!=arr.Max()).Max().Print();   
            //int[] arr1 = arr[0..3].Concat(new int[] { -10 }).ToArray().Concat(arr[3..^0]).ToArray().Print();
            //arr.DistinctBy(x => x).ToArray().Print();
            //arr.Average().Print();

        }
    }
}
