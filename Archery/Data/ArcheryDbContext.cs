using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Archery.Models;

namespace Archery.Data
{
	public class ArcheryDbContext : DbContext
	{
		public ArcheryDbContext() : base("Archery")  //Nom Data Base declarer dans connectionstring
		{
		}

		public DbSet<Administrator> Administrators {get; set;} 
		public DbSet<Archer> Archers {get; set;} 
	}
}