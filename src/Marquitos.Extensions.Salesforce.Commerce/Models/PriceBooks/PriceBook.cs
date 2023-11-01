using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.PriceBooks
{
    public class PriceBook
    {
        [XmlElement("header")]
        public Header Header { get; set; } = null!;

        [XmlElement("price-tables")]
        public PriceTables? PriceTables { get; set; }
    }
}
