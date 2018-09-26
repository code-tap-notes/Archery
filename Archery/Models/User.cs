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

		public string Mail { get; set; }

		[DataType(DataType.Password)]       //pour cacher Password sur l'ecran
		public string Password { get; set; }

		public string ConfirmedPassword { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		[DataType(DataType.Date)]		//au niveau Html
		public DateTime BirthDate { get; set; }
    
	}
}