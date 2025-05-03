// See https://aka.ms/new-console-template for more information

class L1P7 
{
    public static void Main(string[] args) 
    {
        calculateSimpleInterest();
    }
    public static void calculateSimpleInterest() 
    {
        Console.WriteLine("\n WRITE A PROGRAM TO FIND OUT SIMPLE INTEREST USING FUNCTION. (I = PRN/100)\n\n INPUT:");
        Console.WriteLine("\n ENTER THE VALUE FOR P:");
        double p = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n ENTER THE VALUE FOR R:");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n ENTER THE VALUE FOR N:");
        double n = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n OUTPUT:\n\n THE SIMPLE INTEREST IS: {0}", (p* r * n )/100);
    }
}