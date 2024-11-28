
class SimpleOperation
{

    public static void Menu()
    {
        Console.WriteLine(@"1. Addition
2. Subtraction
3. Multiplication
4. Division
6. Find the Power
5. Find the Factorial
7. Exit");
    }


    public static double ValidInput()
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

    public static (double, double) TakeInput()
    {
        Console.WriteLine("Enter your first operand:");
        double operand1 = ValidInput();
        Console.WriteLine("Enter your Second operand");
        double operand2 = ValidInput();

        return (operand1, operand2);
    }

    public static void Addition()
    {
        (double operand1, double operand2) = TakeInput();
        Console.WriteLine($"The sum of {operand1} and {operand2} is {operand1 + operand2}");

    }

    public static void Subtraction()
    {
        var (operand1, operand2) = TakeInput();
        Console.WriteLine($"The difference of {operand1} and {operand2} is {operand1 - operand2}");
    }

    public static void Multiplication()
    {
        var (operand1, operand2) = TakeInput();
        Console.WriteLine($"The product of {operand1} and {operand2} is {operand1 * operand2}");
    }

    public static void Division()
    {
        var (operand1, operand2) = TakeInput();
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


class ScientificCalculation : SimpleOperation
{

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


    public static double Takeinput()
    {

        DegreeOrRadianMenu();
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if (choice == 1)
        {
            Console.WriteLine("Enter the value of x in degree");
            double x = Convert.ToDouble(Console.ReadLine());
            return ConvertToRadian(x);

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

    public static void TrigonometricMenu()
    {
        Console.WriteLine("1. sin(x)");
        Console.WriteLine("2. cos(x)");
        Console.WriteLine("3. tan(x)");
        
    }


    public static double ConvertToRadian(double degree)
    {
        return (degree * Math.PI / 180);

    }


    public static void SinFunction()
    {
        Console.WriteLine($"sin(x)");
        double x = Takeinput();

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

        double x = Takeinput();

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
        double x = Takeinput();


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


class MainProgram
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Basic Operations");
            Console.WriteLine("2. Scientific Calculations");
            Console.WriteLine("3. Exit");


            switch (Console.ReadLine())
            {
                case "1":
                Console.Clear();
                    SimpleOperation.Menu();


                    switch (Console.ReadLine())
                    {
                        case "1":
                        Console.Clear();
                            SimpleOperation.Addition();
                            break;

                        case "2":
                        Console.Clear();
                            SimpleOperation.Subtraction();
                            break;

                        case "3":
                        Console.Clear();
                            SimpleOperation.Multiplication();
                            break;

                        case "4":
                        Console.Clear();
                            SimpleOperation.Division();
                            break;

                        case "5":
                        Console.Clear();
                            SimpleOperation.Power();
                            break;

                        case "6":
                        Console.Clear();
                            SimpleOperation.Factorial();
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

                case "2":
                Console.Clear();

                    ScientificCalculation.ScientificMenu();
                    String? Choice = Console.ReadLine();

                    if (Choice == "1")
                    {
                        Console.Clear();
                        ScientificCalculation.TrigonometricMenu();



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



                case "3":
                    return;

                default:
                Console.Clear();
                    Console.WriteLine("Invalid option.");
                    break;
            }

        }
    }
}
