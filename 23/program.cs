internal class Program

{
    private static void Main(string[] args)

    {
        // Logical Operations
        int x = 20;
        // and &&
        Console.WriteLine(x < 5 && x < 10);
        // and
        // false and false = false
        // false and true = false
        // true and false = false
        // true and true = true
        // or || 
        Console.WriteLine(x > 5 || x < 4); // true or false  = true
                                           // or 
                                           // false or false = false
                                           // false or true = true
                                           // true or false = true
                                           // true or true = true

        // not !
        Console.WriteLine(!(x < 5 || x < 4)); // !(false or false)=> !(false)=> true
    }
}