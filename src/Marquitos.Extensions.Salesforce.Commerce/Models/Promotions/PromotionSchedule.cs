using Marquitos.Salesforce.Commerce.Enums;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    public class PromotionSchedule
    {
        [XmlElement("start-date"), DefaultValue(typeof(DateTime), "1900-01-01")]
        public DateTime StartDate { get; set; } = new DateTime(1900, 1, 1);

        [XmlElement("end-date"), DefaultValue(typeof(DateTime), "9999-12-31T23:59:59")]
        public DateTime EndDate { get; set; } = new DateTime(9999, 12, 31, 23, 59, 59);

        [XmlElement("recurrence")]
        public Recurrence? Recurrence { get; set; }
    }

    public class Recurrence
    {
        [XmlElement("day-of-week")]
        public DayOfWeek? DayOfWeek { get; set; }

        [XmlElement("time-of-day")]
        public TimeOfDay? TimeOfDay { get; set; }
    }

    public class DayOfWeek
    {
        [XmlElement("weekday")]
        public List<Weekday> Weekday { get; set; } = new List<Weekday>();
    }

    public class TimeOfDay
    {
        [XmlElement("time-from"), DefaultValue("00:00:00")]
        public TimeOnly TimeFrom { get; set; } = TimeOnly.MinValue;

        [XmlElement("time-to"), DefaultValue("00:00:00")]
        public TimeOnly TimeTo { get; set; } = TimeOnly.MinValue;
    }
}
