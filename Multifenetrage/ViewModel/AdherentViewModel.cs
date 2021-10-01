using Multifenetrage.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multifenetrage.ViewModel
{
  public  class AdherentViewModel
    {
        // le DataContext de la page saisie

        private DBAdherentsEntities db = new DBAdherentsEntities();

        #region Property
        //1
        public Adherent AdherentVM { get; set; }
        public Categorie CategorieVM { get; set; }
        public ObservableCollection<Categorie> Categories { get; set; }
        #endregion Property

        //2: instancier dans le constructeur

        public AdherentViewModel()
        {
            if (AdherentVM == null)
            {
                AdherentVM = new Adherent();
                AdherentVM.Photo = ConfigurationManager.AppSettings["imgDefaut"];
            }

            if (Categories == null)
                Categories = new ObservableCollection<Categorie>(db.Categories); // ne pas oublier de cocher mettre Pluriuel/Singulier
            CategorieVM = new Categorie();


        }

        public  void AjouterEnbase()
        {
            // récupérer la catégorie selectionnée
            AdherentVM.Categorie = CategorieVM;
            db.Adherents.Add(AdherentVM);
            db.SaveChanges();

        }
    }
}
