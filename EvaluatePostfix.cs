
using System.Runtime.CompilerServices;

class EvaluatePostfix : Stack
{

    public double Evaluate(string postfix)
    {
        foreach (char character in postfix)
        {
            if (char.IsLetterOrDigit(character))
            {
                try
                {
                    Push(int.Parse(character.ToString()));
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR: String cannot be input..");
                    Environment.Exit(0);
                }
            }
            else if (InfixToPostfix.IsOperator(character))
            {
                int operand2 = Pop();
                int operand1 = Pop();



                int result = 0;
                switch (character)
                {
                    case '+':
                        result = operand1 + operand2;
                        break;
                    case '-':
                        result = operand1 - operand2;
                        break;
                    case '*':
                        result = operand1 * operand2;
                        break;
                    case '/':
                        result = operand1 / operand2;
                        break;
                }

                Push(result);
            }
        }


        return StackTop();
    }
}