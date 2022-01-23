using System;
namespace Class_Exerecise
{
         public class MainMenu
    {
        public static void PrintResult()
        {
            System.Console.WriteLine("Enter the numerator");
            double numerator = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the denominator");
            double denominator = double.Parse(Console.ReadLine());
            if (denominator % numerator == 0)
            {
                Fraction.CancelDetails(numerator, denominator); 
            }
            else if (numerator  < denominator)
            {
                System.Console.WriteLine(Fraction.PrintDetails(numerator, denominator));     
            }           
            else
            {
                System.Console.WriteLine(Fraction.Parse(numerator, denominator));
            }  
        }
    }
}