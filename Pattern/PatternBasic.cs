

public class PatternBasic
{
    public static void DrivingCode()
    {
        int n =4;
        int m =5;

        // Solid Rectangle & Nested Loops
        Console.WriteLine("Solid Rectangle & Nested Loops");
        for(int i = 1; i<= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                Console.Write(" *");   
            }
            Console.WriteLine();
        }

        //Hollow Rectangle 
        Console.WriteLine("Hollow Rectangle ");

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <=m; j++)
            {
                if(i == 1 || j == 1 || i == n || j == m)
                {
                    Console.Write("*" );
                }
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        //Print the Half Pyramid 
        for (int i =1; i <=n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        //Inverted Half Pyramid 
        for (int i = 1; i <=n; i++)
        {
            for (int j = n; j >=i; j--)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }

        //inverted & Rotated Half Pyramid
        Console.WriteLine("inverted & Rotated Half Pyramid");
         
       for (int i =1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <=i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        //Half Pyramid with Numbers -
        Console.WriteLine("Half Pyramid with Numbers");
        
        int k = 5;
        for (int i =1; i <= k; i++)
        {
            //Console.Write(i);
            for (int j = 1; j <=i; j++)
            {
                Console.Write( " " +j);
                
            }
            Console.WriteLine();
        }

        Console.WriteLine();
                //Half Pyramid with Numbers -
        Console.WriteLine("Half Pyramid with Numbers");
        int number = 1;
        //int k = 5;
        
        for (int i =1; i <= k; i++)
        {
            //Console.Write(i);
            for (int j = 1; j <= k - i + 1; j++)
            {
                Console.Write(" " + j);    
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        //Floyd's Triangle
        Console.WriteLine("Floyd's Triangle");
        for (int i = 1; i <= k; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(" "+ number);
                number++;
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        //0-1 Triangle
        Console.WriteLine("0-1 Triangle");
        
        for (int i = 1; i <= k; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                int sum = i + j;
                //Console.Write(sum + " ");
                if(sum % 2 == 0)
                {
                    Console.Write(" 1" );
                }
                else
                {
                    Console.Write(" 0");
                }
                //Console.Write("1");
            }
            Console.WriteLine();
        }

    }
}