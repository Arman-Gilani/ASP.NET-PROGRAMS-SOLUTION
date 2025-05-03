// See https://aka.ms/new-console-template for more information

class L2P7 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("\n Write a program to calculate the nPr. (nPr = n! / (n - r)!)\n\n INPUT:");
        Console.WriteLine("\n ENTER THE VALUE OF N:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n ENTER THE VALUE OF R:");
        int r = Convert.ToInt32(Console.ReadLine());
        int fact1 = 1, fact2 = 1;
        for (int i = 1; i <= n; i++)
            fact1 *= i;
        for (int i = 1; i <= n-r; i++)
            fact2 *= i;
        Console.WriteLine("\n OUTPUT:\n\n nPr = {0}", (fact1/fact2));
    }
}