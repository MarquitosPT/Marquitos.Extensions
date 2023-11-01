using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.PriceBooks
{
    public abstract class Entry
    {
        private decimal _value;

        [XmlAttribute("quantity")]
        public decimal Quantity { get; set; } = 1m;

        [XmlText]
        public decimal Value { get { return _value; } set { _value = decimal.Parse(value.ToString("N2")); } }
    }
}
