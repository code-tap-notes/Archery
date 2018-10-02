using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Archery.Models
{
	public class Archer : User
    {
        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        [StringLength(15)]
        [Display(Name="Numéro de License", Prompt ="Numéro")]
        //[RegularExpression(@"^(?:\+33\s|0)[1-9](?:\s\d{2}){4}$", ErrorMessage = "Le numéro commencer par 0,et 10 chiffres")]
        public string LicenseNumber{get; set;}
	}
}
