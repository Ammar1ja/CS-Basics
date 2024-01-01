internal class Program
{
    private static void Main(string[] args)
    {
        // visiting the array
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]); // names[0] names[1] names[2] names[3]
        }

        // add value 
        // names[6] = "Baraa";
        // change value
        names[0] = "Baraa";
        Console.WriteLine(names[0]);
    }
}