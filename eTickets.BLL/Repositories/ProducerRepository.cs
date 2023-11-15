using eTickets.BLL.Interfaces;
using eTickets.DAL.Context;
using eTickets.DAL.Entities;

namespace eTickets.BLL.Repositories
{
    public class ProducerRepository : GenericRepository<Producer>, IProducerRepository
    {
        public ProducerRepository(eTicketsDbContext context) : base(context)
        {
        }
    }
}
