// See https://aka.ms/new-console-template for more information

class L1P6 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("\n WRITE A PROGRAM TO CALCULATE CELSIUS TO FAHRENHEIT AND VICA-VERSA USING FUNCTION.\n\n INPUT:");
        Console.WriteLine("\n ENTER THE CELSIUS TEMPERATURE:");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n ENTER THE FAHRENHEIT TEMPERATURE:");
        double f = Convert.ToDouble(Console.ReadLine());
        temperature(c, f);
    }
    public static void temperature(double c, double f) 
    {
        Console.WriteLine("\n OUTPUT:\n\n THE FAHRENHEIT TEMPERATURE IS: {0}", (c * 9 / 5) + 32);
        Console.WriteLine("THE CELSIUS TEMPERATURE IS: {0}", (f - 32) * 5 / 9);
    }
}