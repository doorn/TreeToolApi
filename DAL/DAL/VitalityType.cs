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
    
    public partial class VitalityType
    {
        public VitalityType()
        {
            this.TreeObservation = new HashSet<TreeObservation>();
        }
    
        public int VitalityID { get; set; }
        public int Value { get; set; }
    
        public virtual ICollection<TreeObservation> TreeObservation { get; set; }
    }
}
