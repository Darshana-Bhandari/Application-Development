using System;

class Program
{
    static void Main()
    {
        byte byteValue = 10;
        short shortValue = 1000;
        int intValue = 42;
        long longValue = 100000L;

        float floatValue = 3.14f;
        double doubleValue = 3.14159;
        decimal decimalValue = 99.99m;

        char charValue = 'A';
        bool boolValue = true;

        // Convert integer 42 to string
        string numberAsString = intValue.ToString();

        // Convert string "3.14" to double
        string numberString = "3.14";
        double convertedDouble = Convert.ToDouble(numberString);

        Console.WriteLine($"byte: {byteValue}");
        Console.WriteLine($"short: {shortValue}");
        Console.WriteLine($"int: {intValue}");
        Console.WriteLine($"long: {longValue}");
        Console.WriteLine($"float: {floatValue}");
        Console.WriteLine($"double: {doubleValue}");
        Console.WriteLine($"decimal: {decimalValue}");
        Console.WriteLine($"char: {charValue}");
        Console.WriteLine($"bool: {boolValue}");

        Console.WriteLine($"int to string: {numberAsString}");
        Console.WriteLine($"string to double: {convertedDouble}");
    }
}