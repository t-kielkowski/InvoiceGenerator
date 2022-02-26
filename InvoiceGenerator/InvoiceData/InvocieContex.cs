using Microsoft.EntityFrameworkCore;

namespace InvoiceGenerator.InvoiceData
{
    internal class InvocieContex
    {
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<InvoiceDetails> InvoiceDetails { get; set; }
    }
}
