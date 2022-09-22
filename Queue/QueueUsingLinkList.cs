

//Linked List Implementation of Queue

public class QueueUsingLinkList
{
   public Node front;
   public Node rear; 

    public void enqueue(int data)
    {       
        Node newNode = new Node(data); 
        if(front == null )
        {
            front = rear = newNode;
            return;
        }

        rear.next = newNode;
        rear = newNode;
    }

    public int dequeue()
    {
        //Console.WriteLine(front.data);
        int ret = 0;
        if(front == null)
            return -1;
        
        ret = front.data;
        front = front.next;

        return ret;

    }
}