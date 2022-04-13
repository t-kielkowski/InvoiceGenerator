using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceGenerator.Infrastructure.Repository.BaseRepository;
using InvoiceGenerator.InvoiceData;

namespace InvoiceGenerator.Infrastructure.Repository.BuyerRepository
{
    public class BuyerRepository : BaseRepository<Buyer>, IBuyerRepository
    {
        public BuyerRepository(InvocieContex dbContext) : base(dbContext) 
        { }
    }
}
