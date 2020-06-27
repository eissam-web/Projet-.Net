using Modele.GestionCollege;
using Modele.GestionCollege.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModele.ProjetGestionCollege
{
    class Program
    {
        static void Main(string[] args)
        {
            try {

                MonContexte monContexte = new MonContexte();
                monContexte.Eleves.ToList();

            }
            catch(Exception ex){
                throw;
            }



        }
    }
}
