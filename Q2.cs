using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Q2
    {
        static void Main()
        {
            Dictionary<int, string> map = new Dictionary<int, string>()
            {
                [11] = "shan",
                [10] = "Abhi",
                [02] = "Kajal"

            };
            var lst = map.Keys.ToList();
            lst.Sort();

            foreach(var i in lst)
            {
                Console.WriteLine("{0} {1}", i, map[i]);
            }
        }
    }
}
