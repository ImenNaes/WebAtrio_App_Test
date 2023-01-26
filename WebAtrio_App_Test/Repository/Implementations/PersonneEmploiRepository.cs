using System;
using WebAtrio_App_Test.EF;
using WebAtrio_App_Test.Entities;
using WebAtrio_App_Test.Repository.Interfaces;

namespace WebAtrio_App_Test.Repository.Implementations
{
    public class PersonneEmploiRepository : IPersonneEmploiRepository
    {
        private readonly MyDbContext _dbContext;
        public PersonneEmploiRepository(MyDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public void AjoutemploiPersonne(PersonneEmploi model)
        {
            _dbContext.PersonneEmplois.Add(model);
            _dbContext.SaveChanges();
        }
        public IEnumerable<PersonneEmploi> Getlist()
        {
            return _dbContext.PersonneEmplois.ToList();
        }
    }
}
