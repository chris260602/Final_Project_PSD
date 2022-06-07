using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EventSourcing
{
    internal class EventSourcing
    {
        private DateTime _recorded, _occured;

        internal EventSourcing(DateTime occured)
        {
            this._occured = occured;
            this._recorded = DateTime.Now;
        }
    }
}