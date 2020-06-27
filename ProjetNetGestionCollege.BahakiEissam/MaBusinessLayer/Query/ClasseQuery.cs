using Modele.GestionCollege;
using Modele.GestionCollege.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBusinessLayer.Query
{
    internal class ClasseQuery
    {

        private MonContexte _monContext;

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="monContexte"></param>
        internal ClasseQuery(MonContexte monContexte)
        {
            _monContext = monContexte;
        }

        /// <summary>
        /// Avoir la liste des Classes ajoutées
        /// </summary>
        /// <returns></returns>
        public List<Classe> GetAll()
        {
            return _monContext.Classes.ToList();
        }

        /// <summary>
        /// Avoir une classe avec l'id donné en paramètre
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Classe GetClasseId(int id)
        {
            return _monContext.Classes.FirstOrDefault(c => c.ClassId == id);
        }

    }
}
