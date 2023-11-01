using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    public class PromotionCampaignAssignment
    {
        [XmlElement("qualifiers")]
        public PromotionQualifiers? PromotionQualifiers { get; set; }

        [XmlElement("customer-groups")]
        public CustomerGroups? CustomerGroups { get; set; }

        [XmlElement("coupons")]
        public PromotionCoupons? PromotionCoupons { get; set; }

        [XmlElement("source-codes")]
        public PromotionSourceCodeGroups? PromotionSourceCodeGroups { get; set; }

        [XmlElement("rank"), DefaultValue(0)]
        public int PromotionRank { get; set; }

        [XmlElement("schedule")]
        public PromotionSchedule? PromotionSchedule { get; set; }

        [XmlAttribute("mode"), DefaultValue("delete")]
        public string ImportMode { get; set; } = "delete";

        [XmlAttribute("promotion-id")]
        public string PromotionID { get; set; } = null!;

        [XmlAttribute("campaign-id")]
        public string CampaignID { get; set; } = null!;
    }
}
