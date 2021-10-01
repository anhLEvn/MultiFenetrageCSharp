using Multifenetrage.Views;
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

namespace Multifenetrage
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //
        public MainWindow()
        {
            InitializeComponent();
            PageParDefaut();
        }

        private void PageParDefaut()
        {
            frmPages.Navigate(new PageDefault());
        }

        private void AffichePageSaisieAdh_Click(object sender, RoutedEventArgs e)
        {
            frmPages.Navigate(new PageSaisieAdherent());
        }

        private void AffichePAgeModifAdh_Click(object sender, RoutedEventArgs e)
        {
            frmPages.Navigate(new PageModifAdherent());
        }

        private void AfficherPAgeRecherche_Click(object sender, RoutedEventArgs e)
        {

            frmPages.Navigate(new PageRechercheAdherent());

        }

        private void RetourPageDefault_Clicfk(object sender, MouseButtonEventArgs e)
        {
            PageParDefaut();
        }
    }
}
