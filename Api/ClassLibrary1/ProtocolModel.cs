using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [DataContract]
    public class ProtocolModel
    {
        [DataMember(Name = "treeSpecies")]
        public IEnumerable<TreeSpeciesModel> TreeSpecies { get; set; }

        [DataMember(Name = "observationTypes")]
        public ObservationTypeCollection ObservationTypes { get; set; }
    }
    
    
}
