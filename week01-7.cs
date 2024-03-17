using System;
public class Week01_7
{
    static void Main()
    {
        int x = 10;

        if (x == 0)
        {
            System.Console.WriteLine("x는 0");
        }
        else
        {
            if (x % 2 == 0)
            {
                System.Console.WriteLine("x는 짝수");
            }
            else
            {
                System.Console.WriteLine("x는 홀수");
            }
        }

        if (x > 5 && x < 10)
        {
            System.Console.WriteLine("x는 5보다 크고 10보다 작다");
        }

        if (x > 5)
        {
            if (x < 10)
            {
                System.Console.WriteLine("x는 5보다 크고 10보다 작다");
            }
        }

        int score = 78;

        if (score >= 90)
        {
            System.Console.WriteLine("학점 : A+");
        }
        else if (score >= 80)
        {
            System.Console.WriteLine("학점 : B+");
        }
        else if (score >= 70)
        {
            System.Console.WriteLine("학점 : C+");
        }
        else if (score >= 60)
        {
            System.Console.WriteLine("학점 : D");
        }
        else
        {
            System.Console.WriteLine("학점 : F");
        }

        string grade = "A+";
        switch (grade)
        {
            case "A+":
                System.Console.WriteLine("학점 : 4.5");
                break;
            case "A":
                System.Console.WriteLine("학점 : 4.0");
                break;
            case "B+":
                System.Console.WriteLine("학점 : 3.5");
                break;
            case "B":
                System.Console.WriteLine("학점 : 3.0");
                break;
            case "C+":
                System.Console.WriteLine("학점 : 2.5");
                break;
            default:
                System.Console.WriteLine("학점 : 0");
                break;
        }


    }
}
