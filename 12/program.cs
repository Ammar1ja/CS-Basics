internal class Program

{
    private static void Main(string[] args)

    {
        //Data Types
        /*
            1. string => "نصوص"
            2. int => ارقام
            3. [double] fload => ارقام او ارقام كسرية
            4. char => character, رمز او حرف واحد
            5. bool => boolean, true or false
         */
        // Variables
        //  data type varName = value;
        // toys toysBox = toys;

        // this var contain my name
        string myName = "Ammar";
        // output my name to console
        Console.WriteLine(myName);

        // this var contains my salary
        double mySalaryFromDouble = 2000;
        string mySalaryFromString = "2000";

        // I'd like to add sum numbers 
        mySalaryFromDouble = mySalaryFromDouble + 500;
        mySalaryFromString = mySalaryFromString + 500;
        Console.WriteLine(mySalaryFromDouble); // 2000
        Console.WriteLine(mySalaryFromString); // 2000

        // this var contain my first letter 
        char myLetter = ';';
        Console.WriteLine(myLetter);

        // this var contains answer to my question 
        bool areYouGoing;
        areYouGoing = true;
        Console.WriteLine(areYouGoing);

    }
}