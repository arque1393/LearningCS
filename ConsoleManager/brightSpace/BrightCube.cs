using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleManager.brightSpace
{
    internal class BrightCube:Cuboid
    {
        int bright;
        public BrightCube(int[] dim, int bright):base(dim[0], dim[1], dim[2])
        {
            this.bright = bright;
        }
        public void disp()
        {
            base.disp();
            Console.WriteLine($"Bright\t: {this.bright}");
        }
    }
}
