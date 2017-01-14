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
            point p1 = new point();
            p1.x = 1;
            p1.y = 2;
            p1.sym = '*';
            p1.Draw();

            point p2 = new point();
            p2.x = 3;
            p2.y = 4;
            p2.sym = '#';
            p2.Draw();

            Console.ReadLine();

     
        }
    }
}
