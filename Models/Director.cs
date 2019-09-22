using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using js960315_MIS4200.Models;
using System.Data.Entity;

namespace js960315_MIS4200.Models
{
    public class Director
    {
        public int directorId { get; set; }
        public string directorFirst { get; set; }
        public string directorLast { get; set; }
        public DateTime hireDate { get; set; }

        public ICollection<MovieDetail> MovieDetail { get; set; }

    }
}

public class MovieDetail
{
    public int movieDetailId { get; set; }
    public string numberOfStars { get; set; }
    public decimal estimatedEarnings { get; set; }


    //link the MovieDetail to the Movie
    public int movieId { get; set; }
    public virtual Movie Movie { get; set; }

    //link the MovieDetail with the Director
    public int directorId { get; set; }
    public virtual Director Director { get; set; }
}