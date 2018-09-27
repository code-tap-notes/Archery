using Archery.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Archery.Models
{
	public abstract class User
	{
		public int ID { get; set; }

		[Required(ErrorMessage = "Le champ {0} est obligatoire.")]
		[StringLength(150, ErrorMessage = "Le champ {0} doit contenir {1} caractères max.")]
		[Display(Name = "Adresse mail")]
		[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
						   @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
						   @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
			, ErrorMessage = "Le format n'est pas bon.")]
		public string Mail { get; set; }

		[StringLength(150)]
		[Display(Name = "Mot de passe")]
		[DataType(DataType.Password)]
		[Required(ErrorMessage = "Le champ {0} est obligatoire.")]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,}$",
			ErrorMessage = "{0} incorrect.")]
		
		public string Password { get; set; }

		[NotMapped]
		[StringLength(150)]
		[Display(Name = "Confirmation du mot de passe")]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "La confirmation n'est pas bonne.")]
		public string ConfirmedPassword { get; set; }

		[StringLength(50)]
		[Display(Name = "Nom")]
		[Required(ErrorMessage = "Le champ {0} est obligatoire.")]
		public string LastName { get; set; }

		[StringLength(50)]
		[Display(Name = "Prénom")]
		[Required(ErrorMessage = "Le champ {0} est obligatoire.")]
		public string FirstName { get; set; }

		[Column(TypeName="datetime2")]
		[Display(Name = "Date de naissance")]
		[Required(ErrorMessage = "Le champ {0} est obligatoire.")]
		[DataType(DataType.Date)]
		[Age(9, MaximumAge = 90, ErrorMessage = "Pour le champ {0}, vous devez avoir plus de {1} ans et moins de {2} ans")]
		public DateTime BirthDate { get; set; }

	}
}