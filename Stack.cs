class Stack
{
    private int top;
    private  int size;
    private int[] arr ;

    public Stack(int stackSize = 100) 
    {
        size = stackSize;
        top = -1;
        arr = new int[size];
    }

    public bool IsStackEmpty()
    {
        return top == -1;
    }

    public bool IsStackFull()
    {
        return top == size - 1;
    }

    public void Push(int value)
    {
        if (IsStackFull())
        {
            Console.WriteLine("Stack Overflow!");
        }
        else
        {
            arr[++top] = value;
        }
    }

    public int Pop()
    {
        if (IsStackEmpty())
        {
            Console.WriteLine("Stack Underflow!");
            return -1; 
        }
        else
        {
            return arr[top--];
        }
    }

    public int StackTop()
    {
        if (IsStackEmpty())
        {
            Console.WriteLine("Stack is empty!");
            return -1;
        }
        return arr[top];
    }

    public int StackBottom()
    {
        if (IsStackEmpty())
        {
            Console.WriteLine("Stack is empty!");
            return -1;
        }
        return arr[0];
    }
}
