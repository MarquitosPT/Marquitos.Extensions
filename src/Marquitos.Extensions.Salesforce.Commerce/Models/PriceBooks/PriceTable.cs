using Marquitos.Salesforce.Commerce.Enums;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.PriceBooks
{
    public class PriceTable
    {
        public PriceTable()
        {

        }

        public PriceTable(string productID, Entry entry)
        {
            ProductID = productID;
            Entries = new List<Entry> { entry };
        }

        public PriceTable(string productID, List<Entry> entries)
        {
            ProductID = productID;
            Entries = entries;
        }

        [XmlAttribute("product-id")]
        public string ProductID { get; set; } = string.Empty;

        [XmlAttribute("mode"), DefaultValue(typeof(PriceTableImportMode), "delete")]
        public PriceTableImportMode ImportMode { get; set; } = PriceTableImportMode.Delete;

        [XmlElement("online-from"), DefaultValue(typeof(DateTime), "1900-01-01")]
        public DateTime OnlineFrom { get; set; } = new DateTime(1900, 1, 1);

        [XmlElement("online-to"), DefaultValue(typeof(DateTime), "9999-12-31T23:59:59")]
        public DateTime OnlineTo { get; set; } = new DateTime(9999, 12, 31, 23, 59, 59);

        [XmlElement("amount", Type = typeof(AmountEntry))]
        [XmlElement("percentage", Type = typeof(PercentageEntry))]
        public List<Entry> Entries { get; set; } = new List<Entry>();

        [XmlElement("price-info")]
        public string? PriceInfo { get; set; }
    }
}
