using eTickets.BLL.Interfaces;

namespace eTickets.BLL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IActorRepository actorRepository, IProducerRepository producerRepository)
        {
            ActorRepository = actorRepository;
            ProducerRepository = producerRepository;
        }

        public IActorRepository ActorRepository { get; set; }
        public IProducerRepository ProducerRepository { get; set; }
    }
}
