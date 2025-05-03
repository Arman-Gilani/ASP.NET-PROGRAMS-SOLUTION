// See https://aka.ms/new-console-template for more information

class L3P2 
{
	public static void Main(string[] args) 
	{
		Console.WriteLine("Write a program to create a class Staff having data members as Name, \r\nDepartment, Designation, Experience & Salary. Accept this data for 5\r\ndifferent staffs and display only names & salary of those staff who are \r\nHOD.\r\n\nINPUT:");
		Staff[] staff = new Staff[2];
		for(int i = 0; i < staff.Length; i++)
			staff[i] = new Staff();
		Console.WriteLine("\nOUTPUT:");
		for (int i = 0; i < staff.Length; i++)
			if (staff[i].Designation=="HOD" || staff[i].Designation == "hod") 
				Console.WriteLine("\nSTAFF NAME = {0}\n\nSTAFF SALARY = {1}", staff[i].Name, staff[i].Salary);
	}

	public class Staff 
	{
		public string Name, Department, Designation, Experience; public int Salary;
		public Staff() 
		{
			Console.WriteLine("\nENTER THE STAFF NAME:");
			Name = Console.ReadLine();
			Console.WriteLine("\nENTER THE STAFF DEPARTMENT:");
			Department = Console.ReadLine();
			Console.WriteLine("\nENTER THE STAFF DESIGNATION:");
			Designation = Console.ReadLine();
			Console.WriteLine("\nENTER THE STAFF EXPERIENCE:");
			Experience = Console.ReadLine();
			Console.WriteLine("\nENTER THE STAFF SALARY:");
			Salary = Convert.ToInt32(Console.ReadLine());		
		}
	}

}