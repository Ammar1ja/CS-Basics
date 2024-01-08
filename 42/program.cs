internal class Program
{
    private static void Main(string[] args)
    {
        // Example 3: add numbers
        double addNums(double num1, double num2) // parameters num1[10], num2[20]
        {
            double num3 = num1 + num2; // 10 + 20 = 30
            return num3; // 30 [double]
        }
        // calling method 
        double answer = addNums(10, 20); // arguments: actual values
        answer = addNums(100, 20.3);
        Console.WriteLine(answer);
    }
}