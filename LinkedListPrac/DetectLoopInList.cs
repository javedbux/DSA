
public class DetectLoopInList
{
    public static void DrivingCode()
    {
        
        Node head = new Node(12);
        Node h1 = new Node(13);
        Node h2 = new Node(14);
        Node h3 = new Node(1);
        Node h4 = new Node(141);
        Node h5 = new Node(131);
        Node h6 = new Node(121);

        head.Next = h1;
        h1.Next = h2;
        h2.Next = h3;
        h3.Next = h4;
        h4.Next = h5;
        h5.Next = h6;
        h6.Next = h4;

        // Console.WriteLine("Cycle");
        // while(head != null)
        // {
        //     Console.WriteLine("Remove node + " + head.data);
        //     head = head.Next;
        // }     
        
        bool ans = DetectCycle(head);

        Console.WriteLine(ans);

    }

    static bool DetectCycle(Node head)
    {
        Node slow = head;
        Node fast = head;

        while(fast.Next != null && fast.Next.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;

            if(slow == fast)
                return true;
        }

        return false;
    }

}