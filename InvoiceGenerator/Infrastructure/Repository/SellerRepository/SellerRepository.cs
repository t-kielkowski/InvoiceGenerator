using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceGenerator.InvoiceData;
using InvoiceGenerator.Infrastructure.Repository.BaseRepository;

namespace InvoiceGenerator.Infrastructure.Repository.SellerRepository
{
    public class SellerRepository : BaseRepository<Seller>, ISellerRepository
    {
        public SellerRepository(InvocieContex dbContext) : base(dbContext) 
        { }

        public async Task<ICollection<Seller>> GetSellerNameList()
        {
            var sellers = DbContext.Seller
                .Select(x => new Seller()
                {
                    Name = x.Name,
                    SecondName = x.SecondName

                })
                .ToList();

            return sellers;
        }
    }
}
