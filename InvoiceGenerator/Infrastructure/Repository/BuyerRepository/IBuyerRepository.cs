using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceGenerator.Infrastructure.Repository.BaseRepository;
using InvoiceGenerator.InvoiceData;

namespace InvoiceGenerator.Infrastructure.Repository.BuyerRepository
{
    public interface IBuyerRepository : IBaseRepository<Buyer>
    {
    }
}
