using System;

class ElementAtGivenPosition
{
    static void Main()
    {
        int[] table = { 6, 4, 5, 6, 3, 6, 4, 5, 6, 3, 4, 6, 3, 4 };
        int position = 4;
        CheckBigger(table, position);

    }
    static void CheckBigger(int[] table, int position)
    {
        if ((table.Length == 1) || (position == 0 && table[position] > table[position + 1]) ||
            (position == table.Length - 1 && table[position] > table[position - 1]) ||
            ((position > 0 && position < table.Length - 1) &&
            (table[position] > table[position - 1]) && (table[position] > table[position + 1])))
        {
            Console.WriteLine("The element {0} at position {1} IS bigger than its neighbours.", table[position], position);

        }
        else
        {
            Console.WriteLine("The element {0} at position {1} is NOT bigger than its neighbours.", table[position], position);
        }
    }
}