using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.GestionCollege.Entities
{
    public class Eleve
    {

        public int EleveId { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateNaissance { get; set; }

        public ICollection<Note> Notes { get; set; }
        public ICollection<Absence> Absences { get; set; }

        public Classe ClasseEleve { get; set; }
        public int ClasseId { get; set; }

    }
}
