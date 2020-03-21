using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAspCore.Models
{
    public class Order
    {
        [BindNever]
        [Key]
        public int OrderId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        //nom de la personne qui passe commande
        [Required(ErrorMessage ="Entrez votre nom")]
        [Display(Name = "Nom")]
        [StringLength(maximumLength: 50)]
        public string FirstName { get; set; }
        //Le prenom
        [Required(ErrorMessage = "Entrez votre Prénom")]
        [Display(Name = "Prénom")]
        [StringLength(maximumLength: 50)]
        public string LastName { get; set; }
        //Adresse 1
        [Required(ErrorMessage = "Entrez votre adresse")]
        [Display(Name = "Adresse")]
        [StringLength(maximumLength: 250)]
        public string AddressLine1 { get; set; }

        [Display(Name = "Complément d'adresse")]
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Entrez votre code postal")]
        [Display(Name = "code postal")]
        [StringLength(10, MinimumLength =  4)]
        public string ZipCode { get; set; }


        [Required(ErrorMessage = "Entrez votre ville")]
        [Display(Name = "Ville")]
        [StringLength(maximumLength: 50)]
        public string City { get; set; }

        [Display(Name = "Région")]
        public string State { get; set; }

        [Required(ErrorMessage = "Entrez votre pays")]
        [Display(Name = "Pays")]
        [StringLength(maximumLength: 50)]
        public string Country { get; set; }
        [Required(ErrorMessage = "Entrez votre numéro de téléphone")]
        [Display(Name = "Numéro de téléphone")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(25)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Entrez votre Email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(maximumLength: 50)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
    ErrorMessage = "Le format de l'adresse email n'est pas valide")]
        public string Email { get; set; }
        //somme total
        public decimal OrderTotal { get; set; }
        // Date de la commande
        [BindNever]
        public DateTime OrderPlaced { get; set; }
    }
}
