using System;
public class Week01_8
{
    static void Main()
    {
        for ( int index = 0; index < 10; ++index)
        {
            System.Console.WriteLine(index);
        }

        for (int x = 1; x < 10; ++x)
        {
            for (int y = 1; y < 10; ++y)
            {
                System.Console.WriteLine($"{x} x {y} = {x * y}");
            }
        }

        int index2 = 1, result = 0;
        while ( index2 <= 100 )
        {
            result += index2;
            index2++;
        }
        System.Console.WriteLine($"1부터 100까지의 합 : {result}");
    }
}
