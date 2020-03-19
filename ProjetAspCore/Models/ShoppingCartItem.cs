using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAspCore.Models
{
    public class ShoppingCartItem
    {
        // identifient
        [Key]
        public int ShoppingCartItemId { get; set; }
        //Quel livre
        public Book Book { get; set; }
        //Nombre d'exemplaire
        public int Amount { get; set; }
        //création de session pour un utilisateur
        public string ShoppingCartSessionId { get; set; }
    }
}
