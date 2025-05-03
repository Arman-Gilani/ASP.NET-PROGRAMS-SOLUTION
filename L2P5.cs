// See https://aka.ms/new-console-template for more information

class L2P5
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("\n Write a program to print Fibonacci series.\r\n\n INPUT:");
        Console.WriteLine("\n ENTER THE NUMBER:");
        int a = 0, b = 1, temp = 0, n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n OUTPUT:");
        Console.WriteLine(a);
        Console.WriteLine(b);
        for (int i = 3; i <= n; i++) 
        {
            temp = a + b;
            a = b; 
            b = temp;
            Console.WriteLine(temp);   
        }
    }
}