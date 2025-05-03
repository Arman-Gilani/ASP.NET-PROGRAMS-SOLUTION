// See https://aka.ms/new-console-template for more information

class L2P3 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("\n Write a program to check prime number.\r\n\n INPUT:");
        Console.WriteLine("\n ENTER THE NUMBER:");
        int n = Convert.ToInt32(Console.ReadLine());
        int c = 0;
        for (int i = 1; i <= n; i++) 
        {
            if (n % i == 0) 
            {
                c++;
            }
        }
        if(c == 2) 
            Console.WriteLine("\n OUTPUT: \n\n THE NUMBER IS A PRIME NUMBER!");
        else 
            Console.WriteLine("\n OUTPUT: \n\n THE NUMBER IS NOT A PRIME NUMBER!");
    }
}