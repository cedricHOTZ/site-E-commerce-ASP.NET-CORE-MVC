using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAspCore.Models
{
    public class Book
    {
        //clé primaire
        [Key]
        public int BookId { get; set; }


        public string Name  { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool InStock { get; set; }
        public decimal Notes { get; set; }
        //clé étrangère
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

       

    }
}
