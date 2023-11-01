using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Shared
{
    public class CustomAttributes
    {
        public CustomAttributes()
        {
            Values = new List<CustomAttribute>();
        }

        public CustomAttributes(IEnumerable<CustomAttribute> values)
        {
            Values = new List<CustomAttribute>(values);
        }

        [XmlElement("custom-attribute")]
        public List<CustomAttribute> Values { get; set; }
    }
}
