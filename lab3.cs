using System;
class HelloWorld
{
    static void Main()
    {
        //lab3
        //level 1
        //1
        //double[] n = { 6,12,18,24,30,36 };
        //double sum = 0;
        //for (int i = 0; i < n.Length; i++)
        //{
        //    sum += n[i];
        //}

        //for (int i = 0; i < n.Length; i++)
        //{
        //    n[i] /= sum;
        //}
        //Console.WriteLine(sum);
        //Console.WriteLine("Результат:");
        //for (int i = 0; i < n.Length; i++)
        //{
        //    Console.WriteLine(n[i]);
        //}


        //2
        //double[] m = { 23, -15, 48, 10, -3, 5, 6, 7 };
        //double sum = 0;
        //int k = 0;
        //for (int i = 0; i < m.Length;i++)
        //{
        //    if (m[i] > 0)
        //    {
        //        sum += m[i];
        //        k++;
        //    }
        //}
        //double sred = sum / k;
        //Console.WriteLine(sred);

        //3 
        //int[] n = { 1, 2, 3, 4 };
        //int[] m = { 5, 6, 7, 8 };
        //int[] sum_nm = new int[4];
        //int[] raz_nm = new int[4];
        //int k = 0;
        //int sum_n = 0;
        //int sum_m = 0;
        //for (int i = 0; i < 4; i++)
        //{
        //    sum_nm[k] = n[i] + m[i];
        //    raz_nm[k] = n[i] - m[i];
        //    k++;
        //    Console.WriteLine("sum= "+sum_nm[i]);
        //    Console.WriteLine("raz= " + raz_nm[i]);
        //}

        //4
        //double[] n = { 1,3,4,5,7 };
        //double sum = 0;
        //double sred = 0;
        //for (int i = 0; i < n.Length; i++)
        //{
        //    sum += n[i];
        //}
        //sred = sum / n.Length;
        //for (int i = 0; i < n.Length; i++)
        //{
        //    n[i] -= sred;
        //}
        //Console.WriteLine($"sum = {sum}");
        //for (int i = 0; i < n.Length; i++)
        //{
        //    Console.WriteLine(n[i]);
        //}


        //5
        //int[] n = { 1, 3, 4, 5 };
        //int[] m = { 6, 4, 3, 2 };
        //for (int i = 0; i<4;i++)
        //{
        //    n[i] *= m[i];
        //    Console.WriteLine(n[i]);
        //}


        //6
        //int[] n = { 1, 2, 3, 4, 5 };
        //double l = 0;
        //double sum = 0;
        //for (int i = 0; i < 5; i++)
        //{
        //    sum += n[i] * n[i];
        //    l = Math.Sqrt(sum);          
        //}
        //Console.WriteLine(l);


        //7
        //int[] n = { 1, 2, 3, 4, 5, 6, 7 };
        //double sum = 0;
        //double sred = 0;
        //for (int i = 0; i < n.Length; i++)
        //{
        //    sum += n[i];
        //}
        //sred = sum / n.Length;
        //Console.WriteLine($"srednee: {sred}");
        //for (int i = 0; i < n.Length; i++)
        //{
        //    if (n[i]>sred)
        //    {
        //        n[i] = 0;
        //    }
        //    Console.WriteLine(n[i]);
        //}


        //8
        //int[] n = { 1, 2, -4, -5, 3, -8, 9 };
        //int k = 0;
        //for (int i = 0; i < 7; i++)
        //{
        //    if (n[i] < 0)
        //    {
        //        k++;
        //    }
        //}
        //Console.WriteLine(k);


        //9
        //int[] n = { 1, 2, 4, 5, 3, 8, 9 };
        //int k = 0;
        //double sum = 0;
        //double sred = 0;
        //for (int i = 0; i < n.Length; i++)
        //{
        //    sum += n[i];
        //}
        //sred = sum / n.Length;
        //Console.WriteLine($"srednee: {sred}");
        //for (int i = 0; i < 7; i++)
        //{
        //    if (n[i] > sred)
        //    {
        //        k++;
        //    }
        //}
        //Console.WriteLine(k);


        //10
        //int[] n = { 1, 2, 3, 4, 5, 6, 7,8,9,10 };
        //int p = Int32.Parse(Console.ReadLine());
        //int q = Int32.Parse(Console.ReadLine());
        //int k = 0;
        //for (int i = 0; i < n.Length; i++)
        //{
        //    if (p<q)
        //    {
        //        if (p < n[i] && n[i] < q)
        //        {
        //            k++;
        //        }
        //    }            
        //}
        //Console.WriteLine(k);


        ////11
        //int[] n = { 1, 2, -3, -2, 8, 5, -7, 4, 9, 13 };
        //int[] m = new int[10];
        //int k = 0;
        //for(int i = 0; i<10;i++)
        //{
        //    if (n[i] > 0)
        //    {
        //        m[k] = n[i];
        //        k++;

        //        if (k == 10)
        //        {
        //            break;
        //        }
        //    }
        //}
        //for(int i = 0; i<k; i++)
        //{
        //    Console.WriteLine(m[i]);
        //}


        //12
        //int[] n = { 1, 2, -3, -2, 8, 5, -7, 4 };
        //for(int i = 7; i >= 0; i-=1)
        //{
        //    if (n[i] < 0)
        //    {
        //        Console.WriteLine($"value: {n[i]}");
        //        Console.WriteLine($"number: {n[i]}");
        //        break;
        //    }
        //}


        //13
        //int[] n = { 1, 2, -3, -2, 8, 5, -7, 4, 9, 13 };
        //int[] ch = new int[5];
        //int[] nech = new int[5];
        //int k = 0;
        //for (int i = 0; i < 10; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        ch[i / 2] = n[i];
        //    }
        //    else
        //    {
        //        nech[i / 2] = n[i];
        //    }
        //}
        //for (int i = 0; i < ch.Length; i++)
        //{
        //    Console.WriteLine($"first, chet: {ch[i]}");
        //}
        //for (int i = 0; i < nech.Length; i++)
        //{
        //    Console.WriteLine($"second, nechet: {nech[i]}");
        //}


        //14
        //int[] n = { 1, 2, 3, -2, 8, 5, -7, 4, 9, 13,11 };
        //int sum = 0;
        //for (int i = 0; i < 11; i++)
        //{
        //    sum += n[i] * n[i];
        //    if (n[i] < 0)
        //    {
        //        break;
        //    }
        //    Console.WriteLine(sum);
        //}


        //15
        //double[] x = { 1, 2, 3,6,8,5,7,4,9,13};
        //double[] y = new double[10];
        //for(int i = 0; i < 10; i++)
        //{
        //    y[i] = 0.5 * Math.Log(x[i]);
        //}

        //for(int i = 0; i<x.Length; i++)
        //{
        //    Console.WriteLine($"x: {x[i]}");
        //}

        //for(int i = 0; i<y.Length; i++)
        //{
        //    Console.WriteLine($"y: {y[i]}");
        //}


        //level 2
        //1
        //int[] n = { 7, 4, 8, 6, 3, 1, 4 };
        //int minn = 0;
        //for (int i = 0; i<n.Length; i++)
        //{
        //    if (n[i] < n[i + 1])
        //    {
        //        minn = n[i];
        //    }
        //    Console.WriteLine(minn);
        //}


        //2 
        //int[] n = { 7, 4, 8, 6, 3, 1, 4 };
        //int maxx = 0;
        //int sum = 0;
        //int ind = -1;
        //for (int i = 0; i < n.Length; i++)
        //{
        //    if (n[i] > maxx)
        //    {
        //        maxx = n[i];
        //        ind = i;
        //    }
        //    Console.WriteLine("max " + maxx);
        //}
        //for(int i =0; i<n.Length; i++)
        //{
        //    if(i<ind)
        //    {
        //        sum += n[i];
        //    }
        //}
        //Console.WriteLine("sum= " + sum);


        //3 
        //int[] n = { 10, 4, 2, 20, 8, 9, 12 };
        //int[] m = new int[7];
        //int minn = 10000000;
        //int ind = -1;
        //for (int i = 0; i < n.Length; i++)
        //{
        //    if (n[i] < minn)
        //    {
        //        minn = n[i];
        //        ind = i;
        //    }
        //}

        //for(int i = 0; i<n.Length; i++)
        //{
        //    if (i<ind)
        //    {
        //        n[i] *= 2;
        //    }
        //    Console.WriteLine(n[i]);
        //}


        //4
        //int[] n = { 4, 2, 6, 7, 5, 9, 3,6,2 };

        //int maxx = 0;
        //int sum = 0;
        //int ind = -1;
        //int sred = 0;
        //for (int i = 1; i < n.Length; i++)
        //{
        //    sum += n[i];
        //    if (n[i]>maxx)
        //    {
        //        maxx = n[i];
        //        ind = i;
        //    }
        //}
        //sred = sum / n.Length;
        //for(int i = 0; i < n.Length; i++)
        //{
        //    if (i > ind)
        //    {
        //        n[i] = sred;
        //    }
        //    Console.WriteLine(n[i]);
        //}


        //5
        //int[] n = { 3, -5, 4, 1,-2,-4, 9, -7, -2, 8 };
        //int maxx = -100;
        //int minn = 100;
        //int indmax = -1;
        //int indmin = -1;
        //for(int i =0; i < n.Length; i++)
        //{
        //    if (n[i]>maxx)
        //    {
        //        maxx = n[i];
        //        indmax = i;
        //    }
        //    if ( n[i] < minn)
        //    {
        //        minn = n[i];
        //        indmin = i;
        //    }
        //}
        //if (indmax > indmin)
        //{
        //    int x = indmax;
        //    indmax = indmin;
        //    indmin = x;
        //}
        //int y = 0;
        //for(int i = indmax + 1; i < indmin; i++)
        //{
        //    if (n[i] < 0)
        //    {
        //        y++;
        //    }
        //}
        //int[] m = new int[y];
        //int j = 0;
        //for(int i = indmax + 1; i < indmin; i++)
        //{
        //    if (n[i] < 0)
        //    {
        //        m[j] = n[i];
        //        Console.WriteLine(m[j]);
        //        j++;
        //    }
        //}


        //6
        //int[] n = { 1, 4, 2, 5, 3, 6, 7 };
        //int p = 5;
        //int sum = 0;
        //int sred = 0;
        //int minn = 100;
        //int ind = -1;
        //for(int i = 0; i<n.Length; i++)
        //{
        //    sum += n[i];
        //}
        //sred = sum / n.Length;
        //for(int i = 0;i<n.Length;i++)
        //{
        //    int f = Math.Abs(n[i] - sred);
        //    if(f<minn)
        //    {
        //        minn = f;
        //        ind = i;
        //    }
        //}
        //int[] m = new int[n.Length + 1];
        //for (int i = 0; i<= ind; i++)
        //{
        //    m[i] = n[i];
        //}
        //m[ind + 1] = p;

        //for(int i = ind+2;i<= n.Length; i++)
        //{
        //    m[i] = n[i - 1];
        //}

        //for(int i = 0; i<n.Length;i++)
        //{
        //    Console.WriteLine(m[i]);
        //}


        //7
        //int[] n = { 1, 6, 3, 9, 5, 2 };
        //int maxx = 0;
        //int ind = -1;
        //for(int i = 0; i<n.Length; i++)
        //{
        //    if (n[i]> maxx)
        //    {
        //        maxx = n[i];
        //        ind = i;
        //    }
        //}
        //n[ind + 1] *= 2;
        //for(int i = 0; i < n.Length; i++)
        //{
        //    Console.WriteLine(n[i]);
        //}


        //8
        //int[] n = { 1, 6, 2, 5, 9, 3, 7 };
        //int maxx = 0;
        //int minn = 100;
        //int indmax = -1;
        //int indmin = -1;
        //for(int i = 0; i< n.Length; i++)
        //{
        //    if (n[i] > maxx)
        //    {
        //        maxx = n[i];
        //        indmax = i;
        //    }
        //}
        //for(int i = indmax+1; i<n.Length; i++)
        //{
        //    if (n[i] < minn)
        //    {
        //        minn = n[i];
        //        indmin = i;
        //    }
        //}
        //int a = n[indmax];
        //n[indmax] = n[indmin];
        //n[indmin] = a;
        //for(int i = 0; i < n.Length; i++)
        //{
        //    Console.WriteLine(n[i]);
        //}


        //9
        //int[] n = { 1, 5, 3, 7, 4, 9, 4, 6 };
        //int maxx = 0;
        //int minn = 100;
        //double sum = 0;
        //int indmax = -1;
        //int indmin = -1;
        //double sred = 0;
        //for(int i = 0; i<n.Length; i++)
        //{
        //    if (n[i] > maxx)
        //    {
        //        maxx = n[i];
        //        indmax = i;
        //    }
        //    if (n[i] < minn)
        //    {
        //        minn = n[i];
        //        indmin = i;
        //    }
        //}
        //if (indmax > indmin)
        //{
        //    int x = indmax;
        //    indmax = indmin;
        //    indmin = x;
        //}
        //for(int i = indmax + 1; i < indmin; i++)
        //{
        //    sum += n[i];
        //}
        //sred = indmin - indmax - 1;
        //Console.WriteLine(sum / sred);


        //10
        //int[] n = { -3, 6, 4, 9, -7, -4, 1, 8, 2 };
        //int minn = 100;
        //int ind = -1;
        //for(int i = 0; i< n.Length; i++)
        //{
        //    if (n[i] < minn & n[i]>0)
        //    {
        //        minn = n[i];
        //        ind = i;
        //    }
        //}
        //int[] m = new int[n.Length - 1];
        //for(int i = 0; i< ind; i++)
        //{
        //    m[i] = n[i];
        //}
        //for(int i = ind; i<n.Length-1; i++)
        //{
        //    m[i] = n[i + 1];
        //}
        //for(int i = 0; i < n.Length-1; i++)
        //{
        //    Console.WriteLine(m[i]);
        //}


        //11
        //int[] n = { 1, 7, 4, 3, 8, -5, -7, 6, -9 };
        //int p = 5;
        //int ind = -1;
        //for(int i = 0; i<n.Length; i++)
        //{
        //    if (n[i]>0)
        //    {
        //        ind = i;
        //    }
        //}
        //int[] m = new int[n.Length + 1];
        //for(int i = 0; i<= ind; i++)
        //{
        //    m[i] = n[i];
        //}
        //m[ind + 1] = p;
        //for(int i = ind +2; i<=n.Length; i++)
        //{
        //    m[i] = n[i - 1];
        //}
        //for(int i = 0; i<= n.Length; i++)
        //{
        //    Console.WriteLine(m[i]);
        //}


        //12 
        //int[] n = { 1, 3, 4, -8, 9, 5, 4 };
        //int maxx = -100;
        //int indmax = -1;
        //int indotr = -1;
        //bool fl = true;
        //int sum = 0;
        //for(int i = 0; i< n.Length; i++)
        //{
        //    if (n[i] > maxx)
        //    {
        //        maxx = n[i];
        //        indmax = i;
        //    }
        //    if (n[i] < 0 & fl == true)
        //    {
        //        indotr = i;
        //        fl = false;
        //    }
        //}
        //for(int i = indmax + 1; i < n.Length; i++)
        //{
        //    sum += n[i];
        //}
        //n[indotr] = sum / (n.Length - indmax - 1);
        //for(int i = 0; i < n.Length; i++)
        //{
        //    Console.WriteLine(n[i]);
        //}


        //13
        //int[] n = { 2, 6, 4, 1, 8, 7, 5, 9 };
        //int ind = -1;
        //int maxx = 0;
        //int sum = 0;
        //for(int i = 0; i < n.Length; i++)
        //{
        //    if (n[i]>maxx & i % 2 == 0)
        //    {
        //        maxx = n[i];
        //        ind = i;
        //    }
        //}
        //n[ind] = ind;
        //for(int i = 0; i < n.Length; i++)
        //{
        //    Console.WriteLine(n[i]);
        //}


        //14
        //int[] n = { 2, 6, 4, -7, -3, 5 };
        //int maxx = -100;
        //int indmax = -1;
        //int indotr = -1;
        //bool flag = true;
        //for(int i = 0; i < n.Length; i++)
        //{
        //    if (n[i] > maxx)
        //    {
        //        maxx = n[i];
        //        indmax = i;
        //    }
        //    if (n[i] < 0)
        //    {
        //        if (flag == true)
        //        {
        //            indotr = i;
        //            flag = false;
        //        }
        //    }
        //}
        //int x = n[indmax];
        //n[indmax] = n[indotr];
        //n[indotr] = x; 
        //for(int i = 0; i < n.Length; i++)
        //{
        //    Console.WriteLine(n[i]);
        //}


        //15
        //int n = Int32.Parse(Console.ReadLine());
        //int[] a = new int[n];
        //for(int i = 0; i<n; i++)
        //{
        //    a[i] = Int32.Parse(Console.ReadLine());
        //}

        //int m = Int32.Parse(Console.ReadLine());
        //int[] b = new int[n];
        //for (int i = 0; i < m; i++)
        //{
        //    b[i] = Int32.Parse(Console.ReadLine());
        //}

        //int k = Int32.Parse(Console.ReadLine());
        //int[] ab = new int[n + m];

        //for(int i = 0; i < k; i++)
        //{
        //    ab[i] = a[i];
        //}

        //for(int i = k; i < m + k; i++)
        //{
        //    ab[i] = b[i - k];
        //}

        //for(int i = m + k; i < n + m; i++)
        //{
        //    ab[i] = a[i - m];
        //}

        //for(int i = 0; i< n+ m; i++)
        //{
        //    Console.WriteLine(ab[i]);
        //}


        //16
        //int[] n = { 2, 6, 3, 8, 1, 5, 7 };
        //int sum = 0;
        //int sred = 0;
        //int k = 0;
        //for(int i = 0; i < n.Length; i++)
        //{
        //    sum += n[i];
        //}
        //sred = sum / n.Length;
        //for(int i = 0; i < n.Length; i++)
        //{
        //    if (n[i]<sred)
        //    {
        //        k++;
        //    }
        //}

        //int[] aind = new int[k];
        //int j = 0;
        //for(int i = 0; i<n.Length;i++)
        //{
        //    if (n[i] < sred)
        //    {
        //        aind[j] = i;
        //        Console.WriteLine(aind[j]);
        //        j++;
        //    }
        //}


        //17
        //int[] n = { 2, 5, 3, 7, 1, 9, 5, 7, 2 };
        //int maxx = 0;
        //int minn = 100;
        //int indmax = -1;
        //int indmin = -1;
        //int k1 = 0;
        //int k2 = 0;
        //double sred = 0;
        //int sum1 = 0;
        //int sum2 = 0;
        //for(int i = 0; i< n.Length;i++)
        //{
        //    if (n[i] > maxx)
        //    {
        //        maxx = n[i];
        //        indmax = i;
        //    }
        //    if (n[i] < minn)
        //    {
        //        minn = n[i];
        //        indmin = i;
        //    }
        //    if (n[i] > 0)
        //    {
        //        sum1 += n[i];
        //        k1++;
        //    }
        //    if (n[i] < 0)
        //    {
        //        sum2 += n[i];
        //        k2++;
        //    }
        //}

        //for(int i = indmax + 1; i < n.Length; i++)
        //{
        //    if (n[i] < minn)
        //    {
        //        minn = n[i];
        //        indmin = i;
        //    }
        //}

        //if (indmax > indmin)
        //{
        //    sred = sum1 / k1;
        //}
        //else
        //{
        //    sred = sum2 / k2; 
        //}
        //Console.WriteLine(sred);


        //18
        //int[] n = { 6, 3, 9, 2, 8, 5, 1, 7 };
        //int max_first = 0;
        //int max_second = 0;
        //int first = 0;
        //int second = 0;
        //for(int i = 0; i < n.Length; i++)
        //{
        //    if (n[i]>max_first & i % 2 == 0)
        //    {
        //        max_first = n[i];
        //    }
        //    if (n[i] > max_second & i % 2 == 1)
        //    {
        //        max_second = n[i];
        //    }
        //}
        //if (max_first > max_second)
        //{
        //    first = 0;
        //    second = (n.Length - n.Length % 2) / 2;
        //}
        //else
        //{
        //    first = (n.Length - n.Length % 2) / 2;
        //    second = 0;
        //}

        //for(int i = first; i<second;i++)
        //{
        //    n[i] = 0;
        //}

        //for(int i = 0; i <n.Length; i++)
        //{
        //    Console.WriteLine(n[i]);
        //}


        //19
        //int[] n = { 1, 6, 3, 8, 5, 6, 3, 9, 4, 7 };
        //int maxx = 0;
        //int ind = -1;
        //int sum = 0;
        //for(int i = 0; i < n.Length; i++)
        //{
        //    sum += n[i];
        //    if (n[i] > maxx)
        //    {
        //        maxx = n[i];
        //        ind = i;
        //    }
        //}
        //if(maxx > sum)
        //{
        //    n[ind] = 0;
        //}
        //else
        //{
        //    n[ind] *= 2;
        //}

        //for(int i = 0; i < n.Length; i++)
        //{
        //    Console.WriteLine(n[i]);
        //}



        //20
        //int[] n = { 1,5, 2, -7, 3, 8, 4 };
        //int minn = 100;
        //int sum = 0;
        //int ind1 = -1;
        //int ind2 = -1;
        //int first = -1;
        //bool fl = true;
        //for(int i = 0; i<n.Length; i++)
        //{
        //    if (n[i] < minn)
        //    {
        //        minn = n[i];
        //        ind1 = i;
        //    }
        //    if (n[i] < 0 & fl == true)
        //    {
        //        ind2 = i;
        //        fl = false;
        //    }
        //}
        //if (ind2 < ind1)
        //{
        //    first = 0;
        //}
        //else
        //{
        //    first = 1;
        //}
        //for(int i = first; i< n.Length; i+=2)
        //{
        //    sum += n[i];
        //}
        //Console.WriteLine(sum);


        //level 3
        //2
        //int[] n = { 1, 4, 6, 2, 7, 9, 5 };
        //int ind = -1;
        //int maxx = 0;
        //int k = 1;
        //for(int i = 0; i < n.Length; i++)
        //{
        //    maxx = n[i];
        //    ind = i;
        //    if (n[i] == maxx)
        //    {
        //        n[i] += k;
        //        k++;
        //    }

        //    Console.WriteLine(n[i]);
        //}


        //3
        int[] n = { 2, 5, 4, 7, 5,3, 9, 1 };
        int maxx = 0;
        int ind = -1;
        for (int i = 0; i<n.Length; i++)
        {
            if (n[i] > maxx)
            {
                maxx = n[i];
                ind = i;
            }
        }
        for (int i = 0; i < ind-1; i += 2)
        {
            int x = n[i];
            n[i] = n[i + 1];
            n[i + 1] = x;
        }
        foreach(int numb in n)
        {
            Console.WriteLine(numb);
        }
    }
}