class OptionChoose
{
    public static void ArthmeticOptionChoose(){
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
    }

    public static void ScientificOptionChoose(double Choice)
    {


         if (Choice == 1)
                    {
                        Console.Clear();
                        Menu.TrigonometricMenu();

                        TrigonometricOptionChoose();
                        
                    }
                    else if (Choice == 2)
                    {
                        Console.Clear();
                        ScientificCalculation.CombinationAndPermutation();
                    }
                    else if (Choice == 3)
                    {
                        Console.Clear();
                        ScientificCalculation.QuadraticSolve();

                    }

    }

   private static void TrigonometricOptionChoose()
    {
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

    public static void NumberSystemConversionOptionChoose(double userChoice)
    {
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


    }
}