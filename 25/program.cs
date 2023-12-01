internal class Program

{
    private static void Main(string[] args)

    {
        // Else If
        int grades = 90;
        if (grades >= 90)
        {
            Console.WriteLine("Excellent");
        }
        else if (grades >= 80 && grades < 90)
        {
            Console.WriteLine("Very Good");
        }
        else if (grades >= 50 && grades < 80)
        {
            Console.WriteLine("Good");
        }
        else
        {
            Console.WriteLine("Falid");
        }
    }
}