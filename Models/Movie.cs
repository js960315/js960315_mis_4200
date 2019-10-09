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

        [Display (Name ="Movie Title")]
        [Required]
        [StringLength(35)]
        public string movieTitle { get; set; }
   
        [Display (Name ="Description of Movie")]
        [Required]
        [StringLength(100)]
        public string movieDescription { get; set; }

        [Display (Name ="Producer of Movie")]
        [Required]
        [StringLength(100)]
        public string producedBy { get; set; }

        [Display (Name ="Movie Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:d}", ApplyFormatInEditMode =true)]
        public DateTime releaseDate { get; set; }

        public ICollection<MovieDetail> MovieDetails { get; set; }

        public int actorId { get; set; }
        public virtual Actor Actor { get; set; }
    }
}