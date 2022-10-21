
public class BinarySerc
{
    public static void DrivingCode()
    {
        int[] arr = {1,2,3,4,5,6,7,8,9,11,22,33,44,55,66,77,88,99,111,222,333,444,555,666,777,888,999};

        Console.WriteLine("Binary search brute ");
        int target = 7;
        int ans = SearchTarget(arr, target);
        Console.WriteLine(ans);
        
        Console.WriteLine("Binary search Recursion ");
        
        int ans1 = SearchTargetRe(arr, 0, arr.Length -1, target);
        Console.WriteLine(ans1);
        
        //
        Console.WriteLine("Find Element in infinite sorted array ");
        int key = 77;
        int ans2 = FindArrayInSortedArray(arr, key);
        Console.WriteLine(ans2);
        

        //
        Console.WriteLine("Search an element in a Sorted & Rotated Array  ");
        int[] arr1 = {20,30,40,50,60,5,10};
        int key1 = 5;
        int ans3 = FindArrayInRotatedSortedArray(arr1, key1);
        Console.WriteLine(ans3);
        
    }
    static int FindArrayInRotatedSortedArray(int[] arr, int key)
    {
        int low =0;
        int high = arr.Length-1;

        while(low < high)
        {
            int mid = (low + high)/2;
            Console.WriteLine("arr[mid] 1 -- " + arr[mid]);
            if(arr[mid] == key)
                return mid;
            
            //left sorted array
            if(arr[low] < arr[mid])
            {
                Console.WriteLine("arr[mid] " + arr[mid]);
                Console.WriteLine("arr[low] " + arr[low]);
                if(key < arr[mid] && key >= arr[low])
                {
                    high = mid-1;
                }else
                    low = mid+1;

            }
            else
            {
                if(key > arr[mid] && key <= arr[low])
                {
                    low = mid +1;
                }
                else
                    high = low +1;
            }
            
            // right sorted array
        }

        return -1;
    }

    static int FindArrayInSortedArray(int[] arr, int key)
    {
        int low = 0;
        int high = 1;

        while( arr[high] < key)
        {
            //Console.WriteLine( arr[high]);
            
                low = high;
                high = 2 * high;
            
            
        } 

        return SearchTargetRe(arr, low, high, key);


    }
    static int SearchTargetRe(int[] arr, int low, int high, int key)
    {
        if(low > high)
        {
            return -1;
        }
        int mid = (low + high)/2;
        if(arr[mid] == key)
        {
            return mid;
        }

        if(arr[mid] < key)
        {
            return SearchTargetRe(arr, mid + 1, high, key );
        }
        else
        {
            return SearchTargetRe(arr,low, mid -1, key);
        }        
    }

    static int SearchTarget(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length -1;

        while(low <= high)
        {
            int mid = (low + high) / 2;
            //Console.WriteLine(mid);
            if( arr[mid] == target)
            {                
                return mid;
            }
            
            if(arr[mid] < target)
            {
                //Console.WriteLine("mid hi " + arr[mid]);
                low = mid +1;                
            }
            else
            {
                //Console.WriteLine("mid lo " + arr[mid]);
                high = mid -1;
            }
        }

        return -1;
    }
}