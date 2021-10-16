using System;

namespace A21_Ex03_IdoAmira_207947250_SaarSkittel_308471473
{
    public class EventClock : Clock
    {
        public override string ClockToDisplay(string i_Date)
        {
            string countdownString = string.Empty;
            i_Date = i_Date.Substring(0, 15);
            DateTime eventTime = DateTime.Parse(i_Date.ToString());
            this.UpdateTimeByIntervalBetweenTwoDates(eventTime, DateTime.Now);
            if (eventTime >= DateTime.Now)
            {
                countdownString = string.Format("The event will begin in: {0}", this.ToString());
            }
            else
            {
                countdownString = string.Format("The event ended in: {0}", this.ToString());
            }

            return countdownString;
        }

}
}
