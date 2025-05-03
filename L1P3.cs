// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Metrics;

class L1P3 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("\n WRITE A PROGRAM TO PROMPT A USER TO INPUT HIS/HER NAME AND COUNTRY NAME AND THEN OUTPUT WILL BE SHOWN AS GIVEN: Hello<yourname> from country<countryname>.\n\n INPUT:");
        Console.WriteLine("\n ENTER YOUR NAME: ");
        string? name = Console.ReadLine();
        Console.WriteLine("\n ENTER YOUR COUNTRY NAME: ");
        string? countryName = Console.ReadLine();
        Console.WriteLine("\n OUTPUT: \n\n Hello {0} from country {1}.", name, countryName);
    }
}