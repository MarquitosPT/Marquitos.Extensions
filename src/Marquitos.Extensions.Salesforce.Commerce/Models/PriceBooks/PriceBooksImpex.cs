using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.PriceBooks
{
    [XmlRoot("pricebooks", Namespace = "http://www.demandware.com/xml/impex/pricebook/2006-10-31")]
    public class PriceBooksImpex
    {
        public PriceBooksImpex()
        {
            PriceBooks = new List<PriceBook>();
        }

        public PriceBooksImpex(PriceBook priceBook)
        {
            PriceBooks = new List<PriceBook> { priceBook };
        }

        public PriceBooksImpex(params PriceBook[] values)
        {
            PriceBooks = new List<PriceBook>(values);
        }

        public PriceBooksImpex(IEnumerable<PriceBook> values)
        {
            PriceBooks = new List<PriceBook>(values);
        }

        [XmlElement("pricebook")]
        public List<PriceBook> PriceBooks { get; set; }
    }
}
