using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm
{
    static class Arr4
    {
        public static void main()
        {
            Random random = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(300);
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 150)
                    sum += arr[i];
            } 
            Console.WriteLine(sum);
            new int[10].Select(x => new Random().Next(300)).Where(x => x < 150).Sum().Print();
        }
    }
}
