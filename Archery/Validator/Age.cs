using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Archery.Validator
{
	public class Age: ValidationAttribute

	{
		public int MinimumAge { get; private set; }
		public int MaximumAge { get; private set; }

		public Age(int minimumAge,int maximumAge)
		{
			this.MinimumAge = minimumAge;
			this.MaximumAge = maximumAge;

		}

	
		public override bool IsValid(object value)
		{
			if (value is DateTime)
			{
				return (DateTime.Now.AddYears(-this.MinimumAge) >= (DateTime)value) | (DateTime.Now.AddYears(-this.MaximumAge) <= (DateTime)value);
			}
			else
				throw  new ArgumentException ("Le type doit etre un DateTime");
		}
		public override string FormatErrorMessage(string name)
		{
			return string.Format(this.ErrorMessage,name,this.MinimumAge.ToString());
		}


	}
}
