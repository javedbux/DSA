

public class prsc1
{
    public static void DrivingCode()
    {
        //print number from 5 to 1
        PrintNumber(5);
        Console.WriteLine();
        Console.WriteLine("recursion");
        PrintNumberRecursion(5);

        Console.WriteLine();

        //Print sum of first n natural number
        //int ans = PrintSumOfFirst(5); // { 1+2+3 = 6}
        //Console.WriteLine(ans);

        Console.WriteLine();
        //Print sum of first n natural number
        int ans1 = PrintSumOfFirstRe(3, 0); // { 1+2+3 = 6}
        Console.WriteLine(ans1);

        Console.WriteLine();

        PrintSumOfFirstNatural(3, 0, 0);
        Console.WriteLine();


        // 5! 2!  2* 2
        Console.WriteLine("Factorial");
        int f = FactorialNumber(5);
        Console.WriteLine(f);
        Console.WriteLine();

        // Console.WriteLine("Factorial sec");
        // FactorialNumberFac(5, 0, 0);
        // Console.WriteLine(f);
        // Console.WriteLine();


    }

    static int  FactorialNumber(int n)
    {
        if(n == 0 ||  n ==1)
            return 1;

       return n * FactorialNumber(n-1);
    }

    static void PrintSumOfFirstNatural(int n, int index, int sum)
    {
        if(n == index)
        {
            sum += index;
            Console.Write(sum);
            return;
        }

        sum += index;

        PrintSumOfFirstNatural(n, index + 1, sum);
    }

    static int PrintSumOfFirstRe(int n, int index)
    {
        if(n == index)
        {            
            return 0;
        }


        
        return n + PrintSumOfFirstRe(n -1, index);
    }

    static void PrintNumberRecursion(int n)
    {

        if( n == 0)
        {
            //Console.Write(" " + n);
            return;
        }
        Console.Write(" " + n);
        PrintNumberRecursion(n-1);
    }
    static void PrintNumber(int n)
    {
        for (int i = 5; i > 0 ; i--)
        {
            Console.Write(" " + i);
        }
    }
}