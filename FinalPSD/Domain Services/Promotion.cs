using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain_Services
{
    internal class Promotion
    {
        public Guid PromotionId { get; set; }

        public string PromotionName { get; set; }

        public DateTime PromotionExpiredDate { get; set; }

        private List<Product> productList;

        public void createPromotion(List<Product> productList, string PromotionName, DateTime PromotionExpiredDate)

        {

            this.PromotionId = new Guid();

            this.PromotionName = PromotionName;

            this.PromotionExpiredDate = PromotionExpiredDate;

            this.productList = productList;

        }
    }
}
