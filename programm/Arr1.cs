 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm
{
    internal class Arr1
    {
        public static void main()
        {
            new int[10].Select(x => new Random().Next(100)).Where(x => x % 2 == 0).ToArray().Print();

            Random random = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
            }
            int size = 0;     
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    size++;
                }
            }
            int[] arr2 = new int[size];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr2[j] = arr[i];
                    j++;
                }
            }
            arr = arr2;
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
