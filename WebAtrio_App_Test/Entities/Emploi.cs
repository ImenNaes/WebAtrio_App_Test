using System.ComponentModel.DataAnnotations;

namespace WebAtrio_App_Test.Entities
{
    public class Emploi
    {
        [Key]
        public int Id { get; set; }
        public string? Nom_Entreprise { get; set; }
        public string? Poste { get; set; }
        public virtual ICollection<PersonneEmploi>? PersonneEmplois { get; set; }

    }
}
