namespace A21_Ex03_IdoAmira_207947250_SaarSkittel_308471473
{
    public static class ClockFactoryMethod
    {
        public static Clock ClockCreator(eClock i_TypeClock)
        {
            Clock clockToReturn = null;
            switch (i_TypeClock)
            {
                case eClock.EventClock:
                    {
                        clockToReturn = new EventClock();
                        break;
                    }

                case eClock.BirthdayClock:
                    {
                        clockToReturn = new BirthdayClock();
                        break;
                    }
            }

            return clockToReturn;
        }
    }
}
