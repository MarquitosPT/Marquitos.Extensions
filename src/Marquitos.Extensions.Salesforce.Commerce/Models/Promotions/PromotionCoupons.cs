using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    public class PromotionCoupons
    {
        public PromotionCoupons()
        {
            Values = new List<Coupon>();
        }

        public PromotionCoupons(IEnumerable<Coupon> values)
        {
            Values = new List<Coupon>(values);
        }

        [XmlElement("coupon")]
        public List<Coupon> Values { get; set; }
    }
}
