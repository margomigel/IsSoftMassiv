
using ClassPoint;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {

        PointCoordinates a = new PointCoordinates();
        a.Name = "a";
        a.x = 3;
        a.y = 4;
        PointCoordinates b = new PointCoordinates();
        b.Name = "b";
        b.x = 5;
        b.y = 2;
        PointCoordinates c = new PointCoordinates();
        c.Name = "c";
        c.x = 3;
        c.y = 8;
        PointCoordinates d = new PointCoordinates();
        d.Name = "d";
        d.x = 5;
        d.y = 5;
        PointCoordinates e = new PointCoordinates();
        e.Name = "e";
        e.x = 2;
        e.x = 8;
        PointCoordinates f = new PointCoordinates();
        f.Name = "f";
        f.x = 1;
        f.y = 3;
        PointCoordinates g = new PointCoordinates();
        g.Name = "g";
        g.x = 3;
        g.y = 6;
        PointCoordinates h = new PointCoordinates();
        h.Name = "h";
        h.x = 5;
        h.y = 3;
        PointCoordinates i = new PointCoordinates();
        i.Name = "i";
        i.x = 2;
        i.y = 3;
        PointCoordinates j = new PointCoordinates();
        j.Name = "j";
        j.x = 8;
        j.y = 5;

        Console.WriteLine(a.Name);
        Console.WriteLine(a.x);
        Console.WriteLine(a.y);
            } 
}

    /*string GetInfoPoint()
    {
        return "Point" + Name + " has coordinates: " + x + ", " + y "
    }
        PointCoordinates[] point = {a, b, c, d, e, f, g, h, i, j};
        for (int i = 0; int < 10; i ++)
        {
            Console.WriteLine(point[i].GetInfoPoint);
        }
}*/