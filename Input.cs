class Input 
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

        Menu.DegreeOrRadianMenu();
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
        Console.WriteLine("Enter the binary value to convert to decimal");

        while (true)
        {
            String? binary = Console.ReadLine();
            
            if(binary is not null){
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

    }

    public static int TakeDecimalInput()
    {
        Console.WriteLine("Enter the decimal value to convert to binary");
        return Convert.ToInt32(Console.ReadLine());
    }



}
