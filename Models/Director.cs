using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using js960315_MIS4200.Models;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace js960315_MIS4200.Models
{
    public class Director
    {
        [Key]
        public int directorId { get; set; }

        [Display(Name = "Director First Name")]
        [Required]
        [StringLength(20)]
        public string directorFirst { get; set; }

        [Display(Name = "Director Last Name")]
        [Required]
        [StringLength(20)]
        public string directorLast { get; set; }

        [Display(Name = "Date of Hire")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime hireDate { get; set; }

        public ICollection<MovieDetail> MovieDetail { get; set; }

    }
}

public class MovieDetail
{
    
    public int movieDetailId { get; set; }

    [Display (Name ="Number of Actors/Actresses")]
    [Required]
    public string numberOfStars { get; set; }
    [Display (Name ="Estimated Earnings From Film")]
    public decimal estimatedEarnings { get; set; }


    //link the MovieDetail to the Movie
    public int movieId { get; set; }
    public virtual Movie Movie { get; set; }

    //link the MovieDetail with the Director
    public int directorId { get; set; }
    public virtual Director Director { get; set; }
}