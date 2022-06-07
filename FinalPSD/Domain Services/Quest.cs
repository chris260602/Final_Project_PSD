using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain_Services
{
    internal class Quest
    {
        public Guid QuestId { get; set; }

        public string QuestName { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public bool isDone { get; set; }



        public void createQuest(string QuestName, DateTime startDate, DateTime endDate)
        {

            this.QuestId = new Guid();

            this.QuestName = QuestName;

            this.startDate = startDate;

            this.endDate = endDate;

            this.isDone = false;

        }

        public void questCompleted()

        {

            this.isDone = true;

            // Give user the promotion 

            new Promotion();

        }
    }
}
