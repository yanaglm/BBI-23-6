using System;
class HelloWorld
{
    static void Main()
    {
        //lab4
        //level 1
        //3
        //int[,] a = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
        //int sled = 0;
        //for (int i = 0; i < 4; i++)
        //{
        //    sled += a[i, i];
        //}
        //Console.WriteLine("sled= " + sled);


        //just example
        //int[,] a = { { 1, 2, 3 }, { 4,5,6} };
        //for(int i = 0; i < 2; i++)
        //{
        //    for(int j = 0; j < 3; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}


        //7
        //int[,] a = new int[5, 7] { { 2, 3, 4, 18, 1, 6, 7 }, { 9, 10, 11, 5, 4, 8, 3 }, {6,4,3,8,5,9,11 }, {9,4,7,3,1,15,6},{ 2,8,4,9,13,7,6 } };
        //int[] max = new int[7];
        //int maxx = -100000;
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine("result");
        //for (int j = 0; j < 7; j++)
        //{
        //    for(int i = 0; i<5; i++)
        //    {
        //        if (a[i,j]>maxx)
        //        {
        //            maxx = a[i, j];
        //        }
        //    }
        //    max[j] = maxx;
        //    Console.WriteLine(max[j]);
        //}

        //11
        //int[,] a = new int[5, 7] { { 1, 2, 3, 4, 5, 6, 7 }, { 5, 2, 7, 6, 4, 8, 3 }, { 9, 6, 5, 3, 2, 7, 4 }, { 9, 2, 10, 7, 4, 3, 1 }, { 7, 8, 3, 7, 2, 5, 9 } };
        //int minn = a[0,0];
        //int ind = 0;
        //for(int i = 0; i < 5; i++)
        //{
        //    for(int j = 0; j < 7; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //}

        //for(int i = 1; i < 5; i++)
        //{
        //    if (a[i, 0] < minn)
        //    {
        //        minn = a[i, 0];
        //        ind = i;
        //    }
        //}
        //int[,] a2 = new int[4, 7];
        //int newrow = 0;
        //for(int i = 0; i < 5; i++)
        //{
        //    if(i!= ind)
        //    {
        //        for(int j = 0; j < 7; j++)
        //        {
        //            a2[newrow, j] = a[i, j];
        //        }
        //        newrow++;
        //    }
        //}
        //a = a2;
        //Console.WriteLine("result");
        //for(int i = 0; i<4; i++)
        //{
        //    for(int j = 0; j < 7; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}


        //15
        //int[,] a = new int[5,7] { { 1, 2, 3, 4, 5, 6, 7 }, { 5, 2, 7, 6, 4, 8, 3 }, { 9, 6, 5, 3, 2, 7, 4 }, { 9, 2, 10, 7, 4, 3, 1 }, { 7, 8, 3, 7, 2, 5, 9 } };
        //int maxx = -10000;
        //int maxj;
        //for(int i = 0; i< 5; i++)
        //{
        //    for(int j = 0; j < 7; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}
        //for(int i = 0; i<5;i++)
        //{
        //    maxx = a[i, 0];
        //    maxj = 0;
        //    for(int j = 0; j < 7; j++)
        //    {
        //        if (a[i, j] > maxx)
        //        {
        //            maxx = a[i, j];
        //            maxj = j;
        //        }
        //    }
        //    a[i, maxj] *= (i+1);
        //}
        //Console.WriteLine("result");
        //for(int i = 0; i < 5; i++)
        //{
        //    for(int j = 0; j<7;j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}


        //19
        //int n = Int32.Parse(Console.ReadLine());
        //int m = Int32.Parse(Console.ReadLine());
        //double[,] c = new double[n, m];
        //double maxx = -10000;
        //int maxj;
        //int maxi;
        //for (int i = 0; i < c.GetLength(0); i++)
        //{
        //    for (int j = 0; j < c.GetLength(1); j++)
        //    {
        //        Console.WriteLine("[" + i + ", " + j + "]");
        //        c[i, j] = Int32.Parse(Console.ReadLine());
        //    }
        //}
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write($"{c[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine("res");
        //for (int i = 0; i < n; i++)
        //{
        //    maxx = c[i, 0];
        //    maxj = 0;
        //    maxi = 0;
        //    for (int j = 0; j < m; j++)
        //    {
        //        if (c[i, j] > maxx)
        //        {
        //            maxx = c[i, j];
        //            maxj = j;
        //            Console.WriteLine("maxx " + maxx + " maxi " + maxi + " maxj " + maxj);
        //        }
        //    }
        //    for (int j = 0; j < maxj; j++)
        //    {
        //        if (c[i, j] < 0)
        //        {
        //            c[i, j] /= maxx;
        //        }
        //    }
        //}
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write($"{c[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}


        //23
        //int[,] a = new int[5, 7] { { 1, 2, 8, 4, 5, 7, 6 }, { 5, 2, 7, 6, 4, 8, 3 }, { 9, 6, 5, 3, 2, 7, 4 }, { 9, 2, 10, 7, 4, 3, 1 }, { 7, 8, 11, 7, 2, 5, 2 } };
        //int maxx;
        //int maxind;
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}

        //Console.WriteLine("result");
        //for (int i = 0; i<5; i++)
        //{
        //    maxx = a[i, 0];
        //    maxind = 0;
        //    for(int j = 0; j < 6; j++)
        //    {
        //        if (a[i, j] > maxx)
        //        {
        //            maxx = a[i, j];
        //            maxind = j;
        //        }
        //    }

        //    for (int r = 5; r > maxind; r--)
        //    {
        //        a[i, r + 1] = a[i, r];

        //    }
        //    a[i, maxind + 1] = maxx;
        //}

        //for(int i = 0; i < 5; i++)
        //{
        //    for(int j = 0; j<7; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}


        //27
        //int[,] a = new int[5,7] { { 1, 2, 8, 4, 5, 7, 6 }, { 5, 2, 7, 6, 4, 8, 3 }, { 1, 6, 5, 3, 2, 7, 4 }, { 9, 2, 10, 7, 4, 3, 1 }, { 7, 8, 11, 7, 2, 5, 2 } };
        //int maxx;
        //int maxind;
        //int[] n = new int[5];
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}

        //Console.WriteLine("result");

        //for(int i = 0; i < 5; i++)
        //{
        //    maxx = a[i, 0];
        //    maxind = 0;
        //    for (int j = 0; j < 6; j++)
        //    {
        //        if (a[i, j] > maxx)
        //        {
        //            maxx = a[i, j];
        //            maxind = j;
        //            n[i] = maxx;
        //        }
        //    }


        //    a[i, 3] = n[i];
        //}

        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}


        //31
        //int[,] a = new int[5, 8] { { 1, 2, 8, 4, 5, 7, 6,3 }, { 5, 2, 7, 6, 4, 8, 3,4 }, { 1, 6, 5, 3, 2, 7, 4,6 }, { 9, 2, 1, 7, 4, 3, 10,5 }, { 7, 8, 11, 7, 2, 5, 2,4 } };
        //int[] b = { 5, 3, 6, 1, 8 };
        //int minn = a[4,0];
        //int minind=0;
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine("result");

        //for(int j = 1; j < 7; j++)
        //{
        //    if (a[4, j] < minn)
        //    {
        //        minn = a[4, j];
        //        minind = j;
        //    }
        //}

        //for(int i = 0; i < 5; i++)
        //{
        //    for(int j = 0; j < 8; j++)
        //    {
        //        if (j <= minind)
        //        {
        //            Console.Write(a[i, j] + " ");
        //        }
        //        else if (j == minind + 1)
        //        {
        //            Console.Write(b[i] + " ");
        //        }
        //        else
        //        {
        //            Console.Write(a[i, j - 1] + " ");
        //        }
        //    }
        //    Console.WriteLine();
        //}




        //level 2
        //3
        //int[,] a = new int[10, 5] { { 1, 2, 8, 4, 5 },{3,8, 7, 6, 3 }, { 5, 2, 7, 6, 4 },{2,6, 8, 3, 4 }, { 1, 6, 5, 3, 2 }, {2,9,7, 4, 6 }, { 9, 2, 1, 7, 4 },{7,4, 3, 10, 5 }, { 7, 8, 11, 7, 2 },{3,9, 5, 2, 4 } };
        //int maxx;
        //int maxind;
        //int sum;
        //for (int i = 0; i < 10; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine("result");

        //for (int j = 0; j < 5; j++)
        //{
        //    maxx = a[0, j];
        //    maxind = 0;
        //    for(int i = 1; i < 10; i++)
        //    {
        //        if (a[i, j] > maxx)
        //        {
        //            maxx = a[i, j];
        //            maxind = i;
        //        }
        //    }
        //    if (maxind < 5)
        //    {
        //        sum = 0;
        //        for(int i = maxind + 1; i < 10; i++)
        //        {
        //            sum += a[i, j];
        //        }
        //        a[0, j] = sum;
        //    }
        //}
        //for(int i = 0; i < 10; i++)
        //{
        //    for(int j = 0; j < 5; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}


        //7
        //int[,] a = new int[6, 6] { { 1, 2, 8, 4, 5, 3 }, { 3, 8, 7, 6, 3, 5 }, { 5, 2, 7, 6, 4, 3 }, { 2, 6, 8, 11, 4, 5 }, { 1, 6, 5, 3, 2, 4 }, { 2, 9, 7, 4, 6, 1 } };
        //int maxx = a[0, 0];
        //int maxind = 0;
        //for (int i = 0; i < 6; i++)
        //{
        //    for (int j = 0; j < 6; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine("result");

        //for(int i = 0; i < 6; i++)
        //{
        //    if (a[i, i] > maxx)
        //    {
        //        maxx = a[i, i];
        //        maxind = i;
        //    }
        //}

        //for(int i = 0; i < maxind; i++)
        //{
        //    for(int j = maxind + 1; j < 6; j++)
        //    {
        //        a[i, j] = 0;
        //    }
        //}

        //for(int i = 0; i < 6; i++)
        //{
        //    for(int j = 0; j < 6; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}



        //level 3
        //2
        //int[,] a = new int[6, 6] { { 1, 2, 8, 4, 5, 3 }, { 3, 8, 7, 6, 3, 5 }, { 5, 2, 7, 6, 4, 3 }, { 2, 6, 8, 11, 4, 5 }, { 1, 6, 5, 3, 2, 4 }, { 2, 9, 7, 4, 6, 1 } };
        //for (int i = 0; i < 6; i++)
        //{
        //    for (int j = 0; j < 6; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine("result");
        //for (int i = 0; i < 6; i++)
        //{
        //    for(int j = 0; j < 6; j++)
        //    {
        //        if (i ==0 || i==5 ||j==0||j==5)
        //        {
        //            a[i, j] = 0;
        //        }
        //    }
        //}
        //for (int i = 0; i < 6; i++)
        //{
        //    for (int j = 0; j < 6; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}


        //8
        //int[,] a = new int[7, 5] { { 1, 2, -8, 4, 5 }, { -3, -8, 7, -6, 3 }, { 5, 2, 7, 6, 4 }, { 2, -6, 8, 11, -4 }, { -1, -6, -5, -3, -2 }, { 2, -9, 7, 4, 6 }, { -3, -6, -4, -8, 5 } };
        //int[] pol = new int[7];
        //int k;
        //for (int i = 0; i < 7; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine("result");
        //for (int i = 0; i < 7; i++)
        //{
        //    k = 0;
        //    for(int j = 0; j < 5; j++)
        //    {
        //        if (a[i, j] > 0)
        //        {
        //            k++;
        //        }
        //    }
        //    pol[i] = k;
        //}

        //for(int i = 0; i < 6; i++)
        //{
        //    for(int j = i + 1; j < 7; j++)
        //    {
        //        if (pol[i] < pol[j])
        //        {
        //            for(int r = 0; r < 5; r++)
        //            {
        //                int x = a[i, r];
        //                a[i, r] = a[j, r];
        //                a[j, r] = x;
        //            }
        //            int y = pol[i];
        //            pol[i] = pol[j];
        //            pol[j] = y;
        //        }
        //    }
        //}

        //for(int i = 0; i< 7; i++)
        //{
        //    for(int j = 0; j < 5; j++)
        //    {
        //        Console.Write($"{a[i, j]} \t");
        //    }
        //    Console.WriteLine();
        //}

    }
}