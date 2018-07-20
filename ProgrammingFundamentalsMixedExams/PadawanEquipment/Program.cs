using System;


namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double sabersCount = Math.Ceiling(students + students * 0.1);
            double robesCount = students;
            double beltsCount = (students == 0) ? 0 : students - (students / 6);

            double totalSum = (lightsabersPrice * sabersCount)+ (robesPrice * robesCount)+ (beltsPrice * beltsCount); 

            if (totalSum < amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalSum - amountOfMoney:f2}lv more.");
            }
        }
    }
}
