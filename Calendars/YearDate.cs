namespace Calendars
{
    internal class YearDate
    {
        private int _month;
        private int _day;

        public YearDate(int month, int day)
        {
            _month = month;
            _day = day;
        }

        public override string ToString()
        {
            return _month + "/" + _day;
        }
        public bool IsBefore(YearDate other)
        {
            if (_month < other._month)
            {
                return true;
            }
            else if (_month == other._month)
            {
                if (_day < other._day)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool IsLeap()
        {
            if (_month == 2 && _day == 29)
                return true;
            else
                return false;
        }

        public YearDate GetNext()
        {
            if (IsEndOfMonth())
                return new YearDate(NextMonth(), 1);
            else
                return new YearDate(_month, _day + 1);
        }

        private bool IsEndOfMonth()
        {
            if (_day == DaysInMonth())
                return true;
            else
                return false;
        }

        private int DaysInMonth()
        {
            if (_month == 2)
                return 29;
            else if(_month == 4 || _month == 6 || _month == 9 || _month == 11)
                return 30;
            else
                return 31;
        }
        private int NextMonth()
        {
            if (_month == 12)
                return 1;
            else
                return _month + 1;
        }
    }
}