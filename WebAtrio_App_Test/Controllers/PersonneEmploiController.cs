using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAtrio_App_Test.Entities;
using WebAtrio_App_Test.Repository.Interfaces;

namespace WebAtrio_App_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonneEmploiController : ControllerBase
    {
        private readonly IPersonneRepository _personne_repo;
        private readonly IEmploiRepository _emploi_repo;
        private readonly IPersonneEmploiRepository _personneEmploi_repo;
 
        public PersonneEmploiController(IPersonneRepository personne_repo,
                                        IEmploiRepository emlpoi_repo,
                                        IPersonneEmploiRepository personneEmploi_repo)
        {
            _personne_repo = personne_repo;
            _emploi_repo= emlpoi_repo;  
            _personneEmploi_repo= personneEmploi_repo;  
        }

        [HttpGet]
        public IEnumerable<PersonneEmploi> Index()
        {
            var list = _personneEmploi_repo.Getlist();
            return list;
        }

        [HttpPost]
        public void AjoutPersonneEmploi(PersonneEmploi emploiAuPersonne)
        {          
            _personneEmploi_repo.AjoutemploiPersonne(emploiAuPersonne);   
        }


    }
}
