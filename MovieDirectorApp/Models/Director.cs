using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieDirectorApp.Models
{
    public class Director
    {
        [Key]
        public int DirectorId { get; set; }

        public string Name { get; set; }

        //navigation property
        public virtual ICollection<Movie> Movies { get; set; }
    }
}