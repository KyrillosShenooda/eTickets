using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTickets.BLL.Interfaces
{
    public interface IUnitOfWork
    {
        public IActorRepository ActorRepository { get; set; }
        public IProducerRepository ProducerRepository { get; set; }
    }
}
