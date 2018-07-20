using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string secondName = "Jonson";
            int age = 27;
            char gender = 'f';
            long pId = 8306112507;
            uint employeeNum = 27563571;

            Console.WriteLine($"First name: {firstName}" +                
                $"\nLast name: {secondName}" +
                $"\nAge: {age}" +
                $"\nGender: {gender}" +
                $"\nPersonal ID: {pId}" +
                $"\nUnique Employee number: {employeeNum} ");


        }
    }
}
