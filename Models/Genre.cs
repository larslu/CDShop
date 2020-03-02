using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDShop.Models
{
    public class Genre
    {
        public int GenreId { get; set; }

        public string Genre_Name { get; set; }

        public ICollection<CD> CDs { get; set;}
    }
}
