using System;

namespace _04TriangleSurface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1 -Side and an altitude to it;\n 2 -Three sides; \n 3 -Two sides and an angle between them;");
            int r = int.Parse(Console.ReadLine());
            switch(r)
            {
                case 1:
                    {
                        Console.Write("Add side size:");
                        int side = int.Parse(Console.ReadLine());
                        Console.Write("Add altitude:");
                        int altitude = int.Parse(Console.ReadLine());

                        Console.WriteLine("Surface is :"+(side * altitude / 2));
                        break;
                    }
            case 2:
                    {
                        Console.Write("Add side 1 size :");
                        int side1 = int.Parse(Console.ReadLine());
                        Console.Write("Add side 2 size :");
                        int side2 = int.Parse(Console.ReadLine());
                        Console.Write("Add side 3 size :");
                        int side3 = int.Parse(Console.ReadLine());

                        double p = (side1 + side2 + side3) / 2;
                        double surface = Convert.ToDouble(Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)));
                        Console.WriteLine("Surface is :" +surface);
                        break;
                    }
                case 3:
                {
                    Console.Write("Add side 1 size :");
                    int side1 = int.Parse(Console.ReadLine());
                    Console.Write("Add side 2 size :");
                    int side2 = int.Parse(Console.ReadLine());
                    Console.Write("Add angle between sides:");
                    float ang = float.Parse(Console.ReadLine());
                    double surface = Convert.ToDouble((side1 * side2 * Math.Sin(ang)) / 2);
                    Console.WriteLine("Surface is :" + surface);
                    break;

                    }
            }
        }
    }
}
