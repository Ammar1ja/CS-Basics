internal class Program
{
    private static void Main(string[] args)
    {

        // Switch
        /*
         Syntax
         switch(x){
            case 1: block of code
             break;

             case 2: block of code
             break;
             ...
             case 100 : block of code
             break;
     }       
         */
        Console.Write("Enter day number: ");
        int day = Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Sun");
                break; // exit the switch
            case 2:
                Console.WriteLine("Mon");
                break;
            case 3:
                Console.WriteLine("Tue");
                break;
            case 4:
                Console.WriteLine("Wed");
                break;
            case 5:
                Console.WriteLine("Thur");
                break;
            case 6:
                Console.WriteLine("Fri");
                break;
            case 7:
                Console.WriteLine("Sat");
                break;
            default:
                Console.WriteLine("invalid data");
                break;
        }
    }
}