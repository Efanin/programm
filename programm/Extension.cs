using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm
{
    static class Extension
    {
        public static dynamic Print(this Array array)
        {
            foreach (var item in array)
                Console.Write(item + "\t");
            Console.WriteLine();
            return array;
        }
        public static dynamic Print(this object item)
        {
            Console.WriteLine(item);
            return item;
        }
    }
}
