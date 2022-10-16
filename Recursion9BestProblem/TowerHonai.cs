
public class TowerHonai
{
    public static void DrivingCode()
    {


        HonaiMethod(3, "A", "H", "D");

        //Print string in reverse
        Console.WriteLine("Print string in reverse");
        string str = "abc";
        PrintStringReverse(str, str.Length -1 );
        Console.WriteLine();

        //Find first & last occurrence of element

        string str1 = "savdsadfa";
        char element = 'a';
        Occurance(str1, 0, element);
        Console.WriteLine();

        //Check if the array is sorted (strictly increasing)

        int[] arr = {1,2,16,8,9,12};
        bool IsSorte = IsSorted(arr, 0);
        Console.WriteLine(IsSorte);

        //Move all 'x' to the end
        string strr = "asxdcsxa";
        char ele = 'x';
        MoveX2right(strr, 0, ele, "");
        Console.WriteLine();
        Console.WriteLine();


        //Move all 'x' to the left end
        string strrr = "asxdcsxa";
        char ele1 = 'x';
        MoveX2Left(strrr, 0 , ele1, "");
        Console.WriteLine();
    }
    static int count = 0;
    static int count1 = 0;
    static void MoveX2Left(string str, int index, char ele, string newStr)
    {

        if(index == str.Length -1)
        {
            Console.WriteLine("Count - " + count1);
            
            for (int i = 0; i < count1; i++)
            {
                Console.Write("x");
            }
            Console.Write(newStr);
            return;
        }

        char cur = str[index];

        if(cur == ele)
        {
            count1++;
        }
        else
        {
            newStr += cur;
        }

        MoveX2Left(str, index + 1, ele, newStr);
 
    }
static void MoveX2right(string str, int index, char ele, string newStr)
    {

        if(index == str.Length -1)
        {
            Console.WriteLine("Count - " + count);
            Console.Write(newStr);
            for (int i = 0; i < count; i++)
            {
                Console.Write("x");
            }
            return;
        }

        char cur = str[index];

        if(cur == ele)
        {
            count++;
        }
        else
        {
            newStr += cur;
        }

        MoveX2right(str, index + 1, ele, newStr);
 
    }
    static bool IsSorted(int[] arr, int index)
    {
        if(index == arr.Length -1)
        {
            return true;
        }

        int cur = arr[index];
        if(cur < arr[index + 1])
        {
            return IsSorted(arr, index + 1);
        }else
            return false;
    }

    static int first = -1;
    static int last = -1;

    static void Occurance(string str, int index, char element)
    {
        if(index == str.Length)
        {
            Console.Write("First : - " + first + " , Last :- " + last);
            return;
        }

        char cur = str[index];
        if(cur == element)
        {
            if(first == -1)
            {
                first = index;
            }else
                last = index;
        }

        Occurance(str, index +1, element);
    }

    static void PrintStringReverse(string str, int index)
    {
        if(index == 0)
        {
            Console.Write(" " + str[index]);
            return;
        }
        char cur = str[index];
        Console.Write(" " + cur);
        PrintStringReverse(str, index - 1);
    }

    static void HonaiMethod(int disc, string source, string helper, string destination)
    {
        if(disc == 1)
        {
            Console.WriteLine("Disc transfer from Source " + source + " to desttination " + destination);
            return;
        }

        HonaiMethod(disc -1, source, destination, helper);
        Console.WriteLine("Disc transfer from Source " + source + " to desttination " + destination);
        HonaiMethod(disc -1, helper, source, destination);
    }
}