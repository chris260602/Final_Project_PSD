using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain_Services
{
    internal class Tier
    {
        public Guid TierId { get; set; }

        public string TierName { get; set; }

        public int totalPoint { get; set; }

        public void createTier()

        {

            this.TierId = new Guid();

            this.TierName = "Bronze";

            this.totalPoint = 0;

        }

        public void upgradeTier()

        {

            if (this.totalPoint > 3500)

            {

                this.TierName = "Diamond";

            }

            else if (this.totalPoint > 1500)

            {

                this.TierName = "Platinum";

            }

            else if (this.totalPoint > 500)

            {

                this.TierName = "Gold";

            }

        }

        public void addPoint(int points)

        {

            this.totalPoint = this.totalPoint + points;

        }
    }
}
