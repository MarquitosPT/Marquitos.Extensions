using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    public class PromotionSourceCodeGroups
    {
        public PromotionSourceCodeGroups()
        {
            Values = new List<SourceCodeGroup>();
        }

        public PromotionSourceCodeGroups(List<SourceCodeGroup> values)
        {
            Values = new List<SourceCodeGroup>(values);
        }

        [XmlElement("source-code")]
        public List<SourceCodeGroup> Values { get; set; }
    }
}
