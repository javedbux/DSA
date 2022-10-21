
public class InsertSelectionBubble
{
    public static void DrivingCode()
    {
        int[] arr = {7,8,3,2,4, 1};
        PrintArray(arr);
        //Insert Sort
        Console.WriteLine("Insert Sort");
        //InsertSort(arr);

        Console.WriteLine("Selection Sort");
        SelectionSort(arr);
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n -1; i++)
        {
            int selected = i;
            for (int j = i + 1; j < n; j++)
            {
                
            }
        }
    }
    static void InsertSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            int current = arr[i];
            int j = i-1;
            //Console.WriteLine("Cur ;- " + current + " < " + arr[j]);
            while(j >= 0 && current < arr[j])
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = current;
        }

        PrintArray(arr);
    }
    static void PrintArray(int[] arr)
    {        
        for (int i = 0; i < arr.Length; i++)
        {
             Console.Write(" " + arr[i]);
        }
        Console.WriteLine();
    }
}