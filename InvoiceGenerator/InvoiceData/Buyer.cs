using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceGenerator.InvoiceData
{
    public class Buyer
    {
        [Key]
        public int BuyerId { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string NIP { get; set; }

        [ForeignKey("Id")]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
