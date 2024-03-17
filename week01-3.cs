using System;
public class Week01_3
{
    static void Main()
    {
        sbyte sbyteValue = 10;
        int intValue = (int)sbyteValue;

        System.Console.WriteLine("sbyteValue : " + sbyteValue);
        System.Console.WriteLine("intValue : " + intValue);

        intValue = 130;
        sbyteValue = (sbyte)intValue;

        System.Console.WriteLine("sbyteValue : " + sbyteValue);
        System.Console.WriteLine("intValue : " + intValue);

        int byteValue = 200;
        sbyteValue = (sbyte)byteValue;

        System.Console.WriteLine("byteValue : " + byteValue);
        System.Console.WriteLine("sbyteValue : " + sbyteValue);

        float floatValue = 3.1415926535f;
        double doubleValue = (double)floatValue;

        System.Console.WriteLine("floatValue : " + floatValue);
        System.Console.WriteLine("doubleValue : " + doubleValue);

        doubleValue = 3.1415926535;

        System.Console.WriteLine("doubleValue : " + doubleValue);

        floatValue = 1.9f;
        intValue = (int)floatValue;

        System.Console.WriteLine("floatValue : " + floatValue);
        System.Console.WriteLine("intValue : " + intValue);

        string stringValue = "35";
        intValue = int.Parse(stringValue);
        floatValue = float.Parse(stringValue);

        System.Console.WriteLine("stringValue : " + stringValue);
        System.Console.WriteLine("intValue : " + intValue);
        System.Console.WriteLine("floatValue : " + floatValue);

        stringValue = "145";
        bool isConversion = int.TryParse(stringValue, out intValue);
        if (isConversion == true)
        {
            System.Console.WriteLine("intValue : " + intValue);
            System.Console.WriteLine("isConversion : " + isConversion);
        }
        else
        {
            System.Console.WriteLine("변환 실패");
        }
    }
}
