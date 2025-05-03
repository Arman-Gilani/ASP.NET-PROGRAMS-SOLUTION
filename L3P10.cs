// See https://aka.ms/new-console-template for more information

using System;

// Interface: Gross
interface IGross
{
	void Gross_sal();
}

// Interface: Employee
interface IEmployee
{
	void Basic_sal();
}

// Class: FullTimeEmployee
class FullTimeEmployee : IEmployee, IGross
{
	// Data Members
	protected string Name;
	protected double HRA;
	protected double TA;
	protected double DA;

	// Constructor
	public FullTimeEmployee(string name, double hra, double ta, double da)
	{
		Name = name;
		HRA = hra;
		TA = ta;
		DA = da;
	}

	// Method from IGross interface
	public void Gross_sal()
	{
		double grossSal = HRA + TA + DA;
		Console.WriteLine($"Gross Salary: {grossSal}");
	}

	// Method from IEmployee interface
	public void Basic_sal()
	{
		Console.WriteLine($"Employee Name: {Name}");
		Console.WriteLine("Basic Salary Calculation");
		// Add your basic salary calculation logic here
	}
}

class Program
{
	static void Main(string[] args)
	{
		// Create an instance of FullTimeEmployee
		FullTimeEmployee employee = new FullTimeEmployee("John Doe", 5000, 2000, 3000);

		// Call methods
		employee.Basic_sal();
		Console.WriteLine();
		employee.Gross_sal();
	}
}