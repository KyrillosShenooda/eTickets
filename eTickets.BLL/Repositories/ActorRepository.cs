using eTickets.BLL.Interfaces;
using eTickets.DAL.Context;
using eTickets.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTickets.BLL.Repositories
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(eTicketsDbContext context) : base(context)
        {
        }
    }
}
