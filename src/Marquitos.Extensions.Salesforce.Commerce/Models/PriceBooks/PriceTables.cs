using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.PriceBooks
{
    public class PriceTables
    {
        public PriceTables()
        {
            Items = new List<PriceTable>();
        }

        public PriceTables(IEnumerable<PriceTable> values)
        {
            Items = new List<PriceTable>(values);
        }

        [XmlElement("price-table")]
        public List<PriceTable> Items { get; set; }
    }
}
