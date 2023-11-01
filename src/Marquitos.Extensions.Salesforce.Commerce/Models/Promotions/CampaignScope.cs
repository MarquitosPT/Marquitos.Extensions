using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    public class CampaignScope
    {
        [XmlElement("applicable-online")]
        public EmptyElement? ApplicableOnline { get; set; }

        [XmlElement("applicable-in-store")]
        public EmptyElement? ApplicableInStore { get; set; }
    }
}
