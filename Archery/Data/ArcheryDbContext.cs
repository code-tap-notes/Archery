using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Archery.Models;
using System.Diagnostics;

namespace Archery.Data
{
	public class ArcheryDbContext : DbContext
	{
		public ArcheryDbContext() : base("Archery")  //Nom Data Base declarer dans connectionstring
		{
            this.Database.Log=s => Debug.Write(s);  //affichage debug
		}

		public DbSet<Administrator> Administrators {get; set;} 
		public DbSet<Archer> Archers {get; set;}        
        public DbSet<Tournament> Tournaments { get; set; }        
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Shooter> Shooters { get; set; }
        public DbSet<TournamentPicture> TournamentPictures { get; set; }
    }
}