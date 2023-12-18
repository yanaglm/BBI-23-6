using System;
class Program
{
    //lab5


    //1
    //static int maxelem(int[,] mat)
    //{
    //    int max = mat[0, 0];
    //    for(int i = 0; i < mat.GetLength(0); i++)
    //    {
    //        for(int j = 0; j < mat.GetLength(1); j++)
    //        {
    //            if (mat[i, j] > max)
    //            {
    //                max = mat[i, j];
    //            }
    //        }
    //    }
    //    return max;
    //}

    
    //static void changeelem(ref int [,] a, ref int[,] b)
    //{
    //    int amax = maxelem(a);
    //    int bmax = maxelem(b);
    //    for(int i = 0; i < a.GetLength(0); i++)
    //    {
    //        for(int j = 0; j < a.GetLength(1); j++)
    //        {
    //            if (a[i, j] == amax)
    //            {
    //                a[i, j] = bmax;
    //            }
    //        }
    //    }
    //    for (int i = 0; i < b.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < b.GetLength(1); j++)
    //        {
    //            if (b[i, j] == bmax)
    //            {
    //                b[i, j] = amax;
    //            }
    //        }
    //    }
    //}

    //static void printmat(int[,] mat)
    //{
    //    for (int i = 0; i < mat.GetLength(0); i++)
    //    {
    //        for(int j = 0; j < mat.GetLength(1); j++)
    //        {
    //            Console.Write(mat[i, j] + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //}

    //static void Main(string[] args)
    //{
    //    int[,] a = new int[5, 6] { { 1, 4, 2, 6, 5,30 }, { 6,9,2,4,1,7}, { 2, 4, 6, 3, 9,1 },{ 7, 2, 1, 5, 6,8 },{ 6, 5, 2, 9, 4,3 } };
    //    int[,] b = new int[3, 5] { { 8,5,4,3,1},{ 5, 60, 2, 3, 1 },{ 9, 6, 3, 5, 7 } };

    //    Console.WriteLine("original mat a");
    //    for(int i = 0; i < 5; i++)
    //    {
    //        for(int j = 0;j<6; j++)
    //        {
    //            Console.Write($"{a[i, j]} \t");
    //        }
    //        Console.WriteLine();
    //    }

    //    Console.WriteLine("original mat b");
    //    for (int i = 0; i < 3; i++)
    //    {
    //        for (int j = 0; j < 5; j++)
    //        {
    //            Console.Write($"{b[i, j]} \t");
    //        }
    //        Console.WriteLine();
    //    }

    //    changeelem(ref a, ref b);

    //    Console.WriteLine("mat a");
    //    printmat(a);
    //    Console.WriteLine("mat b");
    //    printmat(b);
    //}




    //7
    //public static void PasteColAfterRowWithMaxPos(int[,] b, int[,] c)
    //{
    //    int maxpospow_ind = MaxPosRow(b);
    //    int[,] new_mat = new int[b.GetLength(0), b.GetLength(1) + 1];

    //    for (int i = 0; i < b.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < b.GetLength(1); j++)
    //        {
    //            new_mat[i, j] = b[i, j];

    //            if (i == maxpospow_ind)
    //            {
    //                new_mat[i, j + 1] = c[i, j];
    //            }
    //        }
    //    }

    //    PrintMat(new_mat);
    //}

    //private static int MaxPosRow(int[,] mat)
    //{
    //    int k_maxpos = 0;
    //    int maxpospow_ind = -1;

    //    for (int i = 0; i < mat.GetLength(0); i++)
    //    {
    //        int k_pos = Get_k_pos(mat, i);

    //        if (k_pos > k_maxpos)
    //        {
    //            k_maxpos = k_pos;
    //            maxpospow_ind = i;
    //        }
    //    }

    //    return maxpospow_ind;
    //}

    //private static int Get_k_pos(int[,] mat, int row_ind)
    //{
    //    int k_pos = 0;

    //    for (int j = 0; j < mat.GetLength(1); j++)
    //    {
    //        if (mat[row_ind, j] > 0)
    //        {
    //            k_pos++;
    //        }
    //    }

    //    return k_pos;
    //}

    //private static void PrintMat(int[,] mat)
    //{
    //    Console.WriteLine("new mat");
    //    for (int i = 0; i < mat.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < mat.GetLength(1); j++)
    //        {
    //            Console.Write($"{mat[i, j]} \t");
    //        }
    //        Console.WriteLine();
    //    }
    //}

    //public static void Main()
    //{
    //    int[,] b = new int[4,4] {{ 6,-4,5,1}, { 8,7,-3,-5 },{3,9,4,2}, { -7,-3,-5,8 } };
    //    int[,] c = { { 3, 6, -9, 2 }, { 8, -6, -3, -7 }, { 2, 4, -1, -5 }, { 5, 3, -1, 7 } };
    //    PasteColAfterRowWithMaxPos(b, c);
    //}



    //13
    //static int FindMaxRow(int[,] mat)
    //{
    //    int maxRow = 0;
    //    int maxElem = mat[0, 0];

    //    for (int i = 0; i < mat.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < mat.GetLength(1); j++)
    //        {
    //            if (mat[i, j] > maxElem)
    //            {
    //                maxElem = mat[i, j];
    //                maxRow = i;
    //            }
    //        }
    //    }

    //    return maxRow;
    //}

    //static int FindMinRow(int[,] mat)
    //{
    //    int minRow = 0;
    //    int minElement = mat[0, 0];

    //    for (int i = 0; i < mat.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < mat.GetLength(1); j++)
    //        {
    //            if (mat[i, j] < minElement)
    //            {
    //                minElement = mat[i, j];
    //                minRow = i;
    //            }
    //        }
    //    }

    //    return minRow;
    //}

    //static int[,] RemoveRows(int[,] mat, int maxRow, int minRow)
    //{
    //    int rows = mat.GetLength(0) - 2; 
    //    int columns = mat.GetLength(1);
    //    int[,] newMat = new int[rows, columns];

    //    int rowInd = 0;

    //    for (int i = 0; i < mat.GetLength(0); i++)
    //    {
    //        if (i != maxRow && i != minRow)
    //        {
    //            for (int j = 0; j < mat.GetLength(1); j++)
    //            {
    //                newMat[rowInd, j] = mat[i, j];
    //            }

    //            rowInd++;
    //        }
    //    }

    //    return newMat;
    //}

    //static void PrintMatrix(int[,] mat)
    //{
    //    for (int i = 0; i < mat.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < mat.GetLength(1); j++)
    //        {
    //            Console.Write(mat[i, j] + "\t");
    //        }

    //        Console.WriteLine();
    //    }
    //}

    //static void Main()
    //{
    //    int[,] mat_a = new int [4,3] { { 4,8,2 }, { 1,6,3 }, { 9,5,7 }, { 5,7,3} };

    //    Console.WriteLine("original");
    //    PrintMatrix(mat_a );

    //    int maxRow = FindMaxRow(mat_a);
    //    int minRow = FindMinRow(mat_a);

    //    int[,] finishMat = RemoveRows(mat_a, maxRow, minRow);

    //    Console.WriteLine("finish");
    //    PrintMatrix(finishMat);
    //}



    //19
    //static int[,] DeleteZeros(int[,] mat)
    //{
    //    int rows = mat.GetLength(0);
    //    int columns = mat.GetLength(1);

    //    int k_nozeros = 0;
    //    for (int i = 0; i < rows; i++)
    //    {
    //        bool zeros = false;
    //        for (int j = 0; j < columns; j++)
    //        {
    //            if (mat[i, j] == 0)
    //            {
    //                zeros = true;
    //                break;
    //            }
    //        }
    //        if (!zeros)
    //        {
    //            k_nozeros++;
    //        }
    //    }

    //    int[,] new_mat = new int[k_nozeros, columns];
    //    int row = 0;
    //    for (int i = 0; i < rows; i++)
    //    {
    //        bool zeros = false;
    //        for (int j = 0; j < columns; j++)
    //        {
    //            if (mat[i, j] == 0)
    //            {
    //                zeros = true;
    //                break;
    //            }
    //        }
    //        if (!zeros)
    //        {
    //            for (int j = 0; j < columns; j++)
    //            {
    //                new_mat[row, j] = mat[i, j];
    //            }
    //            row++;
    //        }
    //    }

    //    return new_mat;
    //}

    //static void PrintMatrix(int[,] mat)
    //{
    //    for (int i = 0; i < mat.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < mat.GetLength(1); j++)
    //        {
    //            Console.Write($"{mat[i, j]} \t");
    //        }
    //        Console.WriteLine();
    //    }
    //}

    //static void Main()
    //{
    //    int[,] mat = new int[4,4] { { 0,4,2,7 }, { 9,3,4,1 }, { 5,9,0,0}, { 6,8,2,4 } };

    //    Console.WriteLine("original");
    //    PrintMatrix(mat);

    //    mat = DeleteZeros(mat);

    //    Console.WriteLine("new mat without zeros");
    //    PrintMatrix(mat);
    //}



    //25
    //static int K_OtrElem(int[,] mat, int row)
    //{
    //    int k = 0;
    //    for (int j = 0; j < mat.GetLength(1); j++)
    //    {
    //        if (mat[row, j] < 0)
    //            k++;
    //    }
    //    return k;
    //}

    //static int MaxOtrInRow(int[,] mat)
    //{
    //    int row_max = 0;
    //    int k_max = K_OtrElem(mat, 0);

    //    for (int i = 1; i < mat.GetLength(0); i++)
    //    {
    //        int k = K_OtrElem(mat, i);
    //        if (k > k_max)
    //        {
    //            k_max = k;
    //            row_max = i;
    //        }
    //    }

    //    return row_max;
    //}

    //static void Main()
    //{
    //    int[,] a = new int [4,4] { { -1, -2, 3,-7 }, { -6,8,3,-1 }, { 2,6,-4,5 },{ 6, -9, -7, 3 } };

    //    int[,] b = new int [4,4] {{6,9,-3,2 },{ 7,-4,6,-8 },{ 2,-7,1,-5 }, { -9, 6, -3, -1 } };

    //    int row_max1 = MaxOtrInRow(a);
    //    int row_max2 = MaxOtrInRow(b);

    //    Console.WriteLine("row with otr elems in mat a - " + row_max1);
    //    Console.WriteLine("row with otr elems in mat b - " + row_max2);
    //}
}