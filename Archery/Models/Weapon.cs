using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Archery.Models
{
    
        public class Weapon : BaseModel
        {
            [Required]
            [Display(Name = "Nom de l'arme")]
            public string Name { get; set; }

            [Display(Name = "Tournois")]
            public ICollection<Tournament> Tournaments { get; set; }
        }
    
}