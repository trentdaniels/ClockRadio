using System;
namespace ClockRadio
{
    public class ClockRadio
    {
        // Members
        DateTime currentTime;
        bool isRadioOn;
        string currentRadioStation;

        // Constructor
        public ClockRadio()
        {
        }

        // Methods
        public void getCurrentTime () {
            currentTime = DateTime.UtcNow;
            Console.WriteLine("The current time is: " + currentTime + ".");
            Console.ReadLine();
        }
    }
}
