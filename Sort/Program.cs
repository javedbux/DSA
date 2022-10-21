// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//BubbleSelectionInsertSort.DrivingCode();

//InsertSelectionBubble.DrivingCode();


//MergeSort.DrivingCode();

//MergeSort2.DrivingCode();


int[] arr = {1,2,3,4,5};

// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write(" " + arr[i]);
// }
// Console.WriteLine();
// for(int i = arr.Length-1; i >= 0; i--)
// {
//     Console.Write(" " + arr[i]);
// }

Console.WriteLine();
// swap

int start =0;
int end = arr.Length -1;

while(start < end)
{
    Swap(arr, start, end);
    
    //Console.Write(" " + arr[end]);
    start++;
    end--;
}
Console.WriteLine("Swap");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(" " + arr[i]);
}

static void Swap(int[] arr, int a, int b)
{
    int temp = arr[a];
    arr[a]= arr[b];
    arr[b] = temp;
}