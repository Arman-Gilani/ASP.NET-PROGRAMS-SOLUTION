// See https://aka.ms/new-console-template for more information

using static L3P1;

class L3P1 
{
    public static void Main(string[] args) 
    {
        Candidate candidate = new Candidate();
        candidate.GetCandidateDetails();
        candidate.DisplayCandidateDetails();
    }

    public class Candidate 
    {
        int id, Age, Weight, Height;
        string Name;

        public void GetCandidateDetails() 
        {
            Console.WriteLine("\n 1. Write a program to create a class named Candidate with ID, Name, Age, \r\n Weight and Height as data members & also create a member functions like \r\n GetCandidateDetails() and DisplayCandidateDetails().");
            Console.WriteLine("\n INPUT:\n\n ENTER THE CANDIDATE ID:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n ENTER THE CANDIDATE NAME:");
            Name = Console.ReadLine();
            Console.WriteLine("\n ENTER THE CANDIDATE AGE:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n ENTER THE CANDIDATE WEIGHT:");
            Weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n ENTER THE CANDIDATE HEIGHT:");
            Height = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayCandidateDetails() 
        {
            Console.WriteLine("\n OUTPUT:\n\n THE CANDIDATE ID IS: {0}",id);
            Console.WriteLine("\n THE CANDIDATE NAME IS: {0}",Name);
            Console.WriteLine("\n THE CANDIDATE AGE IS: {0}", Age);
            Console.WriteLine("\n THE CANDIDATE WEIGHT IS: {0}", Weight);
            Console.WriteLine("\n THE CANDIDATE HEIGHT IS: {0}", Height);
        }

    }

}