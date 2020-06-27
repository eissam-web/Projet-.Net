using MonApplicationWPF_GestionCollege.VueModele.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApplicationWPF_GestionCollege.VueModele
{
    public class MainWindowViewModel : BaseViewModel
    {

        private ListEleveVueModele _listEleveVueModele;

        #region Constructeur

        public MainWindowViewModel()
        {
            ListEleveVueModele = new ListEleveVueModele();
        }

        #endregion

        #region Properties

        public ListEleveVueModele ListEleveVueModele {
            get { return _listEleveVueModele; }
            set { _listEleveVueModele = value; }
        }

        #endregion

    }
}
