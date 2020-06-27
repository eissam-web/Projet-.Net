using MaBusinessLayer.Query;
using Modele.GestionCollege;
using Modele.GestionCollege.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBusinessLayer
{


    //Singleton
    public class BusinessManager
    {

        #region Structure/Singleton

        public static BusinessManager _instance;

        //Création d'un context 
        private MonContexte _monContext;

        /// <summary>
        /// Constructeur Privée + Instantation du contexte pour la durée de vie total de l'application
        /// </summary>
        private BusinessManager()
        {

            _monContext = new MonContexte();

        }

        /// <summary>
        /// Obtenir l'instance 
        /// </summary>
        /// <returns> <see cref="BusinessManager"/> . </returns>
        public static BusinessManager GetInstance()
        {

            if(_instance != null)
            {
                return _instance;
            }
            _instance = new BusinessManager();
            return _instance;

        }
        
        #endregion

        public List<Classe> GetClasses(){

            ClasseQuery query = new ClasseQuery(_monContext);
            var result = query.GetAll();

            return result;

        }

        public IEnumerable<Eleve> GetEleves()
        {

            EleveQuery query = new EleveQuery(_monContext);
            var result = query.GetAll();

            return result;

        }

        public double GetMoyenneEleve(int id)
        {

            //EleveQuery query = new EleveQuery(_monContext);
            NoteQuery noteQuery = new NoteQuery(_monContext);
            List<Note> notes = new List<Note>();

            //ICollection<Note> notes = query.GetNoteEleveId(id); 

            //var result = notes.Select(n => n.NoteObt).Average();

            foreach (Note n in noteQuery.GetAll())
            {
                if( n.EleveId == id)
                {
                    notes.Add(n);
                }
            }

            var result = notes.Select(n => n.NoteObt).Average();

            return result;

        }

        public int GetNombreAbscenceEleve(int id)
        {

            //EleveQuery query = new EleveQuery(_monContext);
            //ICollection<Absence> absences = query.GetNbAbsId(id);

            AbsenceQuery absenceQuery = new AbsenceQuery(_monContext);
            List<Absence> absences = new List<Absence>();

            foreach (Absence a in absenceQuery.GetAll())
            {
                if (a.EleveId == id)
                {
                    absences.Add(a);
                }
            }

            var result = absences.Count();

            return result;

        }

        public List<Note> GetNotesEleve(int id)
        {

            NoteQuery noteQuery = new NoteQuery(_monContext);
            List<Note> notes = new List<Note>();

            foreach (Note n in noteQuery.GetAll())
            {
                if (n.EleveId == id)
                {
                    notes.Add(n);
                }
            }


            return notes;
        }

        public List<Absence> GetAbscencesEleve(int id)
        {
            AbsenceQuery absenceQuery = new AbsenceQuery(_monContext);
            List<Absence> absences = new List<Absence>();

            foreach (Absence a in absenceQuery.GetAll())
            {
                if (a.EleveId == id)
                {
                    absences.Add(a);
                }
            }


            return absences;
        }

        public List<Eleve> GetElevesClasse(int id)
        {
            EleveQuery query = new EleveQuery(_monContext);
            List<Eleve> eleves = new List<Eleve>();

            foreach (Eleve e in query.GetAll())
            {
                if (e.ClasseId == id)
                {
                    eleves.Add(e);
                }
            }


            return eleves;
        }

    }
}
