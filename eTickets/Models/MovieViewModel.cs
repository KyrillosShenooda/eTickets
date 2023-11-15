using eTickets.Pl.Helpers.Enums;

namespace eTickets.Pl.Models
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategoryViewModel MovieCategory { get; set; }

        public List<MovieActorViewModel> Actors_Movies { get; set; }

        public int CinemaId { get; set; }

        public int ProducerId { get; set; }
    }
}