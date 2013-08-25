using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter the first number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the third number ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the fourth number ");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the fifth number ");
        int e = int.Parse(Console.ReadLine());

        int max = a;

        if (b>max)
        {
            max = b;
        }
        if  (c>max)
        {
            max = c;
        }
        if (d>max)
        {
            max = d;
        }
        if (e>max)
        {
            max = e;
        }
        Console.WriteLine("The greatest number is {0}: ",max); 
    }
}

            