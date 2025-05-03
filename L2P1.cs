// See https://aka.ms/new-console-template for more information

class L2P1 
{
    public static void Main(string[] args) 
    {
        double POUND_TO_KG = 0.45359237;
        double INCH_TO_M = 0.0254;
        Console.WriteLine(" Body Mass Index (BMI) is a measure of health on weight. It can be \r\n calculated by taking your weight in kilograms and dividing by the square of \r\n your height in meters. Write a program that prompts the user to enter a \r\n weight in pounds and height in inches and displays the BMI. \r\n (Note: - 1 pound = 0.45359237 Kg and 1 inch = 0.0254 meters)\n\n INPUT:");
        Console.WriteLine("\n ENTER YOUR WEIGHT IN POUNDS: ");
        double weight_pounds = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n ENTER YOUR HEIGHT IN POUNDS: ");
        double height_inches = Convert.ToDouble(Console.ReadLine());
        double weight_kg = weight_pounds * POUND_TO_KG;
        double height_m = height_inches * INCH_TO_M;
        double bmi = weight_kg / (height_m * height_m);
        Console.WriteLine("\n OUTP UT \n\n THE BMI IS: {0}",bmi);
    }
}