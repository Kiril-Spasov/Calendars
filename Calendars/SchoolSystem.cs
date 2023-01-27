﻿using System;
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

        public Date GetBeginning(Child child)
        {
            Date oldEnough = child.GetDateByAge(_minAge);
            Date cutoff = oldEnough.GetFirstOccurrence(_cutoff);
            Date schoolDay = cutoff.GetFirstOccurrence(_schoolStart);

            return schoolDay;
        }
    }
}
