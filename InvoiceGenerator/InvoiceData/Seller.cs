using System.ComponentModel.DataAnnotations;

namespace InvoiceGenerator.InvoiceData
{
    public class Seller
    {
        [Key]
        public int SellerId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string NIP { get; set; }
        public string PhoneNumber { get; set; }
    }
}
