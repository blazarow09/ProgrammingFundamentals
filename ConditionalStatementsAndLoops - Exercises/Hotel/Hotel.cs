using System;

namespace Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int overnightsCount = int.Parse(Console.ReadLine());

            double Studio = 0.0;
            double Double = 0.0;
            double Suite = 0.0;
            double discount = 0.0;

            if (month == "May" || month == "October")
            {
                Studio = 50;
                Double = 65;
                Suite = 75;
                if (overnightsCount >= 7)
                {
                    Studio = Studio - (Studio * 0.05);
                }
            }
            else if (month == "June" || month == "September")
            {
                Studio = 60;
                Double = 72;
                Suite = 82;
                if (overnightsCount >= 14)
                {
                    Double = Double - (Double * 0.1);
                }            
            }
            else if (month == "July" || month == "December" || month == "August")
            {
                Studio = 68;
                Double = 77;
                Suite = 89;
                if (overnightsCount >= 14)
                {
                    Suite = Suite - (Suite * 0.15);
                }
            }

            if (month == "September" || month == "October" && overnightsCount >= 7)
            {
                Console.WriteLine($"Studio: {Studio * overnightsCount - Studio:f2} lv.");
                Console.WriteLine($"Double: {Double * overnightsCount:f2} lv.");
                Console.WriteLine($"Suite: {Suite * overnightsCount:f2} lv.");
                return;
            }
            

                Console.WriteLine($"Studio: {Studio * overnightsCount:f2} lv.");
                Console.WriteLine($"Double: {Double * overnightsCount:f2} lv.");
                Console.WriteLine($"Suite: {Suite * overnightsCount:f2} lv.");
            

           
        }
    }
}
