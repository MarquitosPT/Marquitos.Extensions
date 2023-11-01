namespace Marquitos.Salesforce.Commerce.Models.PriceBooks
{
    public class PercentageEntry : Entry
    {
        public PercentageEntry()
        {

        }

        public PercentageEntry(decimal value, decimal quantity = 1)
        {
            Value = value;
            Quantity = quantity;
        }
    }
}
