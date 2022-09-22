// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("------Detect Cycle in list---------------");

DetectLoopInList.DrivingCode();


Console.WriteLine("------Detect End---------------");




Console.WriteLine("------N th node in list---------------");

RemoveNnodeFromList.DrivingCode();


Console.WriteLine("------Palindrome---------------");

Palindrome.DrivingCode();

Console.WriteLine("----------------Palindrome End-------------");


LinkedListSOL listSOL = new LinkedListSOL();
listSOL.AddFirst(1);
listSOL.AddFirst(12);
listSOL.AddFirst(13);
listSOL.AddFirst(14);
listSOL.AddFirst(15);

listSOL.PrintList();

Console.WriteLine();

Console.WriteLine(" Get Size : - "+listSOL.GetSize());

listSOL.AddLast(155);

listSOL.PrintList();

Console.WriteLine(" Get Size : - "+listSOL.GetSize());

Console.WriteLine();

listSOL.DeleteFirst();

listSOL.PrintList();

Console.WriteLine(" Get Size : - "+listSOL.GetSize());

Console.WriteLine();

listSOL.DeleteLast();

listSOL.PrintList();

Console.WriteLine(" Get Size : - "+listSOL.GetSize());

Console.WriteLine();


LinkedList<string> list =new LinkedList<string>();


list.AddFirst("Akbar");
list.AddFirst("Allah ho");

list.AddLast("Salaam");

//list.AddBefore()

foreach (var item in list)
{
    Console.Write(" " + item);
}
Console.WriteLine();