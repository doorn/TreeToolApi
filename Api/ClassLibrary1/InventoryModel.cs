using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Runtime.Serialization;
namespace Models
{
    [DataContract]
    public class InventoryModel
    {
        [DataMember(Name = "date")]
        public string Date { get; set; }
        [DataMember(Name = "estateName")]
        public int EstateName { get; set; }
        
        [DataMember(Name = "treeObservations")]
        public IEnumerable<TreeInventoryModel> TreeObservations { get; set; }

    }
}
