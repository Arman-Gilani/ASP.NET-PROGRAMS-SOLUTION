// See https://aka.ms/new-console-template for more information

class L3P4 
{
	public static void Main(string[] args) 
	{
		Console.WriteLine("Write a program with following specifications: \r\nClass Name: Student\r\nData Members: Enrollment_No, Student_Name, Semester, CPI and SPI\r\nGet Students Details using constructor and DisplayStudentDetails() using \r\nmember function.\n\nINPUT:");
		Student student = new Student();
		student.DisplayStudentDetails();
	}

	public class Student 
	{
		public string Student_Name; public int Enrollment_No, Semester, CPI, SPI;
		public Student() 
		{
			Console.WriteLine("\nENTER THE STUDENT NAME:");
			Student_Name = Console.ReadLine();
			Console.WriteLine("\nENTER THE STUDENT ENROLLMENT NUMBER:");
			Enrollment_No = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nENTER THE STUDENT SEMESTER:");
			Semester = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nENTER THE STUDENT CPI:");
			CPI = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nENTER THE STUDENT SPI:");
			SPI = Convert.ToInt32(Console.ReadLine());
		}
		public void DisplayStudentDetails() 
		{
			Console.WriteLine("\nOUTPUT:\n\nTHE STUDENT NAME IS: {0}", Student_Name);
			Console.WriteLine("\nTHE STUDENT ENROLLMENT NUMBER IS: {0}", Enrollment_No);
			Console.WriteLine("\nTHE STUDENT SEMESTER IS: {0}", Semester);
			Console.WriteLine("\nTHE STUDENT CPI IS: {0}", CPI);
			Console.WriteLine("\nTHE STUDENT SPI IS: {0}", SPI);
		}
	}

}