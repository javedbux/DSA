
public class AdvancePattern
{
    public static void DrivingCode()
    {
        //Butterfly

        int n =5;
        Console.WriteLine("Butterfly");
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            int spaces = 2 * (n -i);
            for (int j = 1; j <= spaces; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

        }

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            int spaces = 2 * (n -i);
            for (int j = 1; j <= spaces; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

        }
        Console.WriteLine();
        Console.WriteLine("Butterfly");
        

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            int spaces = 2 * (n -i);
            for (int j = 1; j <= spaces; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            int spaces = 2 * (n -i);
            for (int j = 1; j <= spaces; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

        }

        Console.WriteLine();

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n -i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= n ; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        
    }
}