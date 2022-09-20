using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Q3
    {
        static void Main()
        {
            ArrayList list = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                list.Add(Console.ReadLine());
            }
            var lst = list.ToString();
            list.Sort();
            for (int j = 0; j < list.Count; j++)
            {
                Console.Write(" "+list[j]);
            }
        }
    }
}
