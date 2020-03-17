using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAspCore.Models
{
    public class Category
    {
        //clé primaire
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public List<Book> Books { get; set; }
    }
}
