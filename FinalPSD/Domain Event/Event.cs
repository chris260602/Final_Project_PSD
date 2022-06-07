using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain_Event
{
    internal class Event
    {
        private DateTime _recorded, _occured;

        internal Event(DateTime occured)
        {
            this._occured = occured;
            this._recorded = DateTime.Now;
        }
    }
}
