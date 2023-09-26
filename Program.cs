using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }

}



        }
    }
}
