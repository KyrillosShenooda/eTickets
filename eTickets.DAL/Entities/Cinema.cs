using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTickets.DAL.Entities
{
    public class Cinema : BaseEntity
    {
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
