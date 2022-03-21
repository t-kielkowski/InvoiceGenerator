using InvoiceGenerator.Infrastructure.Repository.BaseRepository;
using InvoiceGenerator.InvoiceData;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvoiceGenerator.Infrastructure.Repository.SellerRepository
{
    public interface ISellerRepository : IBaseRepository<Seller>
    {
        Task<ICollection<Seller>> GetSellerNameList();
    }
}
