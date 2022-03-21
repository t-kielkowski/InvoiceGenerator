using Microsoft.EntityFrameworkCore;

namespace InvoiceGenerator.InvoiceData
{
    public class InvocieContex : DbContext
    {
        public InvocieContex()
        { }
        public InvocieContex(DbContextOptions<InvocieContex> options) : base(options)
        { }

        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<Invoice> InvoiceDetails { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=PC-DOM;Initial Catalog=Invoices;Integrated Security=true");
        //}
    }
}
