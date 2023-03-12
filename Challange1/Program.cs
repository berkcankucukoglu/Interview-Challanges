internal class Program
{
    private static void Main(string[] args)
    {
        //Test Q1
        int[] testQ1_1 = { 5, 4, 6, 2, 5, 5 };
        int[] testQ1_2 = { 5, 8, 2, 6, 4 };
        int[] testQ1_3 = { 22, 22, 22, 25, 20 };
        int[] testQ1_4 = { 8, 6, 8, 4, 4, 10, 2 };
        Console.WriteLine(ReturnDifference(testQ1_4));
        //Test Q2
        int[] testQ2_1 = { 1, 3, 6, 4, 1, 2 };
        int[] testQ2_2 = { 3, 4, 5 };
        int[] testQ2_3 = { -4, -5 };
        int[] testQ2_4 = { 1, 2, 3 };
        Console.WriteLine(ReturnPositiveMax(testQ2_4));
    }
    /*
    Q1
    N tam sayıdan oluşan bir A dizisi mevcut. Göreviniz A dizisinden, arasındaki farkları eşit olan mümkün olduğu kadar çok tam sayı seçmektir.
    Örneğin, A = [5, 4, 6, 2, 5, 5] için 2, 4, 6 (farklar 2’ye eşit) veya 5, 5, 5 (farklar 0’a eşit) seçebilirsiniz.
    Seçilebilecek maksimum tam sayı sayısı nedir?
        1. A = [5, 8, 2, 6, 4] için fonksiyon 4 döndürmelidir. Dört tam sayı (8, 2, 6 ve 4). Artan düzende ardışık tüm tam sayıların arasındaki fark 2’dir.
        2. A = [22, 22, 22, 25, 20] için fonksiyon 3 döndürmelidir. Üç tam sayı (22, 22, 22).
        3. A = [8, 6, 8, 4, 4, 10, 2] için fonksiyon 5 döndürmelidir. Beş tam sayı (8, 10, 2, 4, 6).
    -> N, [2..50] arasında bir tam sayıdır.
    -> A dizisinin her elemanı [1..100] arasındadır.
    */
    public static int ReturnDifference(int[] nums)
    {
        Array.Sort(nums);
        int currentLength = 2;
        int maxLength = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int diff = nums[j] - nums[i];
                int currentNum = nums[j] + diff;
                int indexCounter = j + 1;
                while (indexCounter < nums.Length)
                {
                    if (nums.Contains(currentNum))
                    {
                        currentLength++;
                        currentNum += diff;
                    }
                    indexCounter++;
                }
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
                currentLength = 1;
            }
        }
        return maxLength;
    }
    /*
    Q2
    N tam sayıdan oluşan bir A dizisi verildiğinde, A'da bulunmayan en küçük pozitif tam sayıyı (0'dan büyük) döndürür.
        1. A = [1, 3, 6, 4, 1, 2] verildiğinde, fonksiyon 5 döndürmelidir.
        2. A = [3, 4, 5] verildiğinde, fonksiyon 1 döndürmelidir.
        3. A = [−5, −4] verildiğinde, fonksiyon 1 döndürmelidir.
        4. A = [1, 2, 3] verildiğinde, fonksiyon 4 döndürmelidir.
    */
    public static int ReturnPositiveMax(int[] nums)
    {
        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
        }
        if (max == 0)
        {
            return 1;
        }
        for (int j = 1; j < nums.Length; j++)
        {
            if (!nums.Contains(max - j))
            {
                return max - j;
            }
            if (max - j == 1)
            {
                return max + 1;
            }
        }
        return 1;
    }
}