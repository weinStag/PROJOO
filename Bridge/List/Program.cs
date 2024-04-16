using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // List
            List.List list = new List.List(new List<int>());
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);
            Console.WriteLine("List Size: " + list.Size());
            list.Remove(0);
            list.Remove(8);
            list.Remove(3);
            Console.WriteLine("List Size: " + list.Size());
            Console.ReadKey();
        }
    }
}
