﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAspCore.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        //nom de la personne qui passe commande
        public string FirstName { get; set; }
        //Le prenom
        public string LastName { get; set; }
        //Adresse 1
        public string AddressLine1 { get; set; }

        public string AdressLine2 { get; set; }

        public string City { get; set; }
        public string State { get; set; }

        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        //somme total
        public decimal OrderTotal { get; set; }
        // Date de la commande
        public DateTime OrderPlaced { get; set; }
    }
}
