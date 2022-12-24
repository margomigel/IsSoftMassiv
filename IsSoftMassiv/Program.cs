
using ClassPoint;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {

        PointCoordinates a = new PointCoordinates();
        a.x = 3;
        a.y = 4;
        PointCoordinates b = new PointCoordinates();
        b.x = 5;
        b.y = 2;
        PointCoordinates c = new PointCoordinates();
        c.x = 3;
        c.y = 8;
        PointCoordinates d = new PointCoordinates();
        d.x = 5;
        d.y = 5;
        PointCoordinates e = new PointCoordinates();
        e.x = 2;
        e.x = 8;
        PointCoordinates f = new PointCoordinates();
        f.x = 1;
        f.y = 3;
        PointCoordinates g = new PointCoordinates();
        g.x = 3;
        g.y = 6;
        PointCoordinates h = new PointCoordinates();
        h.x = 5;
        h.y = 3;
        PointCoordinates i = new PointCoordinates();;
        i.x = 2;
        i.y = 3;
        PointCoordinates j = new PointCoordinates();
        j.x = 8;
        j.y = 5;

        PointCoordinates[] points = { a, b, c, d, e, f, g, h, i, j };

        foreach (PointCoordinates point in points)
        { 
            point.ShowInfoPoint(); 
        }
    }
}