using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a digit in the range [1...10]: ");
        int Digit = int.Parse(Console.ReadLine());
        switch (Digit)
        {
            case 1: Console.WriteLine("One"); 
                break;
            case 2: Console.WriteLine("Two"); 
                break;
            case 3: Console.WriteLine("Three");
                break;
            case 4: Console.WriteLine("Four");
                break;
            case 5: Console.WriteLine("Five");
                break;
            case 6: Console.WriteLine("Six");
                break;
            case 7: Console.WriteLine("Seven"); 
                break;
            case 8: Console.WriteLine("Eight");
                break;
            case 9: Console.WriteLine("Nine");
                break;
            case 10: Console.WriteLine("Ten"); 
                break;
            case 11: Console.WriteLine("Eleven");
                break;
            case 12: Console.WriteLine("Twelve");
                break;
            default: Console.WriteLine("Error!!!");
                break;
        }
    }
}

