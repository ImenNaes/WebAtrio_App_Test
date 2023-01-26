using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAtrio_App_Test.Entities
{
    public class PersonneEmploi
    {
        [Column(Order =1)]
        public int PersonneId { get; set; }
        [Column(Order = 2)]
        public int EmploiId { get; set; }
        public DateTime Date_Debut { get; set; }
        public DateTime Date_Fin { get; set; }
        public virtual Personne? Personne { get; set; }
        public virtual Emploi? Emploi { get; set; }      
    }
}
