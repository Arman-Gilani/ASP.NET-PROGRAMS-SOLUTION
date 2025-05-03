// See https://aka.ms/new-console-template for more information

class L1P10 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine(" WRITE A PROGRAM TO SWAP WITHOUT USING THIRD VARIABLE.\n\n INPUT:");
        Console.WriteLine("\n ENTER THE FIRST NUMBER:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n ENTER THE SECOND NUMBER:");
        int b = Convert.ToInt32(Console.ReadLine());
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("\n OUTPUT:\n\n THE FIRST NUMBER IS: {0}\n\n THE SECOND NUMBER IS: {1}", a ,b);
    }
}