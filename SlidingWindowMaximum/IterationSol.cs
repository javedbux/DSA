public class IterationSol
{
    public static void DrivingCode()
    {
        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] arr = { 1, 2, 3, 1, 4, 5, 2, 3, 6 };
        int K = 3;
        PrintKMax(arr, arr.Length, K);

        Console.WriteLine();
        PrintKMax2(arr, arr.Length, K);
    }

    static void PrintKMax(int[] a, int n, int k)
    {
        int max;
        int j;

        for(int i=0; i<=n-k; i++)
        {
            max = a[i];

            for(j =1; j < k; j++)
            {
                if(a[i+j] > max)
                    max = a[i+j];                
            
            }   
            Console.Write(" " + max);         

        }

    }

    static void PrintKMax2(int[] arr, int n, int k)
    {
        int max;

        for(int i=0; i<= n-k; i++)
        {
            max = arr[i];

            for(int j =1; j < k; j++)
            {
                if(arr[i+j] > max)
                    max = arr[i+j];
            }

            Console.Write(max +  " , ");
        }
    }
}