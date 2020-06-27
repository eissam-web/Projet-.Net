using MaBusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modele.GestionCollege;
using Modele.GestionCollege.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ProjetGestionDesDonnees.TestsUnitaire
{
    [TestClass]
    public class MonTestUnitaire
    {
        [TestMethod]
        public void TestAddClasse()
        {

            //ARRANGE
            //Classe newClasse = new Classe { Niveau = "3eme", NomEtablissement = "Victor Hugo"};
            //Eleve eleve = new Eleve { Nom = "Tata", Prenom = "Eissam", ClasseId = 1, DateNaissance = DateTime.Today };
            //Note note1 = new Note { NoteObt = 13, Appreciation = "acceptable", DateNote = DateTime.Now, Matiere="SVT",EleveId=1 };
            //Note note2 = new Note { NoteObt = 9, Appreciation = "pietre", DateNote = DateTime.Now, Matiere = "Maths", EleveId = 1 };
            //Note note3 = new Note { NoteObt = 2, Appreciation = "troll", DateNote = DateTime.Now, Matiere = "Français", EleveId = 1 };
            //Note note4 = new Note { NoteObt = 5, Appreciation = "desolant", DateNote = DateTime.Now, Matiere = "Anglais", EleveId = 1 };
            //Note note5 = new Note { NoteObt = 18, Appreciation = "optimal", DateNote = DateTime.Now, Matiere = "Physique", EleveId = 1 };
            //Absence abs1 = new Absence { DateAbsence = DateTime.Now, Motif = "Abs", EleveId = 1 };
            //Absence abs2 = new Absence { DateAbsence = DateTime.Now, Motif = "Abs", EleveId = 1 };
            //Absence abs3 = new Absence { DateAbsence = DateTime.Now, Motif = "Abs", EleveId = 2 };
            //Absence abs4 = new Absence { DateAbsence = DateTime.Now, Motif = "Abs", EleveId = 3 };
            //Absence abs5 = new Absence { DateAbsence = DateTime.Now, Motif = "Abs", EleveId = 5 };
            //Absence abs6 = new Absence { DateAbsence = DateTime.Now, Motif = "Abs", EleveId = 5 };

            //ACT
            MonContexte monContexte = new MonContexte();
            //monContexte.Eleves.Add(eleve);//Ajout dans le context
            //monContexte.Notes.Add(note1);
            //monContexte.Notes.Add(note2);
            //monContexte.Notes.Add(note3);
            //monContexte.Notes.Add(note4);
            //monContexte.Notes.Add(note5);
            //monContexte.Absences.Add(abs1);
            //monContexte.Absences.Add(abs2);
            //monContexte.Absences.Add(abs3);
            //monContexte.Absences.Add(abs4);
            //monContexte.Absences.Add(abs5);
            //monContexte.Absences.Add(abs6);

            //monContexte.Eleves.FirstOrDefault().Notes.Add(new Note());
            
            monContexte.SaveChanges();//Ajout dans la bdd

            //ASSERT
            //Classe uneClasse =  monContexte.Classes.FirstOrDefault(c => c.Niveau.Equals("3eme"));
            Eleve unEleve = monContexte.Eleves.FirstOrDefault(c => c.EleveId == 1);
            //Assert.IsTrue(uneClasse.NomEtablissement == newClasse.NomEtablissement);
            Assert.IsTrue(unEleve.Notes.Count() == 5);

        }

        [TestMethod]
        public void TestRetourClasses()
        {

            //ARRANGE
            BusinessManager bm = BusinessManager.GetInstance();


            //ACT
            //List<Classe> classes = bm.GetClasses();
            IEnumerable<Eleve> eleves = bm.GetEleves();

            //ASSERT
            //Assert.IsTrue(classes.Count == bm.GetClasses().Count());
            Assert.IsTrue(eleves.Count().Equals( bm.GetEleves().Count()));

        }

    }
}
