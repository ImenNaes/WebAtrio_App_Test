using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAtrio_App_Test.Entities;

namespace WebAtrio_App_Test
{
    public class Personne
    {
        [Key]
        public int Id { get; set; } 
        public string? Nom { get; set; } 
        public string? Prenom { get; set; } 
        public DateTime Date_Naiss { get; set; } 

        public virtual ICollection<PersonneEmploi>? PersonneEmplois { get; set; }
    }
}
