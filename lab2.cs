using System;
using Internal;
using static System.Runtime.InteropServices.JavaScript.JSType;

class HelloWorld
{
    static void Main()
    {
        //lab 2
        //level 1

        //1
        //int r = 2;
        //double x = 0;
        //double y = 2;
        //if (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(r, 2)) <= Math.Pow(10, -3))
        //{
        //    Console.WriteLine("in");
        //}
        //else
        //{
        //    Console.WriteLine("not in");


        //2
        //int x = 0;
        //int y = 1;
        //if (y >= 0 & (y+Math.Abs(x))<=1)
        //{
        //    Console.WriteLine("in");
        //}
        //else
        //{
        //    Console.WriteLine("not in");
        //}


        //3
        //int a = Int32.Parse(Console.ReadLine());
        //int b = Int32.Parse(Console.ReadLine());
        //int c;
        //if (a > 0)
        //{
        //    c = Math.Max(a, b);
        //}
        //else
        //{
        //    c = Math.Min(a, b);
        //}
        //Console.WriteLine($"c = {c}");


        //4
        //int a = Int32.Parse(Console.ReadLine());
        //int b = Int32.Parse(Console.ReadLine());
        //int c = Int32.Parse(Console.ReadLine());
        //int z;
        //int k;
        //if(a>b)
        //{
        //    k = b;
        //}
        //else
        //{
        //    k = a;
        //}
        //if (k > c)
        //{
        //    z = k;
        //}
        //else
        //{
        //    z = c;
        //}
        //Console.WriteLine($"z = {z}");


        //5
        //double r = 0.86;
        //double s = 0.74;
        //double st = Math.Sqrt(s);
        //double diag = st * Math.Sqrt(2) / 2;
        //if (diag <= r)
        //{
        //    Console.WriteLine("in");
        //}
        //else
        //{
        //    Console.WriteLine("not in");
        //}


        //6
        //double r = 6;
        //double s = 9;
        //double st = Math.Sqrt(s);
        ////double diag = st * Math.Sqrt(2) / 2;
        //if (st >= r * 2)
        //{
        //    Console.WriteLine("in");
        //}
        //else
        //{
        //    Console.WriteLine("not in");
        //}


        //7
        //int x = Int32.Parse(Console.ReadLine());
        //int y;
        //if (Math.Abs(x) > 1)
        //{
        //    y = 1;
        //}
        //else
        //{
        //    y = Math.Abs(x);
        //}
        //Console.WriteLine($"y = {y}");


        //8
        //double x = Int32.Parse(Console.ReadLine());
        //double y;
        //if (Math.Abs(x) >= 1)
        //{
        //    y = 0;
        //}
        //else
        //{
        //    y = Math.Pow(x, 2) - 1;
        //}
        //Console.WriteLine($"y = {y}");


        //9
        //double x = Int32.Parse(Console.ReadLine());
        //double y;
        //if (x <= -1)
        //{
        //    y = 0;
        //}
        //else if (x > 0)
        //{
        //    y = 1;
        //}
        //else
        //{
        //    y = x + 1;
        //}
        //Console.WriteLine($"y = {y}");


        //level 2

        //1
        //int n = Int32.Parse(Console.ReadLine());
        //double rost = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    rost = Double.Parse(Console.ReadLine());
        //}
        //double sr = (double)rost / n;
        //Console.WriteLine(sr);


        //2
        //int n = Int32.Parse(Console.ReadLine());
        //double a = Double.Parse(Console.ReadLine());
        //double b = Double.Parse(Console.ReadLine());
        //double r = Double.Parse(Console.ReadLine());
        //int k = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    double x = Double.Parse(Console.ReadLine());
        //    double y = Double.Parse(Console.ReadLine());
        //    x -= a;
        //    y -= b;
        //    if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(r, 2))
        //    {
        //        k++;
        //    }
        //}
        //Console.WriteLine($"точек в в круге: {k}");


        //3
        //int n = Int32.Parse(Console.ReadLine());
        //double m = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    double ves = Double.Parse(Console.ReadLine());
        //    if (ves < 30)
        //    {
        //        m += 0.2;
        //    }
        //}
        //Console.WriteLine(m);


        //4
        //int n = Int32.Parse(Console.ReadLine());
        //double r1 = Double.Parse(Console.ReadLine());
        //double r2 = Double.Parse(Console.ReadLine());
        //int k = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    double x = Double.Parse(Console.ReadLine());
        //    double y = Double.Parse(Console.ReadLine());
        //    double r1_2 = Math.Pow(r1, 2);
        //    double r2_2 = Math.Pow(r2, 2);
        //    if ((Math.Pow(x, 2) + Math.Pow(y, 2) >= r1_2) & (Math.Pow(x, 2) + Math.Pow(y, 2) <= r2_2))
        //    {
        //        k++;
        //    }
        //}
        //Console.WriteLine($"точек попадет: {k}");


        //5
        //int n = 30;
        //int norm = Int32.Parse(Console.ReadLine());
        //int k = 0;
        //for (int i = 0; i <= 30; i++)
        //{
        //    double km = Double.Parse(Console.ReadLine());
        //    if (km >= norm)
        //    {
        //        k++;
        //    }
        //}
        //Console.WriteLine(k);


        //6
        //int n = Int32.Parse(Console.ReadLine());
        //int k = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    double x = Double.Parse(Console.ReadLine());
        //    double y = Double.Parse(Console.ReadLine());
        //    if (x >= 0 & x <= Math.PI)
        //    {
        //        if (Math.Sin(x) >= y & y >= 0)
        //        {
        //            k++;
        //        }
        //    }
        //}
        //Console.WriteLine($"{k} точек принадлежат");


        //7
        //int n = Int32.Parse(Console.ReadLine());
        //int nk1 = 0;
        //int nk2 = 0;
        //int nk3 = 0;
        //int nk4 = 0;
        //for (int i = 1; i <= n; i++)
        //{
        //    int x = Int32.Parse(Console.ReadLine());
        //    int y = Int32.Parse(Console.ReadLine());


        //    if (x > 0 & y > 0)
        //    {
        //        Console.WriteLine("1 квадрант");
        //        nk1++;
        //    }
        //    if (x < 0 & y > 0)
        //    {
        //        Console.WriteLine("2 квадрант");
        //        nk2++;
        //    }
        //    if (x < 0 & y < 0)
        //    {
        //        Console.WriteLine("3 квадрант");
        //        nk3++;
        //    }
        //    if (x > 0 & y < 0)
        //    {
        //        Console.WriteLine("4 квадрант");
        //        nk4++;
        //    }

        //}
        //Console.WriteLine("в 1 квадранте:" + nk1 + ", в 3 квадранте:" + nk3);


        //8
        //Console.Write("number of points ");
        //int n = Int32.Parse(Console.ReadLine());
        //double min_dist = double.MaxValue;
        //int k = -1;
        //for (int i = 1; i <= n; i++)
        //{
        //    Console.Write("x = ");
        //    int x = Int32.Parse(Console.ReadLine());
        //    Console.Write("y = ");
        //    int y = Int32.Parse(Console.ReadLine());
        //    double dist = Math.Sqrt(x * x + y * y);
        //    if (dist < min_dist)
        //    {
        //        min_dist = dist;
        //        k = i;
        //    }
        //}
        //Console.WriteLine($"the nearest {k}");
        //Console.WriteLine($"distance {min_dist}");

        
        //9
        //int n = Int32.Parse(Console.ReadLine());
        //int best = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    int dist = Int32.Parse(Console.ReadLine());
        //    best = Math.Max(best, dist);
        //}
        //Console.WriteLine($"best result {best}");
    }
}
