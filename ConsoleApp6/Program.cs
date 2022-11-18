using System;

class GFG
{

    static int MatrixChainOrder(int[] p, int i, int j)
    {

        if (i == j)
            return 0;

        int min = int.MaxValue;

        for (int k = i; k < j; k++)
        {
            int count = MatrixChainOrder(p, i, k) +
                        MatrixChainOrder(p, k + 1, j) +
                        p[i - 1] * p[k] * p[j];

            if (count < min)
                min = count;
        }

        // Return minimum count
        return min;
    }

    public static void Main()
    {
        int[] arr = new int[] { 1, 2, 3, 4, 3 };
        int n = arr.Length;

        Console.Write("Minimum number of multiplications is "
                      + MatrixChainOrder(arr, 1, n - 1));
    }
}
