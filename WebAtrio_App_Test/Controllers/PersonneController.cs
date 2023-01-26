using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using WebAtrio_App_Test.Models;
using WebAtrio_App_Test.Repository.Interfaces;

namespace WebAtrio_App_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonneController : ControllerBase
    {
        private readonly IPersonneRepository _personne_repo;
        public PersonneController(IPersonneRepository personne_repo)
        {
            _personne_repo= personne_repo;    
        }
        [HttpGet]
        public IEnumerable<Personne> Index()
        {
            var List_personnes = _personne_repo.GetPersonnes();
            return List_personnes;
        }

        [HttpPost]
        public void Ajout(Personne personne)
        {
            //var personne = new Personne
            //{
            //    Nom = "monmon",
            //    Prenom = "monmon",
            //    Date_Naiss = new DateTime()   
            //};
            if(_personne_repo.GetAge(personne.Date_Naiss) <150)
              _personne_repo.AjoutPersonne(personne);
            else
              Console.WriteLine("Error!");
        }

        public IEnumerable<Personne> PersonnesParEnreprise(string entreprise) 
        {
            var listPerso = _personne_repo.Personnes_Entreprise(entreprise);
            return listPerso;
        }

        public IEnumerable<PersonneModel> GetListPersonnes()
        {
            var listPerso = _personne_repo.GetListPersonnes();
            return listPerso;
        }

    }
}
