using System.Reflection.Metadata.Ecma335;
using WebAtrio_App_Test.EF;
using WebAtrio_App_Test.Models;
using WebAtrio_App_Test.Repository.Interfaces;

namespace WebAtrio_App_Test.Repository.Implementations
{
    public class PersonneRepository: IPersonneRepository
    {
        private readonly MyDbContext _dbContext;
        public PersonneRepository(MyDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public void AjoutPersonne(Personne model)
        {
            _dbContext.Personnees.Add(model);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Personne> GetPersonnes()
        {
            return _dbContext.Personnees.ToList();
        }

        public int GetAge(DateTime Date_Naissance)
        {
            int age = DateTime.Now.Year - Date_Naissance.Year;
            DateTime DateAnniv = new DateTime(DateTime.Now.Year, Date_Naissance.Month, Date_Naissance.Day);
            if (DateAnniv > DateTime.Now)
                age--;
            return age;
        }

        public IEnumerable<Personne> Personnes_Entreprise(string entreprise)
        {
            var EmploiId = _dbContext.Emplois.First(c => c.Nom_Entreprise == entreprise).Id;
            var list_personnes = _dbContext.PersonneEmplois
                 .Where(c => c.EmploiId == EmploiId)
                 .Select(c => c.Personne)
                 .ToList();
            return list_personnes;
        }

        public IEnumerable<PersonneModel> GetListPersonnes()
        {
            var list_personnes =(from personne in _dbContext.Personnees
                                 join peroEmploi in _dbContext.PersonneEmplois
                                 on personne.Id equals peroEmploi.PersonneId 
                                 join emploi in _dbContext.Emplois
                                 on peroEmploi.EmploiId equals emploi.Id
                                 select new PersonneModel
                                 {
                                     Nom = personne.Nom,
                                     Prenom = personne.Prenom,
                                     Age = DateTime.Now.Year - personne.Date_Naiss.Year,           
                                     EmploiActuel = emploi.Poste
                                 }).OrderBy(c=>c.Nom).ToList();
            return list_personnes;
        }
    }
}
