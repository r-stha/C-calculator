class ArthmeticCalculation
{

    public static void Addition()
    {
        (double operand1, double operand2) = Input.TakeArthmeticInput();
        Console.WriteLine($"The sum of {operand1} and {operand2} is {operand1 + operand2}");

    }

    public static void Subtraction()
    {
        (double operand1, double operand2) = Input.TakeArthmeticInput();
        Console.WriteLine($"The difference of {operand1} and {operand2} is {operand1 - operand2}");
    }

    public static void Multiplication()
    {
         (double operand1, double operand2) = Input.TakeArthmeticInput();
        Console.WriteLine($"The product of {operand1} and {operand2} is {operand1 * operand2}");
    }

    public static void Division()
    {
        (double operand1, double operand2) = Input.TakeArthmeticInput();

        try
        {
            Console.WriteLine($"{operand1} / {operand2} = {(decimal)operand1 / (decimal)operand2}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }

    }

    public static void Factorial()
    {
        Console.WriteLine("Enter the number to find the factorial");
        double factorialNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"{factorialNumber}! = {Factoral(factorialNumber)}");

    }

    public static double Factoral(double number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * Factoral(number - 1);
        }
    }


    public static void CalculatePower()
    {

        Console.WriteLine("Enter the base:");
        double radix = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the power of the number:");
        double power = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"{radix} ^ {power} = {ComputePowerRecursive(radix, power)}");

    }



    public static double ComputePowerRecursive(double baseNumber, double powerNumber)
    {
        if (powerNumber == 0)
        {
            return 1;
        }
        else
        {
            return baseNumber * ComputePowerRecursive(baseNumber, powerNumber - 1);
        }
    }

}
