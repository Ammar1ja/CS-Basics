internal class Program
{
    private static void Main(string[] args)
    {
        // Give array size 
        int[] ages = new int[8]; // [,,,,,,,]

        ages[0] = 55; // [55,,,,,,,]
        ages[7] = 35; // [55,,,,,,,35]
        Console.WriteLine(ages[0]);
        Console.WriteLine(ages[7]);
    }
}