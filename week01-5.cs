using System;
public class Week01_5
{
    static void Main()
    {
        int hours = 11;
        int minutes = 15;
        int seconds = 45;

        System.Console.WriteLine(string.Format("기본 : {0}:{1}:{2}", hours, minutes, seconds));
        System.Console.WriteLine(string.Format("왼쪽 맞춤 : {0, -4}:{1}:{2}", hours, minutes, seconds));
        System.Console.WriteLine(string.Format("오른쪽 맞춤 : {0, 4}:{1}:{2}", hours, minutes, seconds));

        System.Console.WriteLine(string.Format("10진수 서식화 : {0:D}", 123));
        System.Console.WriteLine(string.Format("10진수 서식화(5자리) : {0:D5}", 123));

        System.Console.WriteLine(string.Format("16진수 서식화 : {0:X}", 0x00));
        System.Console.WriteLine(string.Format("16진수 서식화(8자리) : {0:X8}", 0x00));

        System.Console.WriteLine(string.Format("고정소수점 서식화 : {0:F}", 1.23456));
        System.Console.WriteLine(string.Format("고정소숫점 서식화(소수점 3자리) : {0:F3}", 1.23456));

        System.Console.WriteLine(string.Format("콤마 구분 : {0:N}", 1234567890));
        System.Console.WriteLine(string.Format("지수 : {0:E}", 1234567890));

        DateTime date = new DateTime(2024, 3, 17, 18, 10, 0);
        string str = date.ToString("yyyy-MM-dd tt hh:mm:ss (dddd)");
        System.Console.WriteLine(str);

        str = date.ToString("yyyy-MM-dd HH:mm:ss (dddd)");
        System.Console.WriteLine(str);

        System.Console.WriteLine($"기본 : {hours}:{minutes}:{seconds}");
        System.Console.WriteLine($"왼쪽 맞춤 : {hours, -4}:{minutes}:{seconds}");

        string str2 = "Hello, World";

        int numeric = str2.IndexOf('o');
        System.Console.WriteLine($"앞의 o는 {numeric + 1}번째에 있습니다.");

        numeric = str2.LastIndexOf('o');
        System.Console.WriteLine($"뒤의 o는 {numeric + 1}번째에 있습니다.");

        bool isTrue = str2.StartsWith("Hello");
        System.Console.WriteLine($"{str2} 문장은 Hello부터 시작한다? {isTrue}");

        isTrue = str2.EndsWith("World");
        System.Console.WriteLine($"{str2} 문장은 World로 끝난다? {isTrue}");

        isTrue = str2.Contains("llo");
        System.Console.WriteLine($"{str2} 문장에 llo가 포함되어 있다? {isTrue}");

        string str3 = "Hello, World";

        str3 = str3.ToLower();
        System.Console.WriteLine($"ToLower() - {str3}");

        str3 = str3.ToUpper();
        System.Console.WriteLine($"ToUpper() - {str3}");

        str3 = str3.Insert(0, "Hi~ ");
        System.Console.WriteLine($"Insert() - {str3}");

        str3 = str3.Remove(0, 4);
        System.Console.WriteLine($"Remove() - {str3}");

        string str4 = "    " + str2 + "    ";

        str4 = str4.Trim();
        System.Console.WriteLine($"{str4}공백 체크");

        str4 = str4.Replace("Hello", "Bye");
        System.Console.WriteLine($"{str4}");

        string position = "3, 5, 6";
        string[] str5 = position.Split(',');
        System.Console.WriteLine($"{str5[0]}, {str5[1]}, {str5[2]}");

        string str6 = "HELLO, WORLD";
        str6 = str6.Substring(7);
        System.Console.WriteLine(str6);



    }
}
