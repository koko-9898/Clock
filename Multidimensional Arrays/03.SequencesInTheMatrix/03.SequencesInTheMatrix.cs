using System;
using System.Linq;

class SequencesInTheMatrix
{
    static void Main()
    {
        string[,] matrix = {
            {"ha", "fifi", "ho", "hi"},
            {"fo", "ha", "hi", "xx"},
            {"xxx", "ho", "ha", "xx"},
        };
        

        int horisontal = 1;
        int vertical = 1;
        int diagonalR = 1;
        int diagonalL = 1;

        int horisontalMax = 1;
        int verticalMax = 1;
        int diagonalRMax = 1;
        int diagonalLMax = 1;

        string elementH = "";
        string elementV = "";
        string elementDR = "";
        string elementDL = "";

        int row = 0;


       // Horisontals
        for (row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    horisontal++;
                    if (horisontal >= horisontalMax)
                    {
                        elementH = matrix[row, col];
                        horisontalMax = horisontal;
                    }
                }
                else
                {
                    horisontal = 1;
                }
            }
        }
       
        // Verticals
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    vertical++;
                    if (vertical >= verticalMax)
                    {
                        elementV = matrix[row, col];
                        verticalMax = vertical;
                    }
                }
                else
                {
                    vertical = 1;
                }
            }
        }
        
        // DiagonalRight
        for (int i = 0; i <= matrix.GetLength(0); i++)
        {
            for (int j = 0; j <= matrix.GetLength(1); j++)
            {
                int col = j;
                row = i;

                if (col >= matrix.GetLength(1) - 1 || row >= matrix.GetLength(0) - 1)
                {
                    break;
                }
                else
                {
                    while (col < matrix.GetLength(1) - 1 && row < matrix.GetLength(0) - 1) //Move to Diagonal
                    {
                        if (matrix[row, col] == matrix[row + 1, col + 1]) 
                        {
                            diagonalR++;
                            if (diagonalR >= diagonalRMax)
                            {
                                elementDR = matrix[row, col];
                                diagonalRMax = diagonalR;
                            }
                            row++;
                            col++;
                        }
                        else 
                        {
                            diagonalR = 1;
                            break;
                        }
                    }
                    diagonalR = 1;
                }
            }
        }
        
        //DiagonalLeft
        for (int i = 0; i <= matrix.GetLength(0); i++)
        {
            for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
            {
                int col = j;
                row = i;

                if (col <= 1 || row >= matrix.GetLength(0) - 1)
                {
                    break;
                }
                else
                {
                    while (col > 0 && row < matrix.GetLength(0) - 1) //Move to Diagonal
                    {
                        if (matrix[row, col] == matrix[row + 1, col - 1]) 
                        {
                            diagonalL++;
                            if (diagonalL >= diagonalLMax)
                            {
                                elementDL = matrix[row, col];
                                diagonalLMax = diagonalL;
                            }
                            row++;
                            col--;
                        }
                        else
                        {
                            diagonalL = 1;
                            break;
                        }
                    }
                    diagonalL = 1;
                }
            }
        }
       
        //Fill MaxLenght of SameElements
        int[] maxLenght = new int[4];
        maxLenght[0] = horisontalMax;
        maxLenght[1] = verticalMax;
        maxLenght[2] = diagonalRMax;
        maxLenght[3] = diagonalLMax;

        //Fill Elements with maxLenght Element
        string[] elements = new string[4];
        elements[0] = elementH;
        elements[1] = elementV;
        elements[2] = elementDR;
        elements[3] = elementDL;

        //Print 
        for (int i = 0; i < 4; i++)
        {
            if (maxLenght.Max() == maxLenght[i])
            {
                for (int j = 0; j < maxLenght.Max(); j++)
                {
                    if (j < maxLenght.Max() - 1)
                    {
                        Console.Write(elements[i] + ",");
                    }
                    else
                    {
                        Console.Write(elements[i]);
                    }
                }
                Console.WriteLine();
                break;
            }
        }
    }
}