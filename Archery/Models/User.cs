using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Archery.Validator;

namespace Archery.Models
{
	public abstract class User
	{
		public int Id { get; set; }

		[StringLength (10, ErrorMessage = "Fiedl {0} has to have maximum {1 } letter ")]
		[Required (ErrorMessage ="Field {0} is required")]
		[Display(Name = "Address mail")]  //^ est la lettre pour  commencer et $ est finir,  ^\//
		[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
						   @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
						   @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
			, ErrorMessage = "Le format n'est pas bon.")]
		public string Mail { get; set; }

		[Display(Name = "Mot de passe")]
		[DataType(DataType.Password)]       //pour cacher Password sur l'ecran
		[Required(ErrorMessage = "Field {0} is required")]		
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,}$",
				ErrorMessage = "{0} incorrect.")]
		public string Password { get; set; }


		[Display(Name = "Confirmation du mot de passe")]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Confirmation is not right")]
		public string ConfirmedPassword { get; set; }

		[Display(Name = "Prenom")]
		[Required(ErrorMessage = "Le champ {0} est obligatoire.")]
		public string FirstName { get; set; }

		[Display (Name ="Nom")]    //"Name" est un propriete de display
		[Required(ErrorMessage = "Le champ {0} est obligatoire.")]
		public string LastName { get; set; }

		[Display(Name = "Date de naissance")]		
		[DataType(DataType.Date)]       //au niveau Html
		[Required(ErrorMessage = "Le champ {0} est obligatoire.")]
		//[CustomValidation()]
		[Age(9,70,ErrorMessage="Pour le champ {0} vous devez avoir plus de {1} ans")]
		public DateTime BirthDate { get; set; }
 
	}
}
