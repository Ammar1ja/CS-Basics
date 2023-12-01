internal class Program

{
    private static void Main(string[] args)

    {
        // Type Casting
        // 1. implicit casting (automatically) 
        // char -> int -> long -> float -> double
        // from less space to bigger
        // ASCII Code 
        char myChar = 'd';
        int myInt = myChar;
        Console.WriteLine("this is int " + myInt);
        long myLong = 53534;
        double myDouble = myLong;
        Console.WriteLine("this is double " + myDouble);

        // 2. Explicit Casting (Manually)
        // convert a larger type to a smaller size type
        // double -> float -> long -> int -> char
        myInt = (int)myLong;
        Console.WriteLine("my int " + myInt);
        myInt = (int)myDouble;
        Console.WriteLine("my int " + myInt.GetType());
        string g = Convert.ToString(myChar);
        Console.WriteLine("g= " + g + g.GetType());
        // Convert.
        // 1. ToBoolean()
        // 2. ToInt32()
        // 3. ToString()
        // 4. ToDouble()     
        // 5. ToChar()
    }
}