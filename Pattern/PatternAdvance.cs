
public class PatternAdvance
{
    public static void DrivingCode()
    {

        //Butterfly
        int n =5;
        
        //upper half
        for (int i = 1; i <=n; i++)
        {
            //inner half
            for (int j = 1; j <=i; j++)
            {
                Console.Write("*");
            }

            // spaces
            int spaces = 2 * (n -i);

            for (int j = 1; j <= spaces; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <=i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }


        for (int i = n; i >= 1; i--)
        {
            //inner half
            for (int j = 1; j <=i; j++)
            {
                Console.Write("*");
            }

            // spaces
            int spaces = 2 * (n -i);

            for (int j = 1; j <= spaces; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <=i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}