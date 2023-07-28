using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleManager.brightSpace
{
    internal class Cuboid
    {
        int[] dim = new int[3];
        public Cuboid() { }
        public Cuboid(int a) { dim[0] = dim[1] = dim[2] = a; }
        public Cuboid(int a, int b) { dim[0] = a; dim[1] = dim[2] = b; }
        public Cuboid(int a, int b, int c) { dim[0] = a; dim[1] = b; dim[2] = c; }


        public double getVolume()
        {
            return this.dim[0] * this.dim[1] * this.dim[2];
        }
        public void disp()
        {
            Console.WriteLine($"dim_1\t: {this.dim[0]}");
            Console.WriteLine($"dim_2\t: {this.dim[1]}");
            Console.WriteLine($"dim_3\t: {this.dim[2]}");
        }

    }
}
