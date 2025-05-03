// See https://aka.ms/new-console-template for more information

class L1P2 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("\n WRITE A PROGRAM TO GET TWO NUMBERS FROM USER AND PRINT THOSE TWO NUMBERS.\n\n INPUT:");
        Console.WriteLine("\n ENTER THE FIRST NUMBER: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n ENTER THE SECOND NUMBER: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n OUTPUT:");
        Console.WriteLine("\n THE FIRST NUMBER IS: {0}", a);
        Console.WriteLine("\n THE SECOND NUMBER IS: {0}", b);
    }
}
