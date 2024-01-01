internal class Program
{
    private static void Main(string[] args)
    {
        // Find Even Numbers from n number
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Please enter number{i + 1} ");
            nums[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < n; j++)
        {
            if (nums[j] % 2 == 0)
            {
                Console.Write($"{nums[j]} ");
            }
        }
    }
}