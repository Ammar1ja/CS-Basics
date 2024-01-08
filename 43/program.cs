internal class Program
{
    private static void Main(string[] args)
    {
        // Example 4: Average
        double clacAvg()
        {
            // sum 
            double sum = 0;
            Console.Write("Please Enter Number Of Subjects: ");
            // getting n[number of subjects] from user 
            int n = int.Parse(Console.ReadLine());
            // array of subjects
            double[] subjects = new double[n];
            // getting subjects values
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter subject {i + 1}: ");
                subjects[i] = double.Parse(Console.ReadLine()); // 80
                sum += subjects[i];
            }
            return sum / n;
        }
        double answer = clacAvg();
        Console.WriteLine("avg = " + answer);
    }
}