// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Diagnostics;
using System;
class L1P8
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" WRITE A PROGRAM TO CREATE A SIMPLE CALCULATOR FOR TWO NUMBERS (ADDITION,MULTIPLICATION,SUBTRACTION,DIVISION) [ALSO USING IF ELSE & SWITCH CASE].");
        calculatorUsingIfElse();
        calculatorUsingSwitchCase();
    }
    public static void calculatorUsingIfElse() 
    {
        Console.WriteLine("\n\n => CALCULATOR USING IF ELSE:");
        Console.WriteLine("\n INPUT:\n\n ENTER THE FIRST NUMBER: ");
        double a=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n ENTER THE SECOND NUMBER: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n ENTER THE OPERATOR [+,-,*,/]: ");
        string? o = Console.ReadLine();
        if(o == "+") 
        {
            Console.WriteLine("\n OUTPUT:\n\n THE ADDITION IS: {0}", (a + b));
        }
        else if(o == "-") 
        {
            Console.WriteLine("\n OUTPUT:\n\n THE SUBTRACTION IS: {0}", (a - b));
        }
        else if (o == "*")
        {
            Console.WriteLine("\n OUTPUT:\n\n THE MULTIPLICATION IS: {0}", (a * b));
        }
        else if (o == "/")
        {
            Console.WriteLine("\n OUTPUT:\n\n THE DIVISION IS: {0}", (a / b));
        }
        else
        {
            Console.WriteLine("\n OUTPUT:\n\n INVALID OPERATOR!");
        }
    }
    public static void calculatorUsingSwitchCase()
    {
        Console.WriteLine("\n\n => CALCULATOR USING SWITCH CASE:");
        Console.WriteLine("\n INPUT:\n\n ENTER THE FIRST NUMBER: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n ENTER THE SECOND NUMBER: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n ENTER THE OPERATOR [+,-,*,/]: ");
        string? o = Console.ReadLine();
        switch (o) 
        {
            case "+":
                Console.WriteLine("\n OUTPUT:\n\n THE ADDITION IS: {0}", (a + b));
                break;

            case "-":
                Console.WriteLine("\n OUTPUT:\n\n THE SUBTRACTION IS: {0}", (a - b));
                break;

            case "*":
                Console.WriteLine("\n OUTPUT:\n\n THE MULTIPLICATION IS: {0}", (a * b));
                break;

            case "/":
                Console.WriteLine("\n OUTPUT:\n\n THE DIVISION IS: {0}", (a / b));
                break;

            default:
                Console.WriteLine("\n OUTPUT:\n\n INVALID OPERATOR!");
                break;
        }
    }

}