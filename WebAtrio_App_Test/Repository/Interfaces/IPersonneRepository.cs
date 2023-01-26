using WebAtrio_App_Test.EF;
using WebAtrio_App_Test.Models;

namespace WebAtrio_App_Test.Repository.Interfaces
{
    public interface IPersonneRepository
    {
       void AjoutPersonne(Personne personne);
       IEnumerable<Personne> GetPersonnes();
       int GetAge(DateTime Date_Naissance);
       IEnumerable<Personne> Personnes_Entreprise(string entreprise);
       IEnumerable<PersonneModel> GetListPersonnes();

    }
}
