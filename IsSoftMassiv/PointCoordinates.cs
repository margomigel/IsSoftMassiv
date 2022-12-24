using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPoint
{
    internal class PointCoordinates
    {
        public int x; 
        public int y;
        public void ShowInfoPoint()
        {
            Console.WriteLine("Point has coordinates: " + x + ", " + y);
        }
    }
}
