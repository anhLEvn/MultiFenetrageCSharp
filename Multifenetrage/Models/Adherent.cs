//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Multifenetrage.Models
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
        public string Photo { get; set; }
        public Nullable<System.DateTime> DateInscription { get; set; }
        public Nullable<System.DateTime> DateNaissance { get; set; }
    
        public virtual Categorie Categorie { get; set; }
        public virtual Ville Ville { get; set; }
    }
}
