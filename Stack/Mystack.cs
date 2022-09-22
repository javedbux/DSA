public class MyStack
{
    public Node head;

    public bool IsEmpty()
    {
        return head == null;
    }

    public void Push(int data)
    {
        
        Node newNode = new Node(data);

        if(IsEmpty())
        {
            head = newNode;
            return;
        }

        newNode.Next1 = head;
        head = newNode;

        
    }

    public int Pop()
    {
        if(IsEmpty())
            return -1;

        int top = head.data; 
        head = head.Next1;
        return top;
    }

    public int Peek()
    {
        if(IsEmpty())
            return -1;

        int top = head.data; 
        //head = head.Next1;
        return top;
    }

}