using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter A number for the N of the matrix");
        int n = int.Parse(Console.ReadLine());
        int[,] table = new int[n, n];
        int number = 1;

        for (int i = 0; i < table.GetLength(0); i++)
        {
            Console.WriteLine("Enter your numbers");
            for (int j = 0; j < table.GetLength(1); j++)
            {
                table[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int row = 0; row < table.GetLength(0); row++)
        {
            for (int col = 0; col < table.GetLength(1); col++)
            {
                Console.Write("{0,4}", table[col, row]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    table[row, col] = number;
                    number++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    table[row, col] = number;
                    number++;
                }
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,3}", table[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        table = new int[n, n];
        number = 1;

        // Fill Matrix
        for (int row = 0; row < table.GetLength(0); row++)
        {
            for (int col = 0; col <= row; col++)
            {
                table[n - row + col - 1, col] = number++;
            }
        }

        for (int row = n - 2; row >= 0; row--)
        {
            for (int col = row; col >= 0; col--)
            {
                table[row - col, n - col - 1] = number++;
            }
        }

        // Print Matrix
        for (int row = 0; row < table.GetLength(0); row++)
        {
            for (int col = 0; col < table.GetLength(1); col++)
            {
                Console.Write("{0,3}", table[row, col]);
            }
            Console.WriteLine();          
        }
    }
}



