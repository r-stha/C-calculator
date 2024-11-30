class ArthmeticCalculation
{

    public static void Addition()
    {
        (double operand1, double operand2) = Input.TakeArthmeticInput();
        Console.WriteLine($"The sum of {operand1} and {operand2} is {operand1 + operand2}");

    }

    public static void Subtraction()
    {
        var (operand1, operand2) = Input.TakeArthmeticInput();
        Console.WriteLine($"The difference of {operand1} and {operand2} is {operand1 - operand2}");
    }

    public static void Multiplication()
    {
        var (operand1, operand2) = Input.TakeArthmeticInput();
        Console.WriteLine($"The product of {operand1} and {operand2} is {operand1 * operand2}");
    }

    public static void Division()
    {
        var (operand1, operand2) = Input.TakeArthmeticInput();
        if (operand2 == 0)
        {
            Console.WriteLine("ERROR: Division by zero");
        }
        else
        {
            Console.WriteLine($"{operand1} / {operand2} = {operand1 / operand2}");
        }
    }

    public static void Factorial()
    {
        Console.WriteLine("Enter the number to find the factorial");
        double factorialNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"{factorialNumber}! = {FactorialRecursion(factorialNumber)}");

    }

    public static double FactorialRecursion(double number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * FactorialRecursion(number - 1);
        }
    }


    public static void Power()
    {

        Console.WriteLine("Enter the base:");
        double Base = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the power of the number:");
        double power = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"{Base} ^ {power} = {PowerRecursion(Base, power)}");


    }


    public static double PowerRecursion(double baseNumber, double powerNumber)
    {
        if (powerNumber == 0)
        {
            return 1;
        }
        else
        {
            return baseNumber * PowerRecursion(baseNumber, powerNumber - 1);
        }
    }

}
