using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace InvoiceGenerator.InvoiceData
{
    public class Buyer
    {
        [Key]
        public int BuyerId { get; set; }

        public string CompanyName  { get; set; }

        public string Name { get; set; }

        public string SecondName { get; set; }
        
        [AllowNull, MaxLength(20)]
        public string Street { get; set; }

        [AllowNull, MaxLength(10)]
        public string PostalCode { get; set; }

        [AllowNull, MaxLength(20)]
        public string City { get; set; }

        [MaxLength(15)]
        public string NIP { get; set; }

        [ForeignKey("Id")]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
