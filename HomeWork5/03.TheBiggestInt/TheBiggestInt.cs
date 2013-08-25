using System;

class TheBiggestInt
{
    static void Main()
    {
        Console.WriteLine("first number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("second number");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("third number");
        int c = int.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("The biggest Number is: {0}",a);
            }
            else  
            {
                Console.WriteLine("The biggest Number is: {0}",c);
            }
        }
        else if (b > a)
        {
            if (b > c)
            {
                Console.WriteLine("The biggest Number is: {0}",b);
            }
            else 
            {
                Console.WriteLine("The biggest Number is: {0}",c);
            }
            
        }
        else if (c > a)
        {
            if (c > b)
            {
                Console.WriteLine("The biggest Number is: {0}", c);
            }
            else
            {
                Console.WriteLine("The biggest Number is: {0}",a);
            }
            
        }
    }
}
