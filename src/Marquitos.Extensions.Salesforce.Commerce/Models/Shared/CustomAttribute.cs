using Marquitos.Salesforce.Commerce.Enums;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Shared
{
    public class CustomAttribute
    {
        public CustomAttribute()
        {
            Values = new List<string>();
        }

        public CustomAttribute(string attributeID, string value)
        {
            AttributeID = attributeID;
            Values = new List<string>() { value };
        }

        public CustomAttribute(string attributeID, IEnumerable<string> values)
        {
            AttributeID = attributeID;
            Values = new List<string>(values);
        }

        [XmlElement("value")]
        public List<string> Values { get; set; }

        [XmlAttribute("attribute-id")]
        public string AttributeID { get; set; } = null!;

        [XmlAttribute("xml:lang"), DefaultValue(typeof(Language), "x-default")]
        public Language Language { get; set; } = Language.Default;
    }
}
