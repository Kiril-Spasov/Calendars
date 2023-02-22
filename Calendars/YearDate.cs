﻿namespace Calendars
{
    internal class YearDate
    {
        private int _month;
        private int _day;
        private Calendar _calendar;

        public YearDate(Calendar calendar, int month, int day)
        {
            _calendar = calendar;
            _month = month;
            _day = day;
        }

        public override string ToString() =>
            _month + "/" + _day;
        
        public bool IsBefore(YearDate other) =>
          _month < other._month ||
           (_month == other._month && _day < other._day);

        public bool IsLeap() =>
               _calendar.IsLeapDay(_month, _day);

        public YearDate GetNext() =>
        IsEndOfMonth() ? _calendar.Create(_calendar.NextMonth(_month), 1)
                       : _calendar.Create(_month, _day + 1);

        private bool IsEndOfMonth() =>
            _day == _calendar.MaxDaysInMonth(_month);

    }
}