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
            isRadioOn = false;
        }

        // Methods
        public void GetCurrentTime () {
            currentTime = DateTime.UtcNow;
            Console.WriteLine("The current time is: " + currentTime + ".");
            Console.ReadLine();
        }

        public void ToggleClockRadioPower () {
            if (isRadioOn == false) {
                isRadioOn = true;
                Console.WriteLine("Clock Radio has been turned on");
                Console.ReadLine();
            }
            else {
                isRadioOn = false;
                Console.WriteLine("Clock Radio has been turned off");
                Console.ReadLine();

            }
        }
    }
}
