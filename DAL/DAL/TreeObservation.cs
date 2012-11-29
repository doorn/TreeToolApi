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
    
    public partial class TreeObservation
    {
        public TreeObservation()
        {
            this.Inventory = new HashSet<Inventory>();
        }
    
        public int TreeObservationID { get; set; }
        public Nullable<double> Perimeter { get; set; }
        public Nullable<double> Height { get; set; }
        public string TreeObservationComment { get; set; }
        public string VitalityComment { get; set; }
        public string DamageClassComment { get; set; }
        public string FungusComment { get; set; }
        public string DiseasesComment { get; set; }
        public string SafetyComment { get; set; }
        public string ActionNeedsComment { get; set; }
        public string ActionNeedsTimeComment { get; set; }
        public Nullable<double> CoordX { get; set; }
        public Nullable<double> CoordY { get; set; }
        public Nullable<int> VitalityID { get; set; }
        public Nullable<int> DiseasesID { get; set; }
        public Nullable<int> DamageClassID { get; set; }
        public Nullable<int> SafetyID { get; set; }
        public Nullable<int> ActionNeedsTimeID { get; set; }
        public Nullable<int> ActionNeedsID { get; set; }
        public Nullable<int> FungusID { get; set; }
        public Nullable<int> TreeSpeciesID { get; set; }
    
        public virtual ActionNeedsTimeType ActionNeedsTimeType { get; set; }
        public virtual ActionNeedsType ActionNeedsType { get; set; }
        public virtual DamageClassType DamageClassType { get; set; }
        public virtual DiseasesType DiseasesType { get; set; }
        public virtual FungusType FungusType { get; set; }
        public virtual SafetyType SafetyType { get; set; }
        public virtual TreeSpecies TreeSpecies { get; set; }
        public virtual VitalityType VitalityType { get; set; }
        public virtual ICollection<Inventory> Inventory { get; set; }
    }
}