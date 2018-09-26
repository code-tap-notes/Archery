using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Archery.Models
{
	public abstract class User
	{
		public int Id { get; set; }

		[StringLength (10, ErrorMessage = "Fiedl {0} has to have maximum {1 } letter ")]
		[Required (ErrorMessage ="Field {0} is required")]
		[Display(Name = "Address mail")]  //^ est la lettre pour  commencer et $ est finir,  ^\//
		[RegularExpression(@"^[a-z0-9_\.-]+\@[\da-z\.-]+\.[a-z\.]{2,6}", ErrorMessage = "format of E-mail is not valid")]		
		public string Mail { get; set; }

		[Display(Name = "Mot de passe")]
		[DataType(DataType.Password)]       //pour cacher Password sur l'ecran
		[Required(ErrorMessage = "Field {0} is required")]
		[RegularExpression(@"^(.{0,7}|[^0-9]*|[^A-Z])$", ErrorMessage = "format of Password is not valid")]
		public string Password { get; set; }


		[Display(Name = "Confirmation du mot de passe")]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Confirmation is not right")]
		public string ConfirmedPassword { get; set; }

		[Display(Name = "Prenom")]
		public string FirstName { get; set; }

		[Display (Name ="Nom")]    //"Name" est un propriete de display
		public string LastName { get; set; }

		[Display(Name = "Date de naissance")]
		[Compare ("DateTime.Now.Day-9*365", ErrorMessage = "format of Password is not valid")]
		[DataType(DataType.Date)]		//au niveau Html
		public DateTime BirthDate { get; set; }
    
	}
}