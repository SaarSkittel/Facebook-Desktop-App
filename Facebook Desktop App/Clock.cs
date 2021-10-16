using System;

namespace A21_Ex03_IdoAmira_207947250_SaarSkittel_308471473
{
    public abstract class Clock
    {
        public TimeSpan TimeToDisplay { get; set; }

        public Clock()
        {
            this.TimeToDisplay = new TimeSpan(0, 0, 0, 0);
        }

        public override string ToString()
        {
            string countDown = string.Format(
                "{0} Days, {1} Hours, {2} Minutes and {3} Seconds",
                this.TimeToDisplay.Days, this.TimeToDisplay.Hours,
                this.TimeToDisplay.Minutes, this.TimeToDisplay.Seconds);
            return countDown;
        }

        public void UpdateTimeByIntervalBetweenTwoDates(DateTime i_Date1, DateTime i_Date2)
        {
            int i = DateTime.Compare(i_Date1, i_Date2);
            if (i > 0)
            {
                this.TimeToDisplay = i_Date1.Subtract(i_Date2);
            }
            else
            {
                this.TimeToDisplay = i_Date2.Subtract(i_Date1);
            }
        }

        public int ConvertToSeconds()
        {
            return (int)this.TimeToDisplay.TotalSeconds;
        }

        public void UpdateTimeBySeconds(int i_TotalTimeInSeconds)
        {
            this.TimeToDisplay = new TimeSpan(0, 0, 0, i_TotalTimeInSeconds);
        }

        public abstract string ClockToDisplay(string i_Date);
    }
}
