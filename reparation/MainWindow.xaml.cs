using reparation.Metier;
using reparation.UI;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace reparation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            this.listeDesReparation.ItemsSource =  business.reparations;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            APropos nouvelleFenetre = new APropos();
            nouvelleFenetre.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            addReparation nouvelleFenetre = new addReparation();
            nouvelleFenetre.ShowDialog();
        }
    }
}
