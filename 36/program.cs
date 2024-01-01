internal class Program
{
    private static void Main(string[] args)
    {
        // Arrays are static: fixed 
        // Average Array Example
        // n is number of subjects 
        Console.Write("Please enter number of subjects: ");
        int n = int.Parse(Console.ReadLine());
        double[] subjects = new double[n];
        double sum = 0;
        // take array values
        // add the values to the sum
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Please Enter Subject{i + 1} ");
            subjects[i] = double.Parse(Console.ReadLine());
            sum += subjects[i];
        }
        double answer = sum / n;
    }
}