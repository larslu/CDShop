using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CDShop.Models
{
    public class CD
    {
        [Key]
        public int CDId { get; set; }
        [Required]
        public string  Artist { get; set; }
        [Required]
        public string Title { get; set; }

        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
