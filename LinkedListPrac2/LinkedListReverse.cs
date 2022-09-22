

public class LinkedListReverse
{
    public static void DrivingCode()
    {
        
        LinkedListSOL listSOL = new LinkedListSOL();
        listSOL.AddFirst(1);
        listSOL.AddFirst(12);
        listSOL.AddFirst(13);
        listSOL.AddFirst(14);
        listSOL.AddFirst(15);

        listSOL.PrintList();

        Node res= ReverseList(listSOL.head);
    }

    static Node ReverseList(Node head)
    {
        // if(head == null || head.Next == null)
        // {
        //     return head;
        // }

        Node newNode = ReverseList(head.Next);
        head.Next.Next = head;
        head.Next = null;

        return newNode;


    }
}