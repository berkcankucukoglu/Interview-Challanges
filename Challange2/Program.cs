internal class Program
{
    private static void Main(string[] args)
    {

    }

    /*
    
    Q1:
    Write a method that return dublicate chars as a string from an input string in the same order they
    are in the input
    Ex: "happy" -> p
    Ex: "improper" -> pr
        imput string.lengt <=30, no whitespace and all lowercase.
    */
    public static string returnDublicates(string input)
    {
        string returnString = string.Empty;
        char currentChar;
        for (int i = 0; i < input.Length; i++)
        {
            currentChar = input[0];
            input = input.Remove(0, 1);
            if (input.Contains(currentChar) && !returnString.Contains(currentChar))
            {
                returnString += currentChar;
            }
        }
        return returnString;
    }

    /*
    
    Q2:
    Write a function that returns the largest (maximum) element in the list containing only positive ints.
    Ex: [1,3,4,5,12,2,21,7,8] -> returns 21
    Ex: [3] -> returns 3
    etc.
        list length >=1 and <= 100
    */
    public static int returnMax(int[] nums)
    {
        int maxNumber;
        Array.Sort(nums);
        maxNumber = nums[nums.Length - 1];
        return maxNumber;
    }
}