// See https://aka.ms/new-console-template for more information

class L3P5 
{
	public static void Main(string[] args) 
	{
		Console.WriteLine("Write a program to Define a class Salary which will contain member \r\nvariable Basic, TA, DA, HRA. Write a program using Constructor with default \r\nvalues for DA and HRA and calculate the salary of employee.\n\nINPUT:");
		Salary salary = new Salary();	
	}
	public class Salary 
	{
		public int TA, DA = 0, HRA = 0;
		public Salary() 
		{
			Console.WriteLine("\nENTER THE VALUE OF TA:");
			TA = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nOUTPUT:\n\nTHE SALARY IS: {0}",(TA + DA + HRA));
		}	
	}
}