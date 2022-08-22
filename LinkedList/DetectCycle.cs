using System;

public class DetectCycle
{
    public static void DrivingCode()
    {
        Node head = new Node(1);
        Node h1 = new Node(2);
        Node h2 = new Node(3);
        Node h3 = new Node(4);
        Node h4 = new Node(5);
        Node h5 = new Node(6);
        Node h6 = new Node(7);

        head.Next = h1;
        h1.Next = h2;
        h2.Next = h3;
        h3.Next = h4;
        h4.Next = h5;
        h5.Next = h6;

        h6.Next = h3;

        // LinkedList llist = new LinkedList();
 
        // llist.push(20);
        // llist.push(4);
        // llist.push(15);
        // llist.push(10);
        // /*Create loop for testing */
        // llist.head.next.next.next.next = llist.head;

        //Console.WriteLine(head.data);
         //int val = DetectCycleNode(head); 

         //Console.WriteLine(val);

         Node ans = DetectCycleAns(head);
         Console.WriteLine("ans.data");
         Console.WriteLine(ans.data);

    }

    static Node DetectCycleAns(Node head)
    {
        Node start = head;
        Node meet = DetectCycleNode(head);

        while(start != meet)
        {
            start = start.Next;
            meet = meet.Next;

            
        }
        return start;
    }

    static Node DetectCycleNode(Node head)
    {
        Node slow = head;
        Node fast = head;

        while (fast != null & fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;

            Console.WriteLine(slow.data + " " + fast.data);
            if(slow.data == fast.data)
            {                
                return slow;
            }
        }

        return null;
    }

    // public static void push(int new_data)
    // {
    //     /* 1 & 2: Allocate the Node &
    //             Put in the data*/
    //     Node new_node = new Node(new_data);
 
    //     /* 3. Make next of new Node as head */
    //     new_node.next = head;
 
    //     /* 4. Move the head to point to new Node */
    //     head = new_node;
    // }
}