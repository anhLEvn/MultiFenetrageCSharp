//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBinding_ViewModel.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Adherent
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public Nullable<int> CategorieId { get; set; }
        public Nullable<int> VilleId { get; set; }
    
        public virtual Categorie Categorie { get; set; }
        public virtual Ville Ville { get; set; }
    }
}
