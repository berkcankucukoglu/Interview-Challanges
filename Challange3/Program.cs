internal class Program
{
    private static void Main(string[] args)
    {
        TestCases();
        //This question asked by TestGorilla
    }

    //Takes Number, returns binary Number
    public static int FormatNumberToBinary(int number)
    {
        string binaryRep = string.Empty;
        while (number > 0)
        {
            binaryRep = (number % 2) + binaryRep;
            number = number / 2;
        }
        int resut = int.Parse(binaryRep);
        return resut;
    }

    //Takes binary Number, returns int
    public static int FormatBinaryToNumber(int binaryNumber)
    {
        string intRep = binaryNumber.ToString();
        int base1 = 2;
        int result = 0;
        int len = (intRep.Length) - 1;
        for (int i = 0; i <= len; i++)
        {
            if (intRep[i] != '0')
            {
                result += (int)Math.Pow(base1, (len - i));
            }
        }
        return result;
    }

    //Takes int, converts it into binary Number, reverses the binary and then converts it back to int
    //Takes 10 -> makes 1010, then reverses to 0101, then makes -> 5
    public static int SpecicalFormat(int number)
    {
        var binaryRep = string.Empty;
        var result = 0;
        while (number > 0)
        {
            binaryRep = (number % 2) + binaryRep;
            number = number / 2;
        }

        var reverseRep = string.Empty;
        for (int i = binaryRep.Length - 1; i >= 0; i--)
        {
            reverseRep += binaryRep[i];
        }

        int base1 = 2;
        int len = (reverseRep.Length) - 1;
        for (int i = 0; i <= len; i++)
        {
            if (reverseRep[i] != '0')
            {
                result += (int)Math.Pow(base1, (len - i));
            }
        }
        return result;
    }

    public static void TestCases()
    {
        int number1 = 10;
        int number2 = 21;
        int number3 = 45;
        int binaryNumber1 = FormatNumberToBinary(number1); //1010
        int binaryNumber2 = FormatNumberToBinary(number2); //10101
        int binaryNumber3 = FormatNumberToBinary(number3); //101101
        int numberX = FormatBinaryToNumber(binaryNumber1); //-> 10
        int numberY = FormatBinaryToNumber(binaryNumber2); //-> 21
        int numberZ = FormatBinaryToNumber(binaryNumber3); //-> 45
        int numberSpecial = SpecicalFormat(number1); //->5
        Console.WriteLine(string.Concat(binaryNumber1, "-", binaryNumber2, "-", binaryNumber3, "-", numberSpecial));
        Console.WriteLine(string.Concat(numberX, "-", numberY, "-", numberZ));
    }
}