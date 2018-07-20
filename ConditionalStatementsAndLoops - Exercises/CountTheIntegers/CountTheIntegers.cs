using System;

class Program
{
    static void Main(string[] args)
    {
        var count = 0;
        try
        {
            while (true)
            {
                var n = int.Parse(Console.ReadLine());
                count++;
            }
        }
        catch (Exception)
        {
            Console.WriteLine(count);
        }
    }
}