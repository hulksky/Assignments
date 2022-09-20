using System;
using System.Collections;
namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            
            for(int i = 0; i < 10; i++)
            {
                list.Add(Console.ReadLine());
            }
            list.Sort();
            for(int j = 0; j < list.Count; j++)
            {
                Console.Write(list[j]);
            }
        }
    }
}