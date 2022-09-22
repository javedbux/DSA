public class BottomStk{


    public static void DrivingCode()
    {
        Stack<int> stk = new Stack<int>();
        stk.Push(1);
        stk.Push(2);
        stk.Push(3);


        BottomStackMth(stk, 4);

        while(stk.Count != 0)
        {
            Console.WriteLine(stk.Peek());
            stk.Pop();
        }
    }

    public static void BottomStackMth(Stack<int> stk, int val)
    {
        if(stk.Count == 0)
        {
            stk.Push(val);
            return;
        }
        int top = stk.Pop();
        BottomStackMth(stk, val);
        stk.Push(top);
    }
}