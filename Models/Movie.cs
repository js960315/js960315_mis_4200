using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace js960315_MIS4200.Models
{
    public class Movie
    {
        [Key]
        public int movieId { get; set; }
        public string movieTitle { get; set; }
        public string movieDescription { get; set; }
        public string producedBy { get; set; }
        public DateTime releaseDate { get; set; }

        public ICollection<MovieDetail> MovieDetails { get; set; }

        public int actorId { get; set; }
        public virtual Actor Actor { get; set; }
    }
}