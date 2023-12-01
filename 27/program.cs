internal class Program

{
    private static void Main(string[] args)

    {
        // Ternary Operator
        bool answer = (100 > 200) ? true : false;
        if (answer == true)
        {
            Console.WriteLine("Yes, 100 is greater than 200");
        }
        else
        {
            Console.WriteLine("No, 100 is not greater than 200");
        }
    }
}