using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your third number: ");
        double c = double.Parse(Console.ReadLine());
        double x1;
        double x2;
        double x;

        double D = b * b- 4* a * c;

        if (D > 0)
        {
            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("There are two roots :{0} and {1}",x1,x2);
        }
        else if (D < 0)
        {
            Console.WriteLine("There are no possible solutions");
        }
        else if (D == 0)
        {
            x = (-b + Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("One real solution");
        }


    }
}

