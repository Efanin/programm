using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm.LinQ
{
    internal class Arr2
    {
        public static void main()
        {
            int[] arr = new int[10].Select(x => new Random().Next(100)).ToArray().Print();
            arr.Sum().Print();


            Random random = new Random();
            int[] arr2 = new int[10];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = random.Next(100);
            }
            foreach (var i in arr2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int sum = 0;
            foreach (int i in arr2)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
