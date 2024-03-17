using System;
public class Week01_8
{
    static void Main()
    {
        int[] enemys = new int[5];

        System.Console.WriteLine($"배열의 타입 : {enemys.GetType()}");
        System.Console.WriteLine($"배열의 기본 타입 : {enemys.GetType().BaseType}");

        System.Console.WriteLine("== 정렬 전 ==");
        for ( int index = 0; index < enemys.Length; ++index)
        {
            enemys[index] = 100 - (index * 10);

            System.Console.WriteLine(enemys[index]);
        }

        Array.Sort(enemys);

        System.Console.WriteLine("== 정렬 후 ==");
        for (int index = 0; index < enemys.Length; ++index)
        {
            System.Console.WriteLine(enemys[index]);
        }

        int[][] array = new int[3][];

        array[0] = new int[3] { 1, 2, 3 };
        array[1] = new int[] { 10, 20, 30, 40 };
        array[2] = new int[] { 100, 200, 300, 400, 500 };

        for (int i = 0; i < array.Length; ++i)
        {
            for ( int j = 0; j < array[i].Length; ++j)
            {
                System.Console.WriteLine($"array[{i}][{j}] = {array[i][j]}");
            }
        }
    }
}
