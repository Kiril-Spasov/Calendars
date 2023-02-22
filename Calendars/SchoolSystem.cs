using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendars
{
    internal class SchoolSystem
    {
        private YearDate _cutoff;
        private int _minAge;
        private YearDate _schoolStart;

        public SchoolSystem(YearDate cutoff, int minAge, YearDate schoolStart)
        {
            _cutoff = cutoff;
            _minAge = minAge;
            _schoolStart = schoolStart;
        }

        public Date GetBeginning(Child child) =>
                child.GetDateByAge(_minAge)
                     .GetFirstOccurrence(_cutoff)
                     .GetFirstOccurrence(_schoolStart);
    }
}
