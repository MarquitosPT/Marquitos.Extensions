using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    public class Coupon
    {
        [XmlAttribute("coupon-id")]
        public string CouponID { get; set; } = null!;
    }
}
