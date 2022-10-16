

public class Fibanocci
{
    public static void DrivingCode()
    {

        //Print the fibonacci sequence till nth term
        //The first 10 Fibonacci numbers are: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55.
        //The first 10 Fibonacci numbers are: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55.
        // 1 +1 2, 1+2 3, 2+3 5, .............  
        
        int a = 0;
        int b =1;
        Console.WriteLine(a);
        Console.WriteLine(b);
        FiboPrint(7, a, b);

        Console.WriteLine("Stack Height = n");
        //Print x^n (stack height = n) x to the power n
        int ans = CalculatePower(2 , 5); // 2*2*2

        Console.WriteLine(ans);

        Console.WriteLine("Logn");
        //Print x^n (Logn) x to the power n
        int ans1 = CalculatePowerLogn(2 , 5); // 2*2*2

        Console.WriteLine(ans1);

    }

    static int CalculatePowerLogn(int x, int n)
    {
        if(n == 0)
        {
            return 1;
        }
        if(x == 0)
            return 0;

        if(n % 2 == 0)
        {
            return CalculatePowerLogn(x, n/2) * CalculatePowerLogn(x, n/2);
        }
        else
        {
            return CalculatePowerLogn(x, n/2) * CalculatePowerLogn(x, n/2) * x;
        }
       
    }
    static int CalculatePower(int x, int n)
    {
        if(n == 0)
        {
            return 1;
        }
        if(x == 0)
            return 0;

       return  x *  CalculatePower(x, n-1);
    }

    public static void FiboPrint(int n, int a, int b)
    {
        if(n ==0)
        {
            return;
        }
        int c = a + b;
        Console.WriteLine(c);

        FiboPrint(n-1, b, c);

    }
}