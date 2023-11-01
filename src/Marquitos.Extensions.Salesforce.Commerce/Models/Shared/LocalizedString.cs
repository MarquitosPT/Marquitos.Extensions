using Marquitos.Salesforce.Commerce.Enums;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Shared
{
    public class LocalizedString
    {
        public LocalizedString()
        {
            Value = string.Empty;
            Language = Language.Default;
        }

        public LocalizedString(string value, Language language = Language.Default)
        {
            Value = value;
            Language = language;
        }

        [XmlText]
        public string Value { get; set; }

        [XmlAttribute("xml:lang")]
        public Language Language { get; set; }
    }
}
