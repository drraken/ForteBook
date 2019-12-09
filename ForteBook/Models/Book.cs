using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForteBook.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        
        public GenreType GenreType { get; set; }

        [Required]
        [Display(Name="Genre Type")]
        public int GenreTypeId { get; set; }

    }

}