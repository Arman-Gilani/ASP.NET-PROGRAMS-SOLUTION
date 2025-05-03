// See https://aka.ms/new-console-template for more information
class L2P4 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("\n Write a program to find out whether a given year is a leap year or not.\r\n\n INPUT:");
        Console.Write("\n ENTER A YEAR: ");
        int year = Convert.ToInt32(Console.ReadLine());

        bool isLeapYear = false;

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                    isLeapYear = true;
            }
            else
                isLeapYear = true;
        }

        if (isLeapYear)
            Console.WriteLine($"\n OUTPUT \n\n {year} is a leap year.");
        else
            Console.WriteLine($"\n OUTPUT \n\n {year} is not a leap year.");
    }
}