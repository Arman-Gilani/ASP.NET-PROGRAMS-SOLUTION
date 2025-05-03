// See https://aka.ms/new-console-template for more information

class L3P7 
{
	public static void Main(string[] args) 
	{
		Console.WriteLine("Write a program to calculate area of a Rectangle using constructor.\r\n\nINPUT:");
		Rectangle r = new Rectangle();	
	}
	public class Rectangle 
	{
		public double l, w;
		public Rectangle() 
		{
			Console.WriteLine("\nENTER THE VALUE OF LENGTH:");
			l = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("\nENTER THE VALUE OF WIDTH:");
			w = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("\nOUTPUT:\n\nTHE AREA OF RECTANGLE IS: {0}",(l * w));
		}
	}
}