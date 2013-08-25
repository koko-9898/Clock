using System;

class FindMaxSum3x3OfMatrix
{
    static void Main()
    {
        Console.WriteLine("Insert N rows");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert M colums");
        int m = int.Parse(Console.ReadLine());
        int[,] table = new int[n, m];

        Console.WriteLine("Write the first row elements");
        for (int i = 0; i < n; i++)
        {
            if (i != 0)
                Console.WriteLine("Write the next row elements");
            {
                for (int j = 0; j < m; j++)
                {
                    table[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        int sum = 0;
        int bestSum = 0;
        int startRow = 0;
        int startCol = 0;

        for (int i = 0; i < table.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < table.GetLength(1) - 2; j++)
            {
                for (int row = i; row < i + 3; row++)
                {
                    for (int col = j; col < j + 3; col++)
                    {
                        sum += table[row, col];
                    }
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        startRow = i;
                        startCol = j;
                    }

                }
                sum = 0;
            }
        }
        Console.WriteLine("the largest sum is {0}", bestSum);


        for (int i = startRow; i < startRow + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                Console.Write(table[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}




















