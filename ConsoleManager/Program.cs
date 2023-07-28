using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleManager.custumTypesSpace;

namespace ConsoleManager
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Okay");

            foreach(int i in Enum.GetValues(typeof(ZTypeEnum)))
                Console.WriteLine($"{i.ToString()}:{ (ZTypeEnum)i}");


        }
    }
}
