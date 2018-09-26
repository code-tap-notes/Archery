using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Archery.Models
{
	public class Archer : User
	{   [Display(Name="Numéro de License", Prompt ="Numéro")]
		public string LicenseNumber{get; set;}
	}
}