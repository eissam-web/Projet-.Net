using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.GestionCollege.Entities
{
    public class Absence
    {

        public int AbsenceId { get; set; }

        public DateTime DateAbsence { get; set; }
       
        public string Motif { get; set; }

        public Eleve EleveAbs { get; set; }
        public int EleveId { get; set; }

    }
}
