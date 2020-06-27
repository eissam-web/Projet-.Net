using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.GestionCollege.Entities
{
    public class Note
    {
    
        public int NoteId { get; set; }
        public string Matiere { get; set; }
        public DateTime DateNote { get; set; }
        public string Appreciation { get; set; }
        public double NoteObt { get; set; }
        
        public Eleve EleveNote { get; set; }
        public int EleveId { get; set; }


    }

}
