using System;
public class Week01_1
{
    private int value01;
    private int value02, value03, value04;
    private int value05 = 10;
    private int value06 = 10, value07 = 20, value08 = 30;

    private int curHP = 10;
    private readonly int maxHP = 100;
    private const int minHP = 0;

    public void Awake()
    {
        value01 = 1;
        value02 = 2;
        value03 = 3;
        value04 = 4;
    }
    static void Main()
    {
        int curHP = 10;
        int maxHP = 100;
        const int minHP = 0;

        System.Console.WriteLine(curHP);
        System.Console.WriteLine(maxHP);
        System.Console.WriteLine(minHP);
    }

}
