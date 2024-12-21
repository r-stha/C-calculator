class NumberSystemConversion
{
    public static void BinaryToDecimal()
    {      
        int binary = Input.TakeBinaryInput();
        int result = BinaryToDecimalLogic(binary);

        Console.WriteLine($"{binary} to decimal value is {result}");

        Console.WriteLine("Press any key to continue....");
        Console.ReadKey();
        Console.Clear();

    }

    private static int BinaryToDecimalLogic(int binary)
    {
        int sum = 0;
        int power = 1;
        int remainder;

        while (binary != 0)
        {
            remainder = binary % 10;
            sum += remainder * power;
            binary /= 10;
            power *= 2;
        }
        return sum;
    }

    public static void DecimalToBinary()
    {   
        int decimalNumber = Input.TakeDecimalInput();
        int result = DecimalToBinaryLogic(decimalNumber);

        Console.WriteLine($"{decimalNumber} to Binary is {result}");
        Console.WriteLine("Press any key to continue....");
        Console.ReadKey();
        Console.Clear();

    }

    private static int DecimalToBinaryLogic(int decimalNumber)
    {
        int binaryValue = 0;
        int remainder = 0;
        int placeValue = 1;

        while (decimalNumber != 0)
        {
            remainder = decimalNumber % 2;
            binaryValue += remainder * placeValue;
            placeValue *= 10;
            decimalNumber /= 2;
        }

        return binaryValue;

    }

}