using System;

class FindClosestNUm
{
    static void Main()
    {
        Console.WriteLine("Please enter how many numbers you will use");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        
        Console.WriteLine("Enter the numbers");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());

        }
        Array.Sort(arr);

        Console.WriteLine("Numbers after sorting ");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
        Console.WriteLine();

        Console.WriteLine("Enter K number");
        int k = int.Parse(Console.ReadLine());
        

        int index = Array.BinarySearch(arr, k);

        Console.WriteLine("K = {0}", k);

        while (true)
        {
            if (index < 0)
            {
                k--;
                index = Array.BinarySearch(arr, k);
            }
            else if (index <= k)
            {
                Console.WriteLine("the best element that is <=  is {0}", arr[index]);
                break;
            }
            else
            {
                Console.WriteLine("There is no such element");
                break;
            }
        }
    }
}