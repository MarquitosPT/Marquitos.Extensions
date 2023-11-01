using Marquitos.Salesforce.Commerce.Enums;

namespace Marquitos.Salesforce.Commerce.Models.Shared
{
    public class LocalizedStrings : List<LocalizedString>
    {
        public LocalizedStrings()
        { }

        public LocalizedStrings(string value, Language language = Language.Default)
        {
            Add(new LocalizedString(value, language));
        }

        public LocalizedStrings(LocalizedString value)
        {
            Add(value);
        }

        public LocalizedStrings(params LocalizedString[] value)
        {
            AddRange(value);
        }
    }
}
