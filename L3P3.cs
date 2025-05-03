// See https://aka.ms/new-console-template for more information

class L3P3 
{
	public static void Main(string[] args) 
	{
		Console.WriteLine("Write a program to Create a class Bank_Account with Account_No, Email, \r\nUser_Name, Account_Type and Account_Balance as data members. Also \r\ncreate a Member function GetAccountDetails() & DisplayAccountDetails().\n\nINPUT:");
		Bank_Account bank_Account = new Bank_Account();
		bank_Account.GetAccountDetails();
		bank_Account.DisplayAccountDetails();	
	}

	public class Bank_Account 
	{
		public int Account_No, Account_Balance; public string Email, User_Name, Account_Type;

		public void GetAccountDetails() 
		{
			Console.WriteLine("\nENTER THE ACCOUNT NUMBER:");
			Account_No = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nENTER THE ACCOUNT BALANCE:");
			Account_Balance = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nENTER THE EMAIL:");
			Email = Console.ReadLine();
			Console.WriteLine("\nENTER THE USERNAME:");
			User_Name = Console.ReadLine();
			Console.WriteLine("\nENTER THE ACCOUNT TYPE:");
			Account_Type = Console.ReadLine();
		}
		public void DisplayAccountDetails()
		{
			Console.WriteLine("\nOUTPUT:\nTHE ACCOUNT NUMBER IS: {0}",Account_No);
			Console.WriteLine("\nTHE ACCOUNT BALANCE IS: {0}", Account_Balance);
			Console.WriteLine("\nTHE ACCOUNT EMAIL IS: {0}", Email);
			Console.WriteLine("\nTHE ACCOUNT USERNAME IS: {0}", User_Name);
			Console.WriteLine("\nTHE ACCOUNT TYPE IS: {0}", Account_Type);
		}
	}

}