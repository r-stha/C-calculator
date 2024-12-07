
class InfixToPostfix : Stack
{

    public static bool IsOperator(char character)
    {
        return character == '+' || character == '-' || character == '*' || character == '/';
    }

    public static int PrecedenceValue(char character)
    {
        if (character == '+' || character == '-')
        {
            return 1;
        }
        else if (character == '*' || character == '/')
        {
            return 2;
        }
        else
        {
            return 0;
        }
    }

    public string ConvertToPostfix(string infix)
    {
        string Postfix = "";

        foreach (char character in infix)
        {
            if (Char.IsLetterOrDigit(character))
            {
                Postfix += character;
            }
            else if (character == '(')
            {
                Push(character);
            }
            else if (character == ')')
            {
                while (!IsStackEmpty() && StackTop() != '(')
                {
                    Postfix += Convert.ToChar(Pop());
                }
                Pop();
            }
            else if (IsOperator(character))
            {
                while (!IsStackEmpty() && PrecedenceValue(character) <= PrecedenceValue(Convert.ToChar(StackTop())))
                {
                    Postfix += Convert.ToChar(Pop());
                }
                Push(character);
            }
        }


        while (!IsStackEmpty())
        {

            Postfix += Convert.ToChar(StackTop());
            Pop();
        }

        return Postfix.Trim();
    }
}
