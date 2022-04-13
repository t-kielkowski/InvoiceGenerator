using InvoiceGenerator.DTO;
using InvoiceGenerator.InvoiceData;

namespace InvoiceGenerator.Mapping
{
    internal static class SellerMapping
    {
        public static SellerDto Extend(this Seller? seller)
        {
            return new SellerDto
            {
                Name = seller.Name,
                SecondName = seller.SecondName,
                FullDataString = $"{seller.Name} \n {seller.SecondName} \n {seller.Street} \n {seller.PostalCode} \n {seller.City} \n"
            };
        }
    }
}
