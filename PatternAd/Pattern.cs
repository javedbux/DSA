

public class Pattern
{
    public static void DrivingCode()
    {

        int n =5;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + " ") ;
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n -i; j++)
            {
                Console.Write(" ");
            }

            for(int j = i; j >= 1; j--)
            {
                Console.Write(j);
            }

            for (int j = 2; j <= i; j++)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }

            


            Console.WriteLine();
        }

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }

            


            Console.WriteLine();
        }
     

    }
}