using System.ComponentModel.DataAnnotations;

namespace InvoiceGenerator.InvoiceData
{
    public class Buyer
    {
        [Key]
        public int BuyerID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string NIP { get; set; }
    }
}
