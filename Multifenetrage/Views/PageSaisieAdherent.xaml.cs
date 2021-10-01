using Microsoft.Win32;
using Multifenetrage.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Multifenetrage.Views
{
    /// <summary>
    /// Logique d'interaction pour PageSaisieAdherent.xaml
    /// </summary>
    public partial class PageSaisieAdherent : Page
    {
        private AdherentViewModel adherentViewModel = new AdherentViewModel();
        public PageSaisieAdherent()
        {
            InitializeComponent();
         //   ParametrageSaisie();
            DataContext = adherentViewModel;

        }

        //private void ParametrageSaisie()
        //{
        //    string cheminImage = ConfigurationManager.AppSettings["imgDefaut"] ;
        //    imgDef.Source = new BitmapImage(new Uri(cheminImage));

        //}

        private void ImporterImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

           if (ofd.ShowDialog() == true)
            {
                string fichierSelectionne = ofd.FileName;

                imgDef.Source = new BitmapImage(new Uri(fichierSelectionne));

            }
        }

        private void EnregistrerBase_Click(object sender, RoutedEventArgs e)
        {

            adherentViewModel.AjouterEnbase();
        }
    }
}
