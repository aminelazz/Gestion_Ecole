//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_Ecole
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grp_etudiant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grp_etudiant()
        {
            this.Etudiant = new HashSet<Etudiant>();
            this.Matiere = new HashSet<Matiere>();
        }
    
        public int ID_groupe { get; set; }
        public int ID_filiere { get; set; }
        public int Nbr_etudiant { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Etudiant> Etudiant { get; set; }
        public virtual Filiere Filiere { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matiere> Matiere { get; set; }
    }
}
