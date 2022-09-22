

// Implement Stack using Queues

public class MyQueue
{
    Stack<int> s1 = new Stack<int>();
    Stack<int> s2 = new Stack<int>();

    public bool IsEmpty()
    {
        if(s1.Count == 0)
            return false;
        return true;
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
        if(s1.Count == 0)
            return -1;
        
        return s1.Pop();
    }    

    public int Peek()
    {
        if(s1.Count == 0)
            return -1;
        
        return s1.Peek();
    }

}