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
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Find the power");
        Console.WriteLine("6. Find the factorial");
        Console.WriteLine("7. Exit");

    }

    public static void ScientificMenu()
    {
        Console.WriteLine("1. Trigonometric Functions");
        Console.WriteLine("2. Find combination and permutation");
        Console.WriteLine("3. Find the solution of Quadratic Equation");
    }


    public static void DegreeOrRadianMenu()
    {
        Console.WriteLine("Do you want x in degree or radian:");
        Console.WriteLine("1. Degree");
        Console.WriteLine("2. Radian");
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
        Console.WriteLine("1. Binary to decimal");
        Console.WriteLine("2. Decimal to binary");

    }

}
