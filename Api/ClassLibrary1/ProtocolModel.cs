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

        [DataMember (Name="vitalityType")]
        public IEnumerable<ObservationType> VitalityType { get; set; }

        [DataMember(Name = "fungusType")]
        public IEnumerable<ObservationType> FungusType { get; set; }

        [DataMember(Name = "diseasesType")]
        public IEnumerable<ObservationType> DiseasesType { get; set; }

        [DataMember(Name = "damageClassType")]
        public IEnumerable<ObservationType> DamageClassType { get; set; }

        [DataMember(Name = "safetyType")]
        public IEnumerable<ObservationType> SafetyType { get; set; }

        [DataMember(Name = "actionNeedsTimeType")]
        public IEnumerable<ObservationType> ActionNeedsTimeType { get; set; }

        [DataMember(Name = "actionNeedsType")]
        public IEnumerable<ObservationType> ActionNeedsType { get; set; }
    }
    
    
}
