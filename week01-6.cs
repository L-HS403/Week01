using System;
public class Week01_6
{
    static void Main()
    {
        int a = 5 + 3;
        int b = a - 4;
        int c = a * b;
        int d = c / 8;
        int e = d % 3;

        System.Console.WriteLine($"{a} = 5 + 3");
        System.Console.WriteLine($"{b} = {a} - 4");
        System.Console.WriteLine($"{c} = {a} * {b}");
        System.Console.WriteLine($"{d} = {c} / 8");
        System.Console.WriteLine($"{e} = {d} % 3");

        int x = 10;
        System.Console.WriteLine($"x = 10 :{x}");

        x += 10;
        System.Console.WriteLine($"x += 10 :{x}"); //20

        System.Console.WriteLine($"x -= 9 :{x -= 9}"); // 11
        System.Console.WriteLine($"x *= 8 :{x *= 8}"); // 88
        System.Console.WriteLine($"x /= 7 :{x /= 7}"); // 12
        System.Console.WriteLine($"x %= 6 :{x %= 6}"); // 0
        System.Console.WriteLine($"x &= 5 :{x &= 5}"); // 0
        System.Console.WriteLine($"x |= 4 :{x |= 4}"); // 4
        System.Console.WriteLine($"x ^= 3 :{x ^= 3}"); // 7 111
        System.Console.WriteLine($"x <<= 2 :{x <<= 2}"); // 28 11100
        System.Console.WriteLine($"x >>= 1 :{x >>= 1}"); // 14 01110

        int y = 10;
        System.Console.WriteLine(y);
        System.Console.WriteLine(y++);
        System.Console.WriteLine(y);
        System.Console.WriteLine(++y);
        System.Console.WriteLine(y);

        x = 5; y = 10;

        System.Console.WriteLine($"{x} > {y} = {x > y}");
        System.Console.WriteLine($"{x} < {y} = {x < y}");
        System.Console.WriteLine($"{x} >= {y} = {x >= y}");
        System.Console.WriteLine($"{x} <= {y} = {x <= y}");
        System.Console.WriteLine($"{x} == {y} = {x == y}");
        System.Console.WriteLine($"{x} != {y} = {x != y}");

        bool result = false;
        result = x > 2 && y != 5;
        System.Console.WriteLine($"{x} > 2 && {y} != 5 = {result}");

        result = x < 2 || y == 5;
        System.Console.WriteLine($"{x} < 2 || {y} === 5 = {result}");

        System.Console.WriteLine(result);
        result = !result;
        System.Console.WriteLine(result);

        int hp = -10;
        hp = hp < 0 ? 0 : hp;
        System.Console.WriteLine($"체력 : {hp}");

        int t = 2; // 0000 0010

        System.Console.WriteLine($"{t} << 1 = {t << 1}"); // 0000 0100 = 4
        System.Console.WriteLine($"{t} << 2 = {t << 2}"); // 0000 1000 = 8
        System.Console.WriteLine($"{t} << 3 = {t << 3}"); // 0001 0000 = 16

        t = 255; // 1111 1111
        System.Console.WriteLine($"{t} >> 1 = {t >> 1}"); // 0111 1111 = 127
        System.Console.WriteLine($"{t} >> 2 = {t >> 2}"); // 0011 1111 = 63
        System.Console.WriteLine($"{t} >> 3 = {t >> 3}"); // 0001 1111 = 31

        t = -255; // 111...1 0000 0001
        System.Console.WriteLine($"{t} >> 1 = {t >> 1}"); // 111...1 1000 0000 = -128
        System.Console.WriteLine($"{t} >> 2 = {t >> 2}"); // 111...1 1100 0000 = -64
        System.Console.WriteLine($"{t} >> 3 = {t >> 3}"); // 111...1 1110 0000 = -32

        System.Console.WriteLine(Convert.ToString(t >> 4, 2)); // 111...1 1111 0000

        System.Console.WriteLine($"10 & 6 = {10 & 6}");
        System.Console.WriteLine($"10 | 6 = {10 | 6}");
        System.Console.WriteLine($"10 ^ 6 = {10 ^ 6}");
        System.Console.WriteLine($"~10 = {~10}");
    }
}
