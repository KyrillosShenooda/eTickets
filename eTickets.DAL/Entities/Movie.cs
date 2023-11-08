﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTickets.DAL.Entities
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        public List<Movie_Actor> Actors_Movies { get; set; }

        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }
        
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }

    }
}