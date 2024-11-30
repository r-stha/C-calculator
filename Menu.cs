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
