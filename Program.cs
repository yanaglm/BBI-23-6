using System;
using Internal;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //int s = 0;
            //int i = 3;
            //for (i = 2; i < 36; i += 3)
            //{
            //    s = s + i;
            //}
            //Console.WriteLine(s);


            //2
            //int k = 1;
            //int j = 1;
            //for (j = 1; j < 10; j++)
            //{
            //    k = k + (1 / j);
            //}
            //Console.WriteLine(k);
    
    
            //3
            //double s = 0;
            //for (double i = 2; i < 113; i+=2)
            //{
            //    s = s + (i / (i+1));
            //}
            //Console.WriteLine(s);
    
    
             //4
            //double x = 12;
            //double s = 0;
            //double a = 1;
            //for (double i = 1; i <= 9; i++)
            //{
            //    s += Math.Cos(i * x) / a;
            //    a = a * x;
            //}
            //Console.WriteLine(s);


            //5
            //int s = 0;
            //int p = 1;
            //int h = 1;
            //s = p * p;
            //for (int i = 1; i <= 9; i++)
            //{
            //    s += (p + i * h) * (p + i * h);
            //}
            //Console.WriteLine(s);
    
    
            //6
            //double x;
            //double y = 0;
            //for (x = -4; x<=4; x+=0.5)
            //{
            //    y = 0.5 * (x * x) - 7 * x;
            //    Console.WriteLine("y= " + y + " x=" + x);
            //}
    
    
            //7
            //int f = 1;
            //if (f != 0)
            //{
            //    for (int i = 1; i <= 6; i++)
            //    {
            //        f *= i;
            //    }
            //    Console.WriteLine(f);
            //}
    
    
            //8
            //int f = 1;
            //int k = 0;
            //if (f != 0)
            //{
            //    for (int i = 1; i <= 6; i++)
            //    {
            //        f *= i;
            //        k += f;
            //    }
            //    Console.WriteLine(k);
            //}
    
    
            //9
            //double f = 1;
            //double s = 0;
            //for (int i = 1; i <= 6; i++)
            //{
            //    f = (-1) * f * 5 / i;
            //    s += f;
            //}
            //Console.WriteLine(s);
    
    
            //10
            //int h = 3;
            //int pow = 7;
            //int res = 1;
            //for (int i = 1; i<=pow; i++)
            //{
            //    res *= h;
            //}
            //Console.WriteLine(res);
    
    
            //11a
            //int s = 1;
            //while (s < 7)
            //{
            //    Console.Write(s);
            //    s++;
            //}
    
            //11b
            //int s = 5;
            //int i = 0;
            //for (i = 0; i < 6; i++)
            //{
            //    Console.Write(s);
            //}
    
    
            //12
            //double s = 0;
            //double x = 2;
            //double a = x;
            //for (int i = 0; i <= 10; i++)
            //{
            //    a /= x;
            //    s += a;
            //}
            //Console.WriteLine("x = 2");
            //Console.WriteLine(s);
    
    
            //13
            //double y;
            //double x;
            //double h = 0.1;
            //for (x = -1.5; x <= 1.5; x += h)
            //{
            //    if (x <= -1)
            //    {
            //        y = 1;
            //    }
            //    if (x <= 1 & x > -1)
            //    {
            //        y = -x;
            //    }
            //    else
            //    {
            //        y = -1;
            //    }
            //    Console.WriteLine("x=" + x + " y=" + y);
            //}
    
    
            //14
            //int n = 8;
            //int a1 = 1;
            //int a2 = 1;
            //int an;
            //Console.Write(a1 + " " + a2 + " ");
            //for (int i = 3; i<= n; i++)
            //{
            //    an = a1 + a2;
            //    Console.Write(an + " ");
            //    a1 = a2;
            //    a2 = an;
            //}
    
    
            //15
            //int n = 5;
            //double ch = 1;
            //double zn = 1;
            //for (int i = 2; i < n; i++)
            //{
            //    double x = ch;
            //    ch += zn;
            //    zn = x;
            //}
            //Console.WriteLine($"{ch}/{zn}");
    
    
    
    
            //2 level
    
            //1
            //double s = 0;
            //int x = 1;
            //double a;
            //int n = Int32.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    a = Math.Cos(i * x) / (i * i);
            //    s += a;
    
            //    if(Math.Abs(a) < 0.0001)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
    
    
            //2
            //int p = 1;
            //int k = 1;
            //int n = 4;
            //for (int i = n; i > 0; i += 3)
            //{
            //    k = p * i;
            //    if (k < 30000)
            //    {
            //        p = p * i;
            //    }
            //    else
            //    {
            //        n = i - 3;
            //        break;
            //    }
            //}
            //Console.WriteLine(n);
    
    
            //3
            //int n = 0;
            //int s = 0;
            //int g;
            //const int p = 18;
            //const int a = 1;
            //const int h = 2;
            //while (s < p)
            //{
            //    g = a + (n * h);
            //    s += g;
            //    n += 1;
            //}
            //n -= 1;
            //Console.WriteLine(n);
    
    
            //4
            //double s = 1;
            //double x = 0.7;
            //double s1 = 0;
            //for (int i = 1; i <= 10000; i++)
            //{
            //    double a = x;
            //    for (int j = 1; j <= i*2 -1; i++)
            //    {
            //        a += x;
            //    }
            //    s += a;
    
            //    if (a>= 0.0001)
            //    {
            //        s1 = s;
            //    }
            //    else
            //    {
            //        Console.WriteLine(s1);
            //    }
            //}
    
    
            //5
            //int n = Int32.Parse(Console.ReadLine());
            //int m = Int32.Parse(Console.ReadLine());
            //int k = 0;
            //while (n >= m)
            //{
            //    n -= m;
            //    k++;
            //}
            //Console.WriteLine($"результат: {k}");
            //Console.WriteLine($"остаток: {n}");
    
    
            //6
            //int n = 1;
            //int t = 0;
            //while (n < 100000)
            //{
            //    n += n;
            //    t++;
            //}
            //Console.WriteLine(t);
    
    
            //7a
            //double s = 10.0;
            //double s1 = 10.0;
            //for (int i = 2; i < 8; i++)
            //{
            //    s = s * 1.1;
            //    s1 = s1 + s;
            //}
            //Console.WriteLine($"a) {s1}");
    
    
            //7b
            //double s = 10.0;
            //double s1 = 10.0;
            //double sum = 0;
            //int k = 0;
            //for (int i = 2; i < 10; i++)
            //{
            //    s = s * 1.1;
            //    s1 = s1 + s;
            //    k++;
            //    if (s1 >= 100)
            //    {
            //        Console.WriteLine(k);
            //        break;
    
            //    }
            //}
    
    
            //7c
            //double s = 10.0;
            //double s1 = 10.0;
            //double sum = 0;
            //int k = 0;
            //for (int i = 2; i < 10; i++)
            //{
            //    s = s * 1.1;
            //    s1 = s1 + s;
            //    k++;
            //    if (s >= 20)
            //    {
            //        Console.WriteLine(k);
            //        break;
    
            //    }
            //}
    
    
            //8
            //double vk = 10000;
            //int m = 0;
            //for (m = 0; vk < 20000; m++)
            //{
            //    vk *= 1.08;
            //}
            //Console.WriteLine(m);

            
            //level 3
            //6
            //double a = 0.1;
            //double b = 1;
            //double h = 0.1;
    
            //double pow(double r, double q)
            //{
            //    double p = 1;
            //    for (int i = 1; i <= q; i++)
            //    {
            //        p = p * r;
            //    }
            //    return p;
            //}
    
    
            //double factorial(double n)
            //{
            //    if (n == 1 ^ n == 0)
            //    {
            //        return 1;
            //    }
            //    else return n * factorial(n - 1);
            //}
    
            //double y(double n)
            //{
            //    return ((1+n*n)*Math.Atan(n)/2) -(n/2);
            //}
    
            //for (double x = a; x <= b; x += h)
            //{
            //    double s = 0;
            //    for (double i = 1; ; i++)
            //    {
            //        double E = pow(-1, i+1) * (pow(x, 2 * i+1) / (4*i*i - 1));
            //        if (Math.Abs(E) < 0.0001)
            //        {
            //            break;
            //        }
            //        s += E;
            //        Console.WriteLine($"x = {x}, s = {s}, y = {y(x)}");
    
            //    }
            //}
                   
        }
    }
}
