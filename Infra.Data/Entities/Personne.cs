using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Entities
{
    public class Personne
    {
        [Key]
        public int Id { get; set; } 
        public string? Nom { get; set; } 
        public string? Prenom { get; set; } 
        public DateOnly Date_Naiss { get; set; } 
    }
}
