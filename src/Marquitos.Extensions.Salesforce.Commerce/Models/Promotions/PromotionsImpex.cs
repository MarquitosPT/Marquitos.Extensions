using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    [XmlRoot("promotions", Namespace = "http://www.demandware.com/xml/impex/promotion/2008-01-31")]
    public class PromotionsImpex
    {
        [XmlElement("campaign")]
        public List<Campaign> Campaigns { get; set; } = new List<Campaign>();

        [XmlElement("global-promotion-settings")]
        public List<PromotionSettings> PromotionSettings { get; set; } = new List<PromotionSettings>();

        [XmlElement("promotion")]
        public List<Promotion> Promotions { get; set; } = new List<Promotion>();

        [XmlElement("promotion-campaign-assignment")]
        public List<PromotionCampaignAssignment> PromotionCampaignAssignments { get; set; } = new List<PromotionCampaignAssignment>();
    }
}
