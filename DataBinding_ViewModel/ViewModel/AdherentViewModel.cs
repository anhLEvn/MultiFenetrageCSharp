using DataBinding_ViewModel.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding_ViewModel.ViewModel
{
    // classe de  liaison avec la base pour l'adhérent
    // toutes les opérations de CRUD 
    // 1- Créer le dossier ViewModel
    // 2- Créer la classe relaie -- eg : AdherentViewModelo
    //3- Déclarer la liste des adherents
    //4 - initialiser la liste dans le constructeur
    //5- Récupérer la classe conteneur d'entités à partir du diagramme EDMX
    //6 - définir le DataContext
    //6- définir un binding sur l'itemSource
    // 7- s'assurer que cet ItemSource se lie à une PROPRIETE get/set
    //

    class AdherentViewModel
    {
        #region propriété
        // public List<Adherent> ListeAdherent = new List<Adherent>(); //attribut (sans get/set)
        //public List<Adherent> ListeAdherent { get; set; } // propriété cad avec un get/set
        public ObservableCollection<Adherent> ListeAdherent { get; set; } // propriété cad avec un get/set

        //Pour qu'une liste puisse notifier Directement alors il faut qu'elle soit une ObservableCollection
        //On veut se lier à un objet de type Adherent, pour celà
        //1-  il suffit qu'il une propriété set/get
        // 2- et l'instancier au niveau du constructeur

        public Adherent AdherentVM { get; set; }
        public Categorie CategorieVM { get; set; }
        public Ville VilleVM     { get; set; }


        public ObservableCollection<Categorie> ListeCategories { get; set; }
        public ObservableCollection<Ville> ListeVilles { get; set; }
        #endregion propriété
        private DBAdherentsEntities db = new DBAdherentsEntities();
        // Au moment de l'instanciation de la classe, on initialise la liste avec les datas de la base
        //ctor + tab + tab

        public AdherentViewModel()
        {
            if (ListeAdherent == null) // On le crée s'il n'existe pas
            {
                ListeAdherent = new ObservableCollection<Adherent>(db.Adherents);

             //   ListeAdherent = db.Adherents.ToList();
            }

            if (ListeCategories == null)
            {
                ListeCategories = new ObservableCollection<Categorie>(db.Categories);
            }
            if (ListeVilles == null)
            {
                ListeVilles = new ObservableCollection<Ville>(db.Villes);
            }
            AdherentVM = new Adherent();
            CategorieVM = new Categorie();
            VilleVM = new Ville();
        }

        public bool AjouterAdherentBase( Adherent a)
        {
            a.Categorie = CategorieVM;
            a.Ville = VilleVM;
            db.Adherents.Add(a);
            //    return    db.SaveChanges() > 0;
            // si l'enregistrement est effectué en base alors il faut mettre à jour la iste
            // La mise à jour de la liste se fait de 2 manières
            //  soit on recupère de nouveau la liste depuis la base == Aller/Retour
            //  on ajoute directement à la liste == sans Aller/R vers la liste
            if (db.SaveChanges() > 0)
            {
                ListeAdherent.Add(a);
                return true;
            }
            return false;
        }
        public bool SupprimerAdherentBaseParId(int id)
        {
           
            var adherentASupprimer = db.Adherents.SingleOrDefault(p=>p.Id == id);  // Where, Single et le SingleorDefautl sont des méthodes
            // db'extention' voir cours LINQ (partie du CSHarp qui permet de faire du requettage)
            db.Adherents.Remove(adherentASupprimer);
            if (db.SaveChanges() > 0)
            {
                ListeAdherent.Remove(adherentASupprimer);
                return true;
               
            }
            return false;
        }


    }
}
