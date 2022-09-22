

public class QueueUsingStack
{
    public Stack<int> s1 = new Stack<int>();
    Stack<int> s2 = new Stack<int>();

    public bool IsEmpty()
    {
        return s1.Count == 0;
    }
    public void Add(int data)
    {

        while(s1.Count != 0)
        {
            s2.Push(s1.Pop());
        }

        s1.Push(data);

        while(s2.Count != 0)
        {
            s1.Push(s2.Pop());
        }
    }

    public int Remove()
    {
        if(IsEmpty())
        {
            return -1;
        }

        return s1.Pop();
    }
    

    public int GetPeek()
    {
        if(IsEmpty())
        {
            return -1;
        }

        return s1.Peek();
    }
}