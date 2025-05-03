// See https://aka.ms/new-console-template for more information

class L2P6
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("\n  Write a program that takes a number as input and displays its equivalent \r\n  binary form.\r\n\n INPUT:");
        Console.Write("\n ENTER THE NUMBER: ");
        int number = Convert.ToInt32(Console.ReadLine());   
        string binary = ConvertToBinary(number);
        Console.WriteLine("\n OUTPUT:\n\n BINARY FORM: " + binary);
    }
    public static string ConvertToBinary(int number)
    {
        if (number == 0)
            return "0";

        string binary = "";
        while (number > 0)
        {
            int remainder = number % 2;
            binary = remainder + binary;
            number = number / 2;
        }

        return binary;
    }

}