// See https://aka.ms/new-console-template for more information

class L1P5 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("\n WRITE A PROGRAM TO CALCULATE AREA OF SQUARE, RECTANGLE AND CIRCLE.");
        
        Console.WriteLine("\n => SQUARE \n\n INPUT: \n\n ENTER THE LENGTH: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n OUTPUT: \n\n THE AREA OF SQUARE IS: {0}",length*length);

        Console.WriteLine("\n\n => RECTANGLE \n\n INPUT:");
        Console.WriteLine("\n ENTER THE LENGTH: ");
        double recLength = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n ENTER THE WIDTH: ");
        double recWidth = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n OUTPUT: \n\n THE AREA OF RECTANGLE IS: {0}", recLength * recWidth);

        Console.WriteLine("\n\n => CIRCLE \n\n INPUT:");
        Console.WriteLine("\n ENTER THE RADIUS: ");
        double cirRadius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n OUTPUT: \n\n THE AREA OF RECTANGLE IS: {0}", 3.14 * cirRadius * cirRadius);
    }
}