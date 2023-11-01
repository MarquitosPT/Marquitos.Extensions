using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    public class CustomerGroup
    {
        [XmlAttribute("group-id")]
        public string GroupID { get; set; } = null!;
    }
}
