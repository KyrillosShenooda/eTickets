namespace eTickets.Pl.Models
{
    public class MovieActorViewModel
    {
        public int MovieId { get; set; }
        public MovieViewModel Movie { get; set; }
        public int ActorId { get; set; }
        public ActorViewModel Actor { get; set; }
    }
}