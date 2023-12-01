internal class Program

{
    private static void Main(string[] args)

    {
        // User Input: Console.ReadLine() => string
        // get name and age from user
        Console.Write("Enter Your Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Your Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Hello {name}, And Your Age is {age}, Your Salary is {salary}");
    }
}