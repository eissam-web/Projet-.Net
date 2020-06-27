using Modele.GestionCollege.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationGestionCollege.Models;

namespace WebApplicationGestionCollege.Controllers
{
    public class HomeController : Controller
    {

        private MaBusinessLayer.BusinessManager _bm;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListeEleves()
        {

            _bm = MaBusinessLayer.BusinessManager.GetInstance();
            IEnumerable<Eleve> eleves = _bm.GetEleves();
            List<EleveViewModel> elevesViewModel = new List<EleveViewModel>();

            foreach (var eleve in eleves)
            {
                elevesViewModel.Add(new EleveViewModel { idEleve=eleve.EleveId, Nom = $"{eleve.Nom}", Prenom = $"{eleve.Prenom}", Absences = _bm.GetAbscencesEleve(eleve.EleveId), Notes = _bm.GetNotesEleve(eleve.EleveId) });
            }

            return View(elevesViewModel);
        }

        public ActionResult DetailEleve(int id)
        {
            _bm = MaBusinessLayer.BusinessManager.GetInstance();
            IEnumerable<Eleve> eleves = _bm.GetEleves();
            List<EleveViewModel> elevesViewModel = new List<EleveViewModel>();

            foreach (var eleve in eleves)
            {
                elevesViewModel.Add(new EleveViewModel { idEleve = eleve.EleveId, Nom = $"{eleve.Nom}", Prenom = $"{eleve.Prenom}", Absences = _bm.GetAbscencesEleve(eleve.EleveId), Notes = _bm.GetNotesEleve(eleve.EleveId) });
            }

            EleveViewModel eleveSelect = elevesViewModel.FirstOrDefault(e => e.idEleve == id);
            return View(eleveSelect);
        }

        public ActionResult ListeClasses()
        {

            _bm = MaBusinessLayer.BusinessManager.GetInstance();
            IEnumerable<Classe> classes = _bm.GetClasses();
            List<ClasseViewModel> classesViewModel = new List<ClasseViewModel>();

            foreach (var classe in classes)
            {
                classesViewModel.Add(new ClasseViewModel { ClasseId = classe.ClassId, NomEtablissement = $"{classe.NomEtablissement}", Niveau = $"{classe.Niveau}", Eleves = _bm.GetElevesClasse(classe.ClassId) });
            }

            return View(classesViewModel);
        }

        public ActionResult DetailClasse(int id)
        {
            _bm = MaBusinessLayer.BusinessManager.GetInstance();
            IEnumerable<Classe> classes = _bm.GetClasses();
            List<ClasseViewModel> classesViewModel = new List<ClasseViewModel>();

            foreach (var classe in classes)
            {
                classesViewModel.Add(new ClasseViewModel { ClasseId = classe.ClassId, NomEtablissement = $"{classe.NomEtablissement}", Niveau = $"{classe.Niveau}", Eleves = _bm.GetElevesClasse(classe.ClassId) });
            }

            ClasseViewModel classeSelect = classesViewModel.FirstOrDefault(a => a.ClasseId == id);
            return View(classeSelect);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}