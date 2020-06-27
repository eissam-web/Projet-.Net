using Modele.GestionCollege;
using Modele.GestionCollege.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBusinessLayer.Query
{
    internal class AbsenceQuery
    {

        private MonContexte _monContext;

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="monContexte"></param>
        internal AbsenceQuery(MonContexte monContexte)
        {
            _monContext = monContexte;
        }

        /// <summary>
        /// Avoir la liste des absence ajoutées
        /// </summary>
        /// <returns></returns>
        public List<Absence> GetAll()
        {
            return _monContext.Absences.ToList();
        }


    }
}
