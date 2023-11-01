using Marquitos.Salesforce.Commerce.Enums;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    public class PromotionQualifiers
    {
        [XmlElement("customer-groups")]
        public EmptyElement? CustomerGroups { get; set; }

        [XmlElement("source-codes")]
        public EmptyElement? SourceCodes { get; set; }

        [XmlElement("coupons")]
        public EmptyElement? Coupons { get; set; }

        [XmlAttribute("match-mode")]
        public MatchMode MatchMode { get; set; } = MatchMode.Any;
    }
}
