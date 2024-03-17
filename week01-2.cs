using System;
public class Week01_2
{
    static void Main()
    {
        sbyte   byteValue      = -128;
        byte    ubyteValue     = 255;
        short   shortValue     = -32768;
        ushort  ushortValue    = 65535;
        int     intValue       = -2147483648;
        uint    uintValue      = 4294967295;
        long    longValue      = -922337203685477508;
        ulong   ulongValue     = 18446744073709551615;
        char    charValue      = 'K';

        System.Console.WriteLine("byte Data : " + byteValue);
        System.Console.WriteLine("ubyte Data : " + ubyteValue);
        System.Console.WriteLine("short Data : " + shortValue);
        System.Console.WriteLine("ushort Data : " + ushortValue);
        System.Console.WriteLine("int Data : " + intValue);
        System.Console.WriteLine("uint Data : " + uintValue);
        System.Console.WriteLine("long Data : " + longValue);
        System.Console.WriteLine("ulong Data : " + ulongValue);
        System.Console.WriteLine("char Data : " + charValue);

        float floatvalue01 = 3.141592653589793238462643383279f;
        float floatvalue02 = 31.141592653589793238462643383279f;
        double doublevalue = 3.141592653589793238462643383279;
        decimal decimalvalue = 3.141592653589793238462643383279m;

        System.Console.WriteLine("float Data : " + floatvalue01);
        System.Console.WriteLine("float Data : " + floatvalue02);
        System.Console.WriteLine("double Data : " + doublevalue);
        System.Console.WriteLine("decimal Data : " + decimalvalue);

        string stringValue = "Hello, World!";
        bool boolValue = true;

        System.Console.WriteLine("string Data : " + stringValue);
        System.Console.WriteLine("bool Data : " + boolValue);

        object valueInt = 31;
        object valueFloat = 3.14159265358979f;
        object valueString = "객체지향 프로그래밍";
        object valueBool = false;

        System.Console.WriteLine("정수 : " + valueInt);
        System.Console.WriteLine("실수 : " + valueFloat);
        System.Console.WriteLine("문자열 : " + valueString);
        System.Console.WriteLine("논리 : " + valueBool);
    }
}
