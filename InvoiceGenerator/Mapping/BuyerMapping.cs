using InvoiceGenerator.DTO;
using InvoiceGenerator.InvoiceData;

namespace InvoiceGenerator.Mapping
{
    internal static class BuyerMapping
    {
        public static BuyerDto Extend(this Buyer? buyer)
        {
            return new BuyerDto
            {
                Name = buyer.Name,
                SecondName = buyer.SecondName,
                FullDataString = $"{buyer.Name} \n {buyer.SecondName} \n {buyer.Street} \n {buyer.PostalCode} \n {buyer.City} \n"
            };
        }
    }
}
