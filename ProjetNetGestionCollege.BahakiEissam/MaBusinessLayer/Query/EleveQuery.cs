using Modele.GestionCollege;
using Modele.GestionCollege.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBusinessLayer.Query
{
    internal class EleveQuery
    {

        private MonContexte _monContext;

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="monContexte"></param>
        internal EleveQuery(MonContexte monContexte)
        {
            _monContext = monContexte;
        }

        /// <summary>
        /// Avoir la liste des eleves ajoutées
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Eleve> GetAll()
        {
            return _monContext.Eleves.ToList().OrderBy(e => e.Nom);
        }

        /// <summary>
        /// Avoir un eleve avec l'id donné en paramètre
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Eleve GetEleveId(int id)
        {
            return _monContext.Eleves.FirstOrDefault(c => c.EleveId == id);
        }

        public ICollection<Note> GetNoteEleveId(int id)
        {
            return _monContext.Eleves.First(e => e.EleveId == id).Notes;
        }


        public ICollection<Absence> GetNbAbsId(int id)
        {
            return _monContext.Eleves.First(e => e.EleveId == id).Absences;
        }

    }

}
