using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Enums
{
    public enum MatchMode
    {
        [XmlEnum("all")]
        All,

        [XmlEnum("any")]
        Any
    }
}
