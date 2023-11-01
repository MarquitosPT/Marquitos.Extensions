namespace Marquitos.Salesforce.Commerce.Models.PriceBooks
{
    public class AmountEntry : Entry
    {
        public AmountEntry()
        {

        }

        public AmountEntry(decimal value, decimal quantity = 1)
        {
            Value = value;
            Quantity = quantity;
        }
    }
}
