using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendars
{
    internal class Child
    {
        private string _name;
        private Date _birthdate;

        public Child(string name, Date birthdate)
        {
            _name = name;
            _birthdate = birthdate;
        }
    }
}
