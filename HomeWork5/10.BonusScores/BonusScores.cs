using System;

class BonusScores
{
    static void Main()
    {
        Console.WriteLine("Enter a number between 1 and 9");
        int score;
        int.TryParse(Console.ReadLine(), out score);


        switch (score)
        {

            case 1:
            case 2:
            case 3:
                Console.Write("you increased your price by 10 and now you have ",score);
                break;
            case 4:
            case 5:
            case 6:
                Console.Write("you increased your price by 100 and now you have ",score);
                break;
            case 7:
            case 8:
            case 9:
                Console.Write("you increased your price by 1000 and now you have ",score);
                break;
            default: Console.WriteLine("error");
                break;
        }

        if ((score >= 1) && (score <= 3))
        {
            Console.WriteLine(score * 10);
        }
        if ((score >= 4) && (score <= 6))
        {
            Console.WriteLine(score * 100);
        }

        if ((score >= 7) && (score <= 9))
        {
            Console.WriteLine(score * 1000);
        }
    }
}

    