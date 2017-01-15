using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake2
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(1, 2, '*');
            p1.Draw();

            point p2 = new point(3,4,'#');
            p2.Draw();

            Console.ReadLine();

     
        }
    }
}
