using Modele.GestionCollege.Entities;
using MonApplicationWPF_GestionCollege.VueModele.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApplicationWPF_GestionCollege.VueModele
{
    public class ListEleveVueModele : BaseViewModel
    {


        private ObservableCollection<DetailEleveVueModele> _eleves;
        private DetailEleveVueModele _selectEleve;
        private MaBusinessLayer.BusinessManager _bm;

        public ListEleveVueModele()
        {
            _bm = MaBusinessLayer.BusinessManager.GetInstance();

            _eleves = new ObservableCollection<DetailEleveVueModele>();
            //_eleves.Add(new DetailEleveVueModele { Nom="Jahid",  Prenom="AHoui" });
            //_eleves.Add(new DetailEleveVueModele { Nom = "Jahidi", Prenom = "AHnon" });

            foreach(Eleve eleve in _bm.GetEleves()){

                _eleves.Add(new DetailEleveVueModele
                {
                    Nom = eleve.Nom,
                    Prenom = eleve.Prenom,
                    DateDeNaissance = eleve.DateNaissance,
                    Moyenne = _bm.GetMoyenneEleve(eleve.EleveId),
                    NombreAbsence = _bm.GetNombreAbscenceEleve(eleve.EleveId)
                });

                

            }

        }

        public ObservableCollection<DetailEleveVueModele> Eleves
        {
            get { return _eleves; }
            set { _eleves = value; OnPropertyChanged("Eleves"); }
        }

        public DetailEleveVueModele SelectedEleve
        {
            get { return _selectEleve; }
            set { _selectEleve = value; OnPropertyChanged("SelectedEleve"); }
        }

    }
}
