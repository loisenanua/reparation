using reparation.Metier;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace reparation.UI
{
    /// <summary>
    /// Interaction logic for addReparation.xaml
    /// </summary>
    public partial class addReparation : Window
    {
        
        public addReparation()
        {
            InitializeComponent();
            
        }
       
        private void recupDonnees()
        
        {
            
            string nom = this.nom.Text;
            string prenom = this.prenom.Text;
            string model = this.model.Text;
            int telephone;
            int.TryParse(this.telephone.Text, out telephone);
            string email = this.email.Text;

            var cultureInfo = new CultureInfo("fr-FR");
            string dateString = "12/06/2008";
            DateTime depot = DateTime.Parse(dateString, cultureInfo);

            string description = this.description.Text;
            int prix = int.Parse(this.prix.Text);

            // creer l'objet xxx avec le type qui est la classe reparationPhone
            reparationPhone xxx = new reparationPhone(nom, prenom, model, telephone, email, depot, description, "", prix);
            // il va stocker toutes les réparations de l'applications
            business.reparations.Add(xxx);
        }

        private void enregistrer_Click(object sender, RoutedEventArgs e)
        {
            recupDonnees();
            this.Close();
        }

        private void depot_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
