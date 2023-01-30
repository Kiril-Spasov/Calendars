using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendars
{
    internal class JulianCalendar : Calendar
    {
        public override bool IsLeapYear(int year) =>
            year % 4 == 0;
        public override string GetName() =>
            "Julian";
    }
}
