// See https://aka.ms/new-console-template for more information

class L2P2 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("\n The marks obtained by a student in 5 different subjects are input through \r\n the keyboard. The student gets a grade as per the following rules:\r\n a. Percentage above or equals to 60-first grade\r\n b. Percentage between 50 to 59-second grade\r\n c. Percentage between 40 and 49-Third grade\r\n d. Percentage less than 40-poor Grade\r\n Write a program to assign the grade obtained by the student\n\nINPUT:");
        Console.WriteLine("\n ENTER THE MARKS OF FIRST SUBJECT:");
        double m1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n ENTER THE MARKS OF SECOND SUBJECT:");
        double m2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n ENTER THE MARKS OF THIRD SUBJECT:");
        double m3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n ENTER THE MARKS OF FOURTH SUBJECT:");
        double m4 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n ENTER THE MARKS OF FIFTH SUBJECT:");
        double m5 = Convert.ToDouble(Console.ReadLine());
        double p = (m1 + m2 + m3 + m4 + m5) / 5;

        if (p >= 60)
        {
            Console.WriteLine("\n OUTPUT:\n\n YOUR PERCENTAGE IS: {0}\n\n YOUR GRADE IS: FIRST GRADE!", p);
        }
        else if (p >= 50 && p <= 59) 
        {
            Console.WriteLine("\n OUTPUT:\n\n YOUR PERCENTAGE IS: {0}\n\n YOUR GRADE IS: SECOND GRADE!", p);
        }
        else if (p >= 40 && p <= 49)
        {
            Console.WriteLine("\n OUTPUT:\n\n YOUR PERCENTAGE IS: {0}\n\n YOUR GRADE IS: THIRD GRADE!", p);
        }
        else
        {
            Console.WriteLine("\n OUTPUT:\n\n YOUR PERCENTAGE IS: {0}\n\n YOUR GRADE IS: POOR GRADE!", p);
        }
    }
}