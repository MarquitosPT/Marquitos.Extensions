using Marquitos.Salesforce.Commerce.Enums;
using Marquitos.Salesforce.Commerce.Models.Shared;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.PriceBooks
{
    public class Header
    {
        public Header()
        {
            PriceBookID = string.Empty;
            ImportMode = ImportMode.Delete;
            Currency = "EUR";
            OnlineFrom = new DateTime(1900, 1, 1);
            OnlineTo = new DateTime(9999, 12, 31, 23, 59, 59);
        }

        public Header(string priceBookID, string displayName, bool onlineFlag, DateTime onlineFrom)
            : this(priceBookID, displayName, onlineFlag, onlineFrom, new DateTime(9999, 12, 31, 23, 59, 59))
        { }

        public Header(string priceBookID, string displayName, bool onlineFlag, DateTime onlineFrom, DateTime onlineTo)
        {
            PriceBookID = priceBookID;
            ImportMode = ImportMode.Delete;
            Currency = "EUR";
            DisplayName = new LocalizedStrings(displayName);
            OnlineFlag = onlineFlag;
            OnlineFrom = onlineFrom;
            OnlineTo = onlineTo;
        }

        [XmlAttribute("pricebook-id")]
        public string PriceBookID { get; set; }

        [XmlAttribute("mode"), DefaultValue(typeof(ImportMode), "delete")]
        public ImportMode ImportMode { get; set; }

        [XmlElement("currency")]
        public string Currency { get; set; }

        [XmlElement("display-name")]
        public LocalizedStrings? DisplayName { get; set; }

        [XmlElement("description")]
        public LocalizedStrings? Description { get; set; }

        [XmlElement("online-flag"), DefaultValue(typeof(bool), "false")]
        public bool OnlineFlag { get; set; }

        [XmlElement("online-from"), DefaultValue(typeof(DateTime), "1900-01-01")]
        public DateTime OnlineFrom { get; set; }

        [XmlElement("online-to"), DefaultValue(typeof(DateTime), "9999-12-31T23:59:59")]
        public DateTime OnlineTo { get; set; }

        [XmlElement("parent")]
        public string? Parent { get; set; }

        [XmlElement("feed-based"), DefaultValue(typeof(bool), "false")]
        public bool FeedBased { get; set; }

        [XmlElement("custom-attributes")]
        public CustomAttributes? CustomAttributes { get; set; }
    }
}
