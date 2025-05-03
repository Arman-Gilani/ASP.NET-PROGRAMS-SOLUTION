// See https://aka.ms/new-console-template for more information

class L1p9 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine(" WRITE A PROGRAM TO FIND MAXIMUM NUMBER FROM GIVEN 3 NUMBERS.\n\n INPUT:");
        Console.WriteLine("\n ENTER THE FIRST NUMBER:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n ENTER THE SECOND NUMBER:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n ENTER THE THIRD NUMBER:");
        int c = Convert.ToInt32(Console.ReadLine());
        if (a == b && a == c)
            Console.WriteLine("\n OUTPUT: \n\n ALL THE THREE NUMBERS ARE SAME!");
        else if (a == b)
            Console.WriteLine("\n OUTPUT: \n\n THE FIRST AND SECOND NUMBER IS SAME!");
        else if (b == c)
            Console.WriteLine("\n OUTPUT: \n\n THE SECOND AND THIRD NUMBER IS SAME!");
        else if (a == c)
            Console.WriteLine("\n OUTPUT: \n\n THE FIRST AND THIRD NUMBER IS SAME!");
        else if (a > b && a > c)
            Console.WriteLine("\n OUTPUT: \n\n THE FIRST NUMBER IS GREATER! THAT IS {0}.", a);
        else if (b > a && b > c)
            Console.WriteLine("\n OUTPUT: \n\n THE SECOND NUMBER IS GREATER! THAT IS {0}.", b);
        else if (c > a && c > b)
            Console.WriteLine("\n OUTPUT: \n\n THE THIRD NUMBER IS GREATER! THAT IS {0}.", c);
    }
}