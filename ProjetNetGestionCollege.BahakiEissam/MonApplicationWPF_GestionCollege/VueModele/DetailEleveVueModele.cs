using MonApplicationWPF_GestionCollege.VueModele.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApplicationWPF_GestionCollege.VueModele
{
    public class DetailEleveVueModele : BaseViewModel
    {

        public String Nom { get; set; }
        public String Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public Double Moyenne { get; set; }
        public int NombreAbsence { get; set; }




    }
}
