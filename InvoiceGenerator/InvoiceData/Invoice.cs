using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceGenerator.InvoiceData
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public decimal HourlyRate { get; set; }

        [ForeignKey("SellerId")]
        public Seller Seller { get; set; }
        [ForeignKey("BuyerId")]
        public Buyer Buyer { get; set; }

    }
}
