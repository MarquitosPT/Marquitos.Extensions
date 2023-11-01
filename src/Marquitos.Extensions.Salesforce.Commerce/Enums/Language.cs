using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Enums
{
    public enum Language
    {
        [XmlEnum("x-default")]
        Default,

        [XmlEnum("en")]
        English,

        [XmlEnum("pt")]
        Portuguese,

        [XmlEnum("fr")]
        French,

        [XmlEnum("es")]
        Spanish
    }
}
