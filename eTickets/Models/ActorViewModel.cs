namespace eTickets.Pl.Models
{
    public class ActorViewModel
    {
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        public List<MovieActorViewModel> Actors_Movies { get; set; }
    }
}
