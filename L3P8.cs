// See https://aka.ms/new-console-template for more 
using System.Diagnostics;

class L3P8 
{
	public static void Main(string[] args) 
	{
		Console.WriteLine("Create a class Furniture with material ,price as data members. Create \r\nanother class Table with Height , surface_area as data members. Write a\r\nprogram to implement single inheritance.\n\nINPUT:");
		Table table = new Table();
		Console.WriteLine("\n\nOUTPUT:\n\nTHE MATERIAL NAME IS: {0}", table.material);
		Console.WriteLine("\nTHE MATERIAL PRICE IS: {0}", table.price);
		Console.WriteLine("\nTHE MATERIAL HEIGHT IS: {0}", table.Height);
		Console.WriteLine("\nTHE MATERIAL SURFACE AREA IS: {0}", table.surface_area);
	}

	public class Furniture 
	{
		public string material; public double price;
		public Furniture() 
		{
			Console.WriteLine("\nENTER THE MATERIAL NAME:");
			material = Console.ReadLine();
			Console.WriteLine("\nENTER THE MATERIAL PRICE:");
			price = Convert.ToDouble(Console.ReadLine());		
		}
	}
	public class Table : Furniture
	{
		public double Height, surface_area;
		public Table() 
		{
			Console.WriteLine("\nENTER THE MATERIAL HEIGHT:");
			Height = Convert.ToDouble(Console.ReadLine());		
			Console.WriteLine("\nENTER THE MATERIAL SURFACE AREA:");
			surface_area = Convert.ToDouble(Console.ReadLine());
		}
	}

}