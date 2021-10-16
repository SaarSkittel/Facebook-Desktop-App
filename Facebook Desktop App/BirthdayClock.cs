using System;

namespace A21_Ex03_IdoAmira_207947250_SaarSkittel_308471473
{
    public class BirthdayClock : Clock
    {
        public override string ClockToDisplay(string i_Date)
        {
            string stringToReturn = string.Empty;
            DateTime birthday;
            DateTime now = DateTime.Now;
            int year = now.Year;
            string strMonthOfBirth = i_Date.Substring(0, 2);
            int monthOfBirth = int.Parse(strMonthOfBirth);
            string strDayOfBirth = i_Date.Substring(3, 2);
            int dayOfBirth = int.Parse(strDayOfBirth);
            if ((now.Month == monthOfBirth) && (now.Day == dayOfBirth))
            {
                stringToReturn = "Happy Birthday!!";
            }
            else
            {
                if (now.Month < monthOfBirth)
                {
                    year = now.Year;
                }
                else if (now.Month > monthOfBirth)
                {
                    year = now.Year + 1;
                }
                else
                {
                    if (now.Day < dayOfBirth)
                    {
                        year = now.Year;
                    }
                    else if (now.Day > dayOfBirth)
                    {
                        year = now.Year + 1;
                    }
                }

                birthday = new DateTime(year, monthOfBirth, dayOfBirth, 0, 0, 0);
                this.UpdateTimeByIntervalBetweenTwoDates(birthday, now);
                stringToReturn = this.ToString() + " until your birthday!";
            }

            return stringToReturn;
        }
    }
}
