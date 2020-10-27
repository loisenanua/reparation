using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace reparation
{
    public class reparationPhone
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string ModelPhone { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public DateTime DateRecu { get; set; }
        public string Description { get; set; }
        public string Statut { get; set; }
        public int PrixReparation { get; set; }

        public reparationPhone(string Nom, string Prenom, string ModelPhone, int Mobile, string Email, DateTime DateRecu, string Description, string Statut, int PrixReparation) {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.ModelPhone = ModelPhone;
            this.Mobile = Mobile;
            this.Email = Email;
            this.DateRecu = DateRecu;
            this.Description = Description;
            this.Statut = Statut;
            this.PrixReparation = PrixReparation;
        }

        public string depotPhone()
        {
            String resume = Prenom + " " + Nom + " " + " a déposé un " + ModelPhone + " le : " + DateRecu;

            return resume;
        }
        
    }
}
