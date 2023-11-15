namespace eTickets.Pl.Models
{
    public class CinemaViewModel
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships
        public List<MovieViewModel> Movies { get; set; }
    }
}
