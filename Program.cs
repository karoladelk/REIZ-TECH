using System;

namespace ClockAngleCalculator
{
    class Program
    {
        static double CalculateAngle(int hours, int minutes)
        {
            double hourAngle = (hours % 12 + (double)minutes / 60) * 30;
            double minuteAngle = minutes * 6;
            double angle = Math.Abs(hourAngle - minuteAngle);
            return Math.Min(angle, 360 - angle);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the hours (0-12): ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Enter the minutes (0-59): ");
                int minutes = int.Parse(Console.ReadLine());

                if (hours < 0 || hours > 12 || minutes < 0 || minutes > 59)
                {
                    throw new ArgumentException("Invalid input!");
                }

                double angle = CalculateAngle(hours, minutes);

                Console.WriteLine($"The smaller angle between the hour and minute hands is: {angle} degrees.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
