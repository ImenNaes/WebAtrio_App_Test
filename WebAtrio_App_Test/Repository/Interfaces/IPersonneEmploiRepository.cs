using WebAtrio_App_Test.Entities;

namespace WebAtrio_App_Test.Repository.Interfaces
{
    public interface IPersonneEmploiRepository
    {
        void AjoutemploiPersonne(PersonneEmploi personneEmploi);
        IEnumerable<PersonneEmploi> Getlist();
    }
}
