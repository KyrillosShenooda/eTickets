namespace eTickets.Pl.Models
{
    public class ProducerViewModel
    {
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<MovieViewModel> Movies { get; set; }
    }
}
