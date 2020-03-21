using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAspCore.Models
{
    public class OrderDetail
    {
        //Détail de la commande
        [Key]
        public int OrderDetailId { get; set; }
        public int BookId { get; set; }
        //Nombre d'exemplaire
        public int Amount { get; set; }

        public decimal Price { get; set; }

        // Objet Book
        public Book book { get; set; }

        //Clé étrangère order
        [ForeignKey("Order")]
        public int OrderId { get; set; } 
      
        public Order Order { get; set; }
    }
}
