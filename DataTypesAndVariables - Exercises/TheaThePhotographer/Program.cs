using System;

class Program
{
    static void Main(string[] args)
    {
        long picturesTaken = long.Parse(Console.ReadLine());
        long filterTimePerPicture = long.Parse(Console.ReadLine());
        long percentage = long.Parse(Console.ReadLine());
        long uploadTimePerPicture = long.Parse(Console.ReadLine());
        if ((picturesTaken >= 0 && picturesTaken <= 1000000) &&
           (filterTimePerPicture >= 0 && filterTimePerPicture <= 100000) &&
           (percentage >= 0 && percentage <= 100) &&
           (uploadTimePerPicture >= 0 && uploadTimePerPicture <= 100000))
        {

            long timeToFilterInSeconds = picturesTaken * filterTimePerPicture;
            double totalPictures = Math.Ceiling((picturesTaken * (percentage * 0.01)));
            long TimeToUpload = (long)totalPictures * uploadTimePerPicture + timeToFilterInSeconds;

            TimeSpan time = TimeSpan.FromSeconds(TimeToUpload);
            string totalTime = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(totalTime);
        }
    }

}