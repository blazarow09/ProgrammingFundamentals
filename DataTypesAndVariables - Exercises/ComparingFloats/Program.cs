using System;

class ComparingFloats
{
    static void Main()
    {


        double number1 = double.Parse(Console.ReadLine());

        double number2 = double.Parse(Console.ReadLine());
        double deduction = number1 - number2;
        deduction = Math.Abs(deduction);

        if (deduction < 0.000001)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }


    }
}