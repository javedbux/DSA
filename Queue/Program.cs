// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


MyQueue qu = new MyQueue();

qu.Add(1);
qu.Add(2);
qu.Add(3);
qu.Add(4);

//Console.WriteLine(qu.Peek);

while(qu.IsEmpty())
{
    Console.WriteLine(qu.Peek());
    qu.Remove();
}


Console.WriteLine("-------------------------------------------------------------");


QueueUsingLinkList q = new QueueUsingLinkList();
        q.enqueue(10);
        q.enqueue(20);
        q.dequeue();
        q.dequeue();
        q.enqueue(30);
        q.enqueue(40);
        q.enqueue(50);
        q.dequeue();
        Console.WriteLine("Queue Front : " + q.front.data);
        Console.WriteLine("Queue Rear : " + q.rear.data);

Console.WriteLine("-------------------------------------------------------------");



QueueUsingArray qq = new QueueUsingArray(5);
        qq.enqueue(10);
        qq.enqueue(20);
        qq.dequeue();
        qq.dequeue();
        qq.enqueue(30);
        qq.enqueue(40);
        qq.enqueue(50);
        //qq.dequeue();
        //Console.WriteLine("Queue Front : " + qq.front.data);
        Console.WriteLine("Queue Rear : " + qq.GetFront());



Console.WriteLine("-------------------------------------------------------------");


QueueWithCircularArray qqq = new QueueWithCircularArray(5);
        qqq.enqueue(10);
        qqq.enqueue(20);
        qqq.dequeue();
        //qqq.dequeue();
        qqq.enqueue(30);
        qqq.enqueue(40);
        qqq.enqueue(50);
        //qq.dequeue();
        //Console.WriteLine("Queue Front : " + qq.front.data);
        Console.WriteLine("Queue Rear : " + qqq.GetFront());

        while(!qqq.IsEmpty())
        {
                Console.WriteLine(qqq.GetFront());
                qqq.dequeue();
        }



Console.WriteLine("-------------------Linked List------------------------------------------");


QueueUsingLinkedList q1 = new QueueUsingLinkedList();
        q1.Add(10);
        q1.Add(20);
       // q1.Remove();
       // q1.Remove();
       // q1.Add(30);
       // q1.Add(40);
//q1.Add(50);
        q1.Remove();
       // Console.WriteLine("q1ueue Front : " + q1.Head.data);
       // Console.WriteLine("q1ueue Rear : " + q1.Tail.data);


        while(!q1.IsEmpty())
        {
                Console.WriteLine(q1.GetHead());
                q1.Remove();
        }



        Console.WriteLine("-------------------Stack List------------------------------------------");

        QueueUsingStack qs = new QueueUsingStack();

        qs.Add(25);
        qs.Add(12);
        qs.Add(251);
        
        //qs.Remove();
        qs.Add(121);

        //Console.WriteLine("" + qs.GetPeek());


        while(qs.s1.Count != 0 )
        {
                Console.WriteLine("" + qs.GetPeek());
                qs.Remove();
        }

        Console.WriteLine("-------------------------Linked List Flatten---------------------------");


        FlattenLinkedList list = new FlattenLinkedList();
        list.DrivingCode();

        //Node head = list.createList();
        //list.FlattenList(head);
        //list.printList(head);