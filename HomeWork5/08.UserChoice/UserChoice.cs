using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter Number 1 for INT , Number 2 for Double , Number 3 for String");
        int user=int.Parse(Console.ReadLine());
        switch (user)
        {
                
            case 1: int first = int.Parse(Console.ReadLine());
                Console.WriteLine(first + 1);break;
            case 2: double second = double.Parse(Console.ReadLine());
                Console.WriteLine(second + 1);break;
            case 3: string third = Console.ReadLine();
                Console.WriteLine(third + "*");
                break;



            default: Console.WriteLine("Wrong choice !");
                break;
        }
    }
}

