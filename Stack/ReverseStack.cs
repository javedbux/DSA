public class ReverseStack
{
    public static void DrivingCode()
    {
        Stack<int> stk = new Stack<int>();
        stk.Push(1);
        stk.Push(2);
        stk.Push(3);


        ReverseStackMth(stk);
        //Console.WriteLine(stk.Count);
        while(stk.Count != 0)
        {
            Console.WriteLine(stk.Peek());
            stk.Pop();
        }
    }

    static void ReverseStackMth(Stack<int> stk)
    {
        
        if(stk.Count == 0)
        {
            return;
        }
        int top = stk.Pop();        
        ReverseStackMth(stk);
        BottomStk.BottomStackMth(stk, top);

    }
}