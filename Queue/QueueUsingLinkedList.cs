

public class QueueUsingLinkedList
{
    
   public Node Head = null;
   public Node Tail = null;

    public bool IsEmpty()
    {
        return Head == null && Tail == null;
    }

    public void Add(int data)
    {
        Node newNode = new Node(data);
        if(Tail == null)
        {
            Tail = Head = newNode;
            return;
        }

        Tail.next = newNode;
        Tail = newNode;
    }

    public int Remove()
    {
        if(IsEmpty())
            return -1;
        
        int front = Head.data;
        if(Tail == Head)
        {
            Tail = Head = null;
        }
        else
            Head = Head.next;

        return front;
    }

    public int GetHead()
    {
        if(IsEmpty())
            return -1;

        //int ret = Head.data;

         return Head.data;
    }
}