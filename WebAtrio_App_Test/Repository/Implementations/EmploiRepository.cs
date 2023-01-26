using WebAtrio_App_Test.EF;
using WebAtrio_App_Test.Entities;
using WebAtrio_App_Test.Repository.Interfaces;

namespace WebAtrio_App_Test.Repository.Implementations
{
    public class EmploiRepository : IEmploiRepository
    {
        private readonly MyDbContext _dbContext;
        public EmploiRepository(MyDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public IEnumerable<Emploi> GetListemplois()
        {
            var ListEmplois= _dbContext.Emplois.ToList();
            return ListEmplois;
        }
    }
}
