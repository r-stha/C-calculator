class Menu
{
    public static void MainMenu()
    {
        Console.WriteLine("Select an operation:");
        Console.WriteLine("1. Basic Operations");
        Console.WriteLine("2. Scientific Calculations");
        Console.WriteLine("3. Number System Conversion");
        Console.WriteLine("4. Exit");
    }


    public static void ArthmeticCalculationMenu()
    {
        Console.WriteLine(@"1. Addition
2. Subtraction
3. Multiplication
4. Division
6. Find the Power
5. Find the Factorial
7. Exit");
    }

    public static void ScientificMenu()
    {
        Console.WriteLine(@$"1. Trigonometric Functions
2. Find combination and permutation
3. Find the solution of Quadratic equation");
    }


    public static void DegreeOrRadianMenu()
    {
        Console.WriteLine("Do you want x in degree or radian:");
        Console.WriteLine(@"1. Degree
2. Radian");
    }


    public static void TrigonometricMenu()
    {
        Console.WriteLine("1. sin(x)");
        Console.WriteLine("2. cos(x)");
        Console.WriteLine("3. tan(x)");

    }

    public static void NumberSystemMenu()
    {
        Console.Clear();
        Console.WriteLine(@"1. Binary to decimal
2. Decimal to binary");

    }

}



class Input : Menu
{
    public static double GetValidInput()
    {
        while (true)
        {
            String? input = Console.ReadLine();

            if (double.TryParse(input, out double result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Enter a valid number:");
            }

        }
    }

    public static (double, double) TakeArthmeticInput()
    {
        Console.WriteLine("Enter your first operand:");
        double operand1 = GetValidInput();
        Console.WriteLine("Enter your Second operand");
        double operand2 = GetValidInput();

        return (operand1, operand2);
    }


    public static double TakeTrigonometricinput()
    {

        DegreeOrRadianMenu();
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if (choice == 1)
        {
            Console.WriteLine("Enter the value of x in degree");
            double x = Convert.ToDouble(Console.ReadLine());
            return ScientificCalculation.ConvertToRadian(x);

        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter the value of x in radian:");
            return Convert.ToDouble(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Invalid choice! Defaulting to radians.");

            Console.WriteLine("Enter the value of x in radian:");
            return Convert.ToDouble(Console.ReadLine());

        }

    }

    public static int TakeBinaryInput()
    {
        Console.WriteLine("Enter the value to convert to decimal");

        while (true)
        {
            string? binary = Console.ReadLine();

            foreach (char number in binary)
            {
                if (number != '0' && number != '1')
                {
                    Console.Clear();
                    Console.WriteLine("ERROR : Not a binary Number");
                    Console.WriteLine("Enter valid Binary Number:");


                }
                else
                {

                    return Convert.ToInt32(binary);
                }

            }

        }

    }

    public static int TakeDecimalInput()
    {
        Console.WriteLine("Enter the decimal value to convert to binary");
        return Convert.ToInt32(Console.ReadLine());
    }



}


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

    protected static double FactorialRecursion(double number)
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


class ScientificCalculation : ArthmeticCalculation
{
    public static double ConvertToRadian(double degree)
    {
        return (degree * Math.PI / 180);

    }


    public static void SinFunction()
    {
        Console.WriteLine($"sin(x)");
        double x = Input.TakeTrigonometricinput();

        Console.Clear();


        double result = SinFunctionLogic(x);


        Console.WriteLine($"sin({x}) = {result}");


    }

    public static double SinFunctionLogic(double x)
    {
        double sum = 0;
        int terms = 10;

        for (int n = 0; n < terms; n++)
        {
            double term = Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / FactorialRecursion(2 * n + 1);
            sum += term;
        }
        return sum;
    }

    public static void CosFunction()
    {
        Console.WriteLine("cos(x)");

        double x = Input.TakeTrigonometricinput();

        double result = CosFunctionLogic(x);


        Console.WriteLine($"cos({x}) = {result}");
    }

    public static double CosFunctionLogic(double x)
    {
        double sum = 0;
        int terms = 6;

        for (int n = 0; n < terms; n++)
        {
            double term = Math.Pow(-1, n) * Math.Pow(x, 2 * n) / FactorialRecursion(2 * n);
            sum += term;
        }
        return sum;
    }

    public static void TanFunction()
    {
        Console.WriteLine("tan(x)");
        double x = Input.TakeTrigonometricinput();


        double result = SinFunctionLogic(x) / CosFunctionLogic(x);

        Console.WriteLine($"tan({x}) = {result}");
    }

    public static void CombinationAndPermutation()
    {
        Console.Clear();
        Console.WriteLine("Enter the total of objects in a collection");
        double totalObjects = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the numbers of objects from the collection that can be choosen:");
        double choosenNumber = Convert.ToDouble(Console.ReadLine());

        double combinationResult = FactorialRecursion(totalObjects) / (FactorialRecursion(choosenNumber) * FactorialRecursion(totalObjects - choosenNumber));
        double permutationResult = combinationResult * FactorialRecursion(choosenNumber);
        Console.WriteLine(@$"The combination result is {combinationResult}
The permutation result is {permutationResult}");

    }

    public static void QuadraticSolve()
    {
        Console.WriteLine("It is in the form ax^2 + bx + c");

        Console.Write("Enter the coefficient of a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the coefficient of b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the coefficient of c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double discriminant = Math.Pow(b, 2) - 4 * a * c;

        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"The roots are real and distinct: {root1} and {root2}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"The roots are real and equal: {root}");
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine($"The roots are complex: {realPart} + {imaginaryPart}i and {realPart} - {imaginaryPart}i");
        }
    }


}


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


class MainProgram
{
    public static void Main()
    {
        while (true)
        {
            Input.MainMenu();

            double userchoice = Input.GetValidInput();
            switch (userchoice)
            {
                case 1:
                    Console.Clear();
                    Menu.ArthmeticCalculationMenu();


                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Clear();
                            ArthmeticCalculation.Addition();
                            break;

                        case "2":
                            Console.Clear();
                            ArthmeticCalculation.Subtraction();
                            break;

                        case "3":
                            Console.Clear();
                            ArthmeticCalculation.Multiplication();
                            break;

                        case "4":
                            Console.Clear();
                            ArthmeticCalculation.Division();
                            break;

                        case "5":
                            Console.Clear();
                            ArthmeticCalculation.Power();
                            break;

                        case "6":
                            Console.Clear();
                            ArthmeticCalculation.Factorial();
                            break;

                        case "7":
                            return;

                        default:
                            Console.WriteLine("Enter a valid option");
                            break;

                    }
                    Console.WriteLine($"Press any key to return to the menu.");
                    Console.ReadKey();
                    Console.Clear();

                    break;

                case 2:
                    Console.Clear();

                    Menu.ScientificMenu();
                    String? Choice = Console.ReadLine();

                    if (Choice == "1")
                    {
                        Console.Clear();
                        Menu.TrigonometricMenu();



                        string? trigChoice = Console.ReadLine();

                        if (trigChoice == "1")
                        {
                            Console.Clear();
                            ScientificCalculation.SinFunction();
                        }
                        else if (trigChoice == "2")
                        {
                            Console.Clear();
                            ScientificCalculation.CosFunction();
                        }
                        else if (trigChoice == "3")
                        {
                            Console.Clear();
                            ScientificCalculation.TanFunction();
                        }


                        else
                        {
                            Console.WriteLine("Invalid option.");
                        }
                    }
                    else if (Choice == "2")
                    {
                        Console.Clear();
                        ScientificCalculation.CombinationAndPermutation();
                    }
                    else if (Choice == "3")
                    {
                        Console.Clear();
                        ScientificCalculation.QuadraticSolve();

                    }
                    break;

                case 3:
                    Input.NumberSystemMenu();

                    double userChoice = Input.GetValidInput();

                    if (userChoice == 1)
                    {
                        Console.Clear();
                        NumberSystemConversion.BinaryToDecimal();
                    }
                    else if (userChoice == 2)
                    {
                        Console.Clear();
                        NumberSystemConversion.DecimalToBinary();
                    }


                    break;


                case 4:
                    return;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid option.");
                    break;
            }

        }
    }
}

