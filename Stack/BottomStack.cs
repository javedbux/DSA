public class BottomStack
{
    public static void DrivingCode()
    {
        Stack<int> stk =new Stack<int>();

        stk.Push(1);
        stk.Push(2);
        stk.Push(3);

        //Console.WriteLine(stk.Count);
        BottomStackMth(stk, 4);

        while(stk.Count != 0)
        {
            Console.WriteLine(stk.Peek());
            stk.Pop();
        }
    }

    public static void BottomStackMth(Stack<int> stk , int bottomVal)
    {
        //Console.WriteLine(stk.Count);
        if(stk.Count == 0)
        {
            stk.Push(bottomVal);
            return;
        }

        int top = stk.Pop();

        BottomStackMth(stk, bottomVal);
        stk.Push(top);

    } 
}