using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Enums
{
    public enum PriceTableImportMode
    {
        [XmlEnum("delete")]
        Delete,

        [XmlEnum("delete-all")]
        DeleteAll
    }
}
