using System;

class SortStringsByTheirLength
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string [] table = new string [n];

        Console.WriteLine("Please enter the number in the array");
        for (int i = 0; i < n; i++)
        {
            table[i] = (Console.ReadLine());
        }

        Array.Sort(table, (x, y) => (x.Length).CompareTo(y.Length));
        Console.WriteLine("Sorted Array is :");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(table[i]);
        }
    }
}