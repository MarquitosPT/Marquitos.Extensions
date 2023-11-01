using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    public class CustomerGroups
    {
        public CustomerGroups()
        {
            Values = new List<CustomerGroup>();
        }

        public CustomerGroups(IEnumerable<CustomerGroup> values)
        {
            Values = new List<CustomerGroup>(values);
        }

        [XmlElement("customer-group")]
        public List<CustomerGroup> Values { get; set; }

        [XmlAttribute("match-mode")]
        public string? MatchMode { get; set; }
    }
}
