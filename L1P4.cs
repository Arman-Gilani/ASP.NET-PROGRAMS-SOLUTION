// See https://aka.ms/new-console-template for more information

class L1P4 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("\n WRITE A PROGRAM TO CALCULATE THE SIZE OF THE AREA IN SQUARE-FEET BASED ON SPECIFIED LENGTH AND WIDTH.\n\n INPUT:");
        Console.WriteLine("\n ENTER THE LENGTH: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n ENTER THE WIDTH: ");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n OUTPUT: \n\n THE SIZE OF THE AREA IS: {0}", length*width);
    }
}