using System;
using Internal;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //lab1
                //level1
                //1
                int s = 0;
                int i = 3;
                for (i = 2; i < 36; i += 3)
                {
                    s = s + i;
                }
                Console.WriteLine(s);
            }

            //2
            {
                int k = 1;
                int j = 1;
                for (j = 1; j < 10; j++)
                {
                    k = k + (1 / j);
                }
                Console.WriteLine(k);
            }

            //11a
            {
                int s = 1;
                while (s < 7)
                {
                    Console.Write(s);
                    s++;
                }


            }
            //11b
            {
                int s = 5;
                int i = 0;
                for (i = 0; i < 6; i++)
                {
                    Console.Write(s);
                }


            }



            //7
            {
                int f = 1;
                if (f != 0)
                {
                    for (int i = 1; i <= 6; i++)
                    {
                        f *= i;
                    }
                    Console.WriteLine(f);
                }
            }


            //12
            {
                int s = 1;
                int x = 2;
                int i = 1;
                for (i = 1; i < 11; i++)
                {
                    double k = 1 / Math.Pow(x, i);
                    int r;
                    r = (int)k;
                    s = s + r;
                }

                Console.WriteLine("x = 2");
                Console.WriteLine(s);
            }

            //level2
            //2 
            {
                int p = 1;
                int k = 1;
                int n = 4;
                for (int i = n; i > 0; i += 3)
                {
                    k = p * i;
                    if (k < 30000)
                    {
                        p = p * i;
                    }
                    else
                    {
                        n = i - 3;
                        break;
                    }
                }
                Console.WriteLine(n);
            }


            //3
            {

                int n = 0;
                int s = 0;
                int g;
                const int p = 18;
                const int a = 1;
                const int h = 2;
                while (s < p)
                {
                    g = a + (n * h);
                    s += g;
                    n += 1;
                }
                n -= 1;
                Console.WriteLine(n);


                //5
            {
                int n = Int32.Parse(Console.ReadLine());
                int m = Int32.Parse(Console.ReadLine());
                int k = 0;
                while (n >= m)
                {
                        n -= m;
                        k++;
                }
                Console.WriteLine($"результат: {k}");
                Console.WriteLine($"остаток: {n}");
            }

                //7a

                {
                    double s = 10.0;
                    double s1 = 10.0;
                    for (int i = 2; i < 8; i++)
                    {
                        s = s * 1.1;
                        s1 = s1 + s;
                    }
                    Console.WriteLine($"a) {s1}");
                }



                //7b

                {
                    double s = 10.0;
                    double s1 = 10.0;
                    double sum = 0;
                    int k = 0;
                    for (int i = 2; i < 10; i++)
                    {
                        s = s * 1.1;
                        s1 = s1 + s;
                        k++;
                        if (s1 >= 100)
                        {
                            Console.WriteLine(k);
                            break;

                        }
                    }

                }
                //7c
                {
                    double s = 10.0;
                    double s1 = 10.0;
                    double sum = 0;
                    int k = 0;
                    for (int i = 2; i < 10; i++)
                    {
                        s = s * 1.1;
                        s1 = s1 + s;
                        k++;
                        if (s >= 20)
                        {
                            Console.WriteLine(k);
                            break;

                        }
                    }
                }
                using System.Reflection.Emit;

//lab 2 
//level 1 task 1
        int r = 2;
        double x = 0;
        double y = 2;
        if (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(r, 2)) <= Math.Pow(10, -3))
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("not in");
        }
    


//3
        int a = Int32.Parse(Console.ReadLine());
        int b = Int32.Parse(Console.ReadLine());
        int c;
        if (a > 0)
        {
            c = Math.Max(a, b);
        }
        else
        {
            c = Math.Min(a, b);
        }
        Console.WriteLine($"c = {c}");




//4
        int a = Int32.Parse(Console.ReadLine());
        int b = Int32.Parse(Console.ReadLine());
        int c = Int32.Parse(Console.ReadLine());
        int z;
        int k;
        k = Math.Min(a, b);
        z = Math.Max(k, c);
        Console.WriteLine($"z = {z}");



//5

        double r = 0.86;
        double s = 0.74;
        double st = Math.Sqrt(s);
        double diag = st * Math.Sqrt(2) / 2;
        if (diag <= r)
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("not in");
        }


//6

        double r = 6;
        double s = 9;
        double st = Math.Sqrt(s);
        /*    double diag = st * Math.Sqrt(2) / 2; */
        if (st >= r * 2)
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("not in");
        }


//7

        int x = Int32.Parse(Console.ReadLine());
        int y;
        if (Math.Abs(x) > 1)
        {
            y = 1;
        }
        else
        {
            y = Math.Abs(x);
        }
        Console.WriteLine($"y = {y}");


//8

        double x = Int32.Parse(Console.ReadLine());
        double y;
        if (Math.Abs(x) >= 1)
        {
            y = 0;
        }
        else
        {
            y = Math.Pow(x, 2) - 1;
        }
        Console.WriteLine($"y = {y}");



//9

        double x = Int32.Parse(Console.ReadLine());
        double y;
        if (x <= -1)
        {
            y = 0;
        }
        else if (x > 0)
        {
            y = 1;
        }
        else
        {
            y = x + 1;
        }
        Console.WriteLine($"y = {y}");


//level 2 task 1

        int n = Int32.Parse(Console.ReadLine());
        double rost = 0;
        for (int i = 0; i < n; i++)
        {
            rost = Double.Parse(Console.ReadLine());
        }
        double sr = (double)rost / n;
        Console.WriteLine(sr);



//2
        int n = Int32.Parse(Console.ReadLine());
        double a = Double.Parse(Console.ReadLine());
        double b = Double.Parse(Console.ReadLine());
        double r = Double.Parse(Console.ReadLine());
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());
            x -= a;
            y -= b;
            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(r, 2))
            {
                k++;
            }
        }
        Console.WriteLine($"точек в в круге: {k}");


//3

        int n = Int32.Parse(Console.ReadLine());
        double m = 0;
        for (int i = 0; i < n; i++)
        {
            double ves = Double.Parse(Console.ReadLine());
            if (ves < 30)
            {
                m += 0.2;
            }
        }
        Console.WriteLine(m);


//4

        int n = Int32.Parse(Console.ReadLine());
        double r1 = Double.Parse(Console.ReadLine());
        double r2 = Double.Parse(Console.ReadLine());
        int k = 0;
        for (int i = 0; i < n: i++)
        {
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) >= Math.Pow(r1, 2)) & (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(r2, 2)))
            {
                k++;
            }
        }
        Console.WriteLine($"точек попадет: {k}");


//5

        int n = 30;
        int norm = Int32.Parse(Console.ReadLine());
        int k = 0;
        for (int i = 0; i <= 30; i++)
        {
            double km = Double.Parse(Console.ReadLine());
            if (km >= norm)
            {
                k++;
            }
        }
        Console.WriteLine(k);



//6

        int n = Int32.Parse(Console.ReadLine());
        int k = 0;
        for (iny i = 0; i < n; i++)
        {
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());
            if (x >= 0 & x <= Math.PI)
            {
                if (Math.Sin(x) >= y & y >= 0)
                {
                    k++;
                }
            }
        }
        Console.WritwLine($"{k} точек принадлежат");



//9
        int n = Int32.Parse(Console.ReadLine());
        int best = 0;
        for (int i = 0; i < n; i++)
        {
            int dist = Int32.Parse(Console.ReadLine());
            best = Math.Max(best, dist);
        }
        Console.WriteLine($"best result {best}");



//8

        int n = Int32.Parse(Console.ReadLine());
        int k;
        for (int i = 0; i < n; i++)
        {
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            int rast = Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2));
            }
        }
    }
}
