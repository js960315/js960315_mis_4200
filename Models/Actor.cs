using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace js960315_MIS4200.Models
{
    public class Actor
    {
        [Key]
        public int actorId { get; set; }

        [Display (Name ="First Name")]
        [Required]
        [StringLength(20)]
        public string firstName { get; set; }

        [Display (Name ="Last Name")]
        [Required]
        [StringLength(20)]
        public string lastName { get; set; }

        [Display (Name ="Primary Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage ="Phone number must be in the format (xxx) xxx-xxxx OR xxx-xxx-xxxx")]
        public string phoneNumber { get; set; }

        [Display (Name ="Email Address")]
        [Required]
        [EmailAddress(ErrorMessage ="Please enter a valid email address")]
        public string email { get; set; }

        [Display (Name ="Join Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:d}", ApplyFormatInEditMode =true)]
        public DateTime actorSince { get; set; }

        public ICollection<Movie> Movie { get; set; }
    }
}