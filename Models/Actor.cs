using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace js960315_MIS4200.Models
{
    public class Actor
    {
        public int actorId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public DateTime actorSince { get; set; }

        public ICollection<Movie> Movie { get; set; }
    }
}