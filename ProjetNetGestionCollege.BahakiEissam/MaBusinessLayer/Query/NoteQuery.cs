using Modele.GestionCollege;
using Modele.GestionCollege.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBusinessLayer.Query
{
    internal class NoteQuery
    {

        private MonContexte _monContext;

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="monContexte"></param>
        internal NoteQuery(MonContexte monContexte)
        {
            _monContext = monContexte;
        }

        /// <summary>
        /// Avoir la liste des absence ajoutées
        /// </summary>
        /// <returns></returns>
        public List<Note> GetAll()
        {
            return _monContext.Notes.ToList();
        }

    }
}
