using InvoiceGenerator.InvoiceData;
using InvoiceGenerator.Infrastructure.Repository.BaseRepository;


namespace InvoiceGenerator.Infrastructure.Repository.InvoiceDetailsRepository
{
    public class InvoiceDetailsRepository : BaseRepository<Invoice>, IInvoiceDetailsRepository
    {
        public InvoiceDetailsRepository(InvocieContex dbContext) : base(dbContext)
        { }
    }
}
