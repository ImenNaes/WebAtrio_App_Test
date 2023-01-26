using WebAtrio_App_Test.Entities;

namespace WebAtrio_App_Test.Repository.Interfaces
{
    public interface IEmploiRepository
    {
        IEnumerable<Emploi> GetListemplois();
    }
}
