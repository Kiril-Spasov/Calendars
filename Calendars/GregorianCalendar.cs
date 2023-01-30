using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendars
{
    internal class GregorianCalendar : Calendar
    {
        public override bool IsLeapYear(int year) =>
            year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        public override string GetName() =>
            "Gregorian";

    }
}
