using DataBinding_ViewModel.Model;
using DataBinding_ViewModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace DataBinding_ViewModel
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AdherentViewModel adherentViewModel = new AdherentViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = adherentViewModel;
        }

        private void EnregisterAdherent_CLick(object sender, RoutedEventArgs e)
        {
            // Recupérer la catégorie selectionnée

            // Approche sans utilisation du binding
            //    Categorie categorieSelectionne = cbbCategorie.SelectedItem as Categorie;

            // Utiliser une CategorieVM qui servira à la liaison de données
            //    Debug.WriteLine(categorieSelectionne.Libelle);

            // lier la catégorie à l'adherent
            //adherentViewModel.AdherentVM.Categorie = categorieSelectionne; 

            // adherentViewModel.AdherentVM.CategorieId = categorieSelectionne.CategorieId; // plus ancienne
         //   adherentViewModel.AdherentVM.Categorie = adherentViewModel.CategorieVM;
            adherentViewModel.AjouterAdherentBase(adherentViewModel.AdherentVM)


            //bool ok =   adherentViewModel.AjouterAdherentBase(adherentViewModel.AdherentVM);
            //    string msg = (ok ) ? "Enregistré avec succes " : "Echec d'enregistrement";
           // string msg = (adherentViewModel.AjouterAdherentBase(adherentViewModel.AdherentVM)) ? "Enregistré avec succes " : "Echec d'enregistrement";

           // MessageBox.Show(msg);
          ;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // MessageBox.Show("Un element est selectionné");

            // quel est l'id de l'adhérent selectionné ?

            //  Adherent adherentSelectionne =  (Adherent) lsvAdherents.SelectedItem; //générer une exception si le cast n'est pas possible 
            if (lsvAdherents.SelectedValue != null)
            {
                Adherent adherentSelectionne = lsvAdherents.SelectedItem as Adherent; // pas d'exception

                //   MessageBox.Show(adherentSelectionne.Id.ToString());

                adherentViewModel.SupprimerAdherentBaseParId(adherentSelectionne.Id);
                //lsvAdherents.Items.Remove()
            }
        }

        private void TestAjout_CLick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ajouter");
        }

        private void TestSupp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("supprimer");

        }

        private void TestRechercher_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Rechercher");

        }

        private void TestApropos_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("a propos");

        }

        private void Option1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Option 1 enregistrement ....");

        }

        private void Option2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Option 2 enregistrement ....");

        }
    }
}
