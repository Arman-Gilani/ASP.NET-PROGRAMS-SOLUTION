// See https://aka.ms/new-console-template for more information

class L3P9 
{
	public static void Main(string[] args) 
	{
		Console.WriteLine("Write a program for implementing single inheritance which creates one \r\nclass Account_Details for getting account information and another class \r\nInterest for calculating and displaying total interest from the data inserted \r\nfrom account details.\n\nINPUT:");
		Interest interest = new Interest();	
	}
	public class Account_Details 
	{
		public string username;
		public Account_Details() 
		{
			Console.WriteLine("\nENTER THE ACCOUNT USERNAME:");
			username = Console.ReadLine();
		}	
	}
	public class Interest:Account_Details
	{
		public double balance;
		public Interest()
		{
			Console.WriteLine("\nENTER THE ACCOUNT BALANCE:");
			balance = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("\n\nOUTPUT:\n\nTHE ACCOUNT USERNAME IS: {0}\n\nTHE ACCOUNT BALANCE IS: {1}", username, balance);
		}
	}
}