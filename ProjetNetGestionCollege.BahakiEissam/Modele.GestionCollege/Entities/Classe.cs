using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.GestionCollege.Entities
{
    public class Classe
    {

        public int ClassId { get; set; }

        public string NomEtablissement { get; set; }

        public string Niveau { get; set; }

        public ICollection<Eleve> Eleves{ get; set; }

    }
}
