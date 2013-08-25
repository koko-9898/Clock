using System;

class TheSign
{
    static void Main()
    {
        Console.WriteLine("Enter your first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter yout second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your third number: ");
        int c = int.Parse(Console.ReadLine());

        if (a > 0)
        {
            if (b > 0)
            {
                if (c > 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
            else if (c > 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }

        }
        else
        {
            if (b > 0)
            {
                if (c > 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }

            else if (c > 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}