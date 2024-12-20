﻿
class MainProgram
{
    public static void Main(string[] arg)
    {
        while (true)
        {
            Menu.MainMenu();

            double userchoice = Input.GetValidInput();
            switch (userchoice)
            {
                case 1:
                    Console.Clear();
                    Menu.ArthmeticCalculationMenu();

                    OptionChoose.ArthmeticOptionChoose();


                    Console.WriteLine($"Press any key to return to the menu.");
                    Console.ReadKey();
                    Console.Clear();

                    break;

                case 2:
                    Console.Clear();

                    Menu.ScientificMenu();

                    double ScientificMenuChoice = Input.GetValidInput();

                    OptionChoose.ScientificOptionChoose(ScientificMenuChoice);

                    break;

                case 3:
                    Menu.NumberSystemMenu();

                    double userChoice = Input.GetValidInput();
                    OptionChoose.NumberSystemConversionOptionChoose(userChoice);

                    break;

                case 4:
                    Console.Clear();
                    InfixToPostfix convert = new InfixToPostfix();
                    EvaluatePostfix Solve = new EvaluatePostfix();

                    string input = Input.TakeArthmetixExpressionInput();
                    string postfix = convert.ConvertToPostfix(input);

                    Console.WriteLine($"The result of the expression {input} is {Solve.Evaluate(postfix)}");
                    break;

                case 5:
                    return;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid option.");
                    break;
            }

        }
    }
}

