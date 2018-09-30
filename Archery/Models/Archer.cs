using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Archery.Models
{
	public class Archer : User
	{   [Display(Name="Numéro de License", Prompt ="Numéro")]
        [RegularExpression(@"^([0]{1}"+ @"([0-9]{6})" + @"([A-Z]{1})", ErrorMessage = "Le numéro de licence doit commencer par 0 et  6 chiffres et terminer par une lettre majuscule")]
        public string LicenseNumber{get; set;}
	}
}