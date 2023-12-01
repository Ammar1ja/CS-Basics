internal class Program

{
    private static void Main(string[] args)

    {
        // grade program
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Grades: ");
        double grades = Convert.ToDouble(Console.ReadLine());
        if (grades >= 90 && grades <= 100)
        {
            Console.WriteLine($"Name: {name}, Grade Answer: Excellent");
        }
        else if (grades >= 80 && grades < 90)
        {

            Console.WriteLine($"Name: {name}, Grade Answer: Very Good");
        }
        else if (grades >= 50 && grades < 80)
        {
            Console.WriteLine($"Name: {name}, Grade Answer: Good");
        }
        else
        {
            Console.WriteLine($"Name: {name}, Grade Answer: F");
        }

    }
}