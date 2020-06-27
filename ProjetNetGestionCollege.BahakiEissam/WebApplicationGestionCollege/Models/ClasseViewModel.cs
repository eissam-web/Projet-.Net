using Modele.GestionCollege.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationGestionCollege.Models
{
    public class ClasseViewModel
    {

        public int ClasseId { get; set; }
        public string NomEtablissement { get; set; }

        public string Niveau { get; set; }

        public IEnumerable<Eleve> Eleves { get; set; }

    }
}