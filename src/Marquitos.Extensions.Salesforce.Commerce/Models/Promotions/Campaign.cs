using Marquitos.Salesforce.Commerce.Models.Shared;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    public class Campaign
    {
        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("enabled-flag"), DefaultValue(false)]
        public bool EnabledFlag { get; set; } = false;

        [XmlElement("campaign-scope")]
        public CampaignScope? CampaignScope { get; set; }

        [XmlElement("start-date"), DefaultValue(typeof(DateTime), "1900-01-01")]
        public DateTime StartDate { get; set; } = new DateTime(1900, 1, 1);

        [XmlElement("end-date"), DefaultValue(typeof(DateTime), "9999-12-31T23:59:59")]
        public DateTime EndDate { get; set; } = new DateTime(9999, 12, 31, 23, 59, 59);

        [XmlElement("customer-groups")]
        public CustomerGroups? CustomerGroups { get; set; }

        [XmlElement("coupons")]
        public PromotionCoupons? PromotionCoupons { get; set; }

        [XmlElement("source-codes")]
        public PromotionSourceCodeGroups? PromotionSourceCodeGroups { get; set; }

        //[XmlElement("store-groups")]
        //public StoreGroups? StoreGroups { get; set; }

        //[XmlElement("stores")]
        //public Stores? Stores { get; set; }

        [XmlElement("custom-attributes")]
        public CustomAttributes? CustomAttributes { get; set; }

        [XmlAttribute("mode"), DefaultValue("delete")]
        public string ImportMode { get; set; } = "delete";

        [XmlAttribute("campaign-id")]
        public string CampaignID { get; set; } = null!;
    }
}
