using System;

class ExchangingValues
{
    static void Main()
    {
        Console.WriteLine("Enter A");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter B");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            int c = a;
            a = b;
            b = c;

            Console.WriteLine("The first Number is now {0}:", a);
            Console.WriteLine("The second Number is now {0}:", b);
        }
        else
        {
            Console.WriteLine("There is no exchange :)");
        }
    }
}

        

 
