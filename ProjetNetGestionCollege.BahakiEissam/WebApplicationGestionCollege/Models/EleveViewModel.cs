using Modele.GestionCollege.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationGestionCollege.Models
{
    public class EleveViewModel
    {

        public int idEleve { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public List<Note> Notes { get; set; }
        public List<Absence> Absences { get; set; }

    }
}