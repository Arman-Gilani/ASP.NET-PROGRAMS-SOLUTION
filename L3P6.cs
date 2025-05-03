// See https://aka.ms/new-console-template for more information

class L3P6 
{
	public static void Main(string[] args) 
	{
		Console.WriteLine("Write a program to Define a class Distance have data members dist1, dist2, \r\ndist3. Initialize the two data members using constructor and store their \r\naddition in third data member using function and display addition.\n\nINPUT:");
		Distance distance = new Distance();
		distance.calculateDistance();
	}
	public class Distance 
	{
		public double dist1, dist2, dist3;
		public Distance() 
		{
			dist1 = 0;
			dist2 = 0;
		}
		public void calculateDistance() 
		{
			Console.WriteLine("\nENTER THE FIRST DISTANCE:");
			dist1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("\nENTER THE SECOND DISTANCE:");
			dist2 = Convert.ToDouble(Console.ReadLine());
			dist3 = dist1 + dist2;
			Console.WriteLine("\nOUTPUT:\n\nTHE ADDITION OF TWO DISTANCES ARE: {0}",(dist3));
		}
	}
}