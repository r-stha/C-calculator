
class ScientificCalculation 
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
            double term = Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / ArthmeticCalculation.Factoral(2 * n + 1);
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
            double term = Math.Pow(-1, n) * Math.Pow(x, 2 * n) / ArthmeticCalculation.Factoral(2 * n);
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

        double combinationResult = ArthmeticCalculation.Factoral(totalObjects) / (ArthmeticCalculation.Factoral(choosenNumber) * ArthmeticCalculation.Factoral(totalObjects - choosenNumber));
        double permutationResult = combinationResult * ArthmeticCalculation.Factoral(choosenNumber);
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
