
public class BubbleSelectionInsertSort
{
    public static void DrivingCode()
    {
        //Bubble Sort
        int[] arr = {7,8,3,2,4, 1};
        PrintArray(arr);
        Console.WriteLine();
        //BubbleSort(arr);

        //selection Sort
        Console.WriteLine("selection Sort");
        //SelectionSort(arr);



        //Insert Sort
        Console.WriteLine("Insert Sort");
        InsertSort(arr);
    }

    static void InsertSort(int[] arr)
    {
        int n = arr.Length;
        
        for (int i = 1; i < n; i++)
        {
            int current = arr[i];
            int j = i -1;

            while(j >= 0 && current < arr[j])
            {
                arr[j+1] = arr[j];
                j--;
            }

            arr[j+1] = current;
        }
        PrintArray(arr);
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n -1; i++)
        {
            int selected = i;
            for (int j = i + 1; j < n; j++)
            {
                if(arr[selected] > arr[j])
                {
                    selected = j;                    
                }    
            }

            int temp = arr[selected];
            arr[selected] = arr[i];
            arr[i] = temp;
            
        }
        PrintArray(arr);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n -1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if(arr[j] > arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
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