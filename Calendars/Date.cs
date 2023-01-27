namespace Calendars
{
    internal class Date
    {
        private int _year;
        private YearDate _day;

        public Date(int year, YearDate day)
        {
            _year = year;
            _day = day;
        }
        public override string ToString()
        {
            return _day + "/" + _year;
        }

        public Date AddYears(int count)
        {
            return FirstValidDate(_year + count, _day);
        }

        private Date FirstValidDate(int year, YearDate day)
        {
            if (day.IsLeap() && !IsLeap(year))
                return new Date(year, day.GetNext());
            else
                return new Date(year, day);
        }

        private bool IsLeap(int year)
        {
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                return true;
            else
                return false;
        }
        public Date GetFirstOccurrence(YearDate day)
        {
            if (day.IsBefore(_day))
                return GetFirstDayOccurrence(_year + 1, day);
            else
                return GetFirstDayOccurrence(_year, day);
        }

        private Date GetFirstDayOccurrence(int year, YearDate day)
        {
            if (day.IsLeap())
                return new Date(GetLeap(year), day);
            else
                return new Date(year, day);
        }

        private int GetLeap(int year)
        {
            if (IsLeap(year))
                return year;
            else
                return GetLeap(year + 1);
        }

    }
}