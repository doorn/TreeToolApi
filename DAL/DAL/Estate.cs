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
    
    public partial class Estate
    {
        public Estate()
        {
            this.Inventory = new HashSet<Inventory>();
        }
    
        public string Title { get; set; }
        public int Name { get; set; }
        public double CoordiY { get; set; }
        public double CoordiX { get; set; }
        public int EstateID { get; set; }
    
        public virtual ICollection<Inventory> Inventory { get; set; }
    }
}