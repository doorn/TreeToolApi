//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TreeSpecies
    {
        public TreeSpecies()
        {
            this.TreeObservation = new HashSet<TreeObservation>();
        }
    
        public int TreeSpeciesID { get; set; }
        public string Genus { get; set; }
        public string Species { get; set; }
        public string Sort { get; set; }
        public string ePlant { get; set; }
        public string SwedishName { get; set; }
    
        public virtual ICollection<TreeObservation> TreeObservation { get; set; }
    }
}