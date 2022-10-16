
public class Recursion
{
    public static void DrivingCode()
    {
        //permutation of a string
        string str = "abc";
        PermutationOfString(str, "");

        Console.WriteLine("PermutationOfStringSpace");
        string str1 = "abc";
        PermutationOfStringSpace(str1, 0, "");
    }

    static void PermutationOfString(string str, string permuteStr)
    {

        if(str.Length == 0)
        {
            Console.WriteLine(permuteStr);
            return;
        }
        for(int i =0; i < str.Length; i++)
        {
            char cur = str[i];

            string newStr = str.Substring(0, i) + str.Substring(i+1);

            PermutationOfString(newStr, permuteStr + cur);

        }
        //PermutationOfString(str, index + 1, )
    }

    static void PermutationOfStringSpace(string str, int index, string permuteStr)
    {

        if(str.Length == index)
        {
            Console.WriteLine(permuteStr);
            return;
        }
        
        char curr = str[index];

        PermutationOfStringSpace(str, index + 1, permuteStr + curr);
        PermutationOfStringSpace(str, index + 1, permuteStr + curr);

    }

}