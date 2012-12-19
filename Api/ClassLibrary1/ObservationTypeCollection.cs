using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [DataContract]
    public class ObservationTypeCollection
    {
        [DataMember(Name = "vitalityType")]
        public IEnumerable<ObservationTypeModel> VitalityType { get; set; }

        [DataMember(Name = "fungusType")]
        public IEnumerable<ObservationTypeModel> FungusType { get; set; }

        [DataMember(Name = "diseasesType")]
        public IEnumerable<ObservationTypeModel> DiseasesType { get; set; }

        [DataMember(Name = "damageClassType")]
        public IEnumerable<ObservationTypeModel> DamageClassType { get; set; }

        [DataMember(Name = "safetyType")]
        public IEnumerable<ObservationTypeModel> SafetyType { get; set; }

        [DataMember(Name = "actionNeedsTimeType")]
        public IEnumerable<ObservationTypeModel> ActionNeedsTimeType { get; set; }

        [DataMember(Name = "actionNeedsType")]
        public IEnumerable<ActionNeedsTypeModel> ActionNeedsType { get; set; }

        [DataMember(Name = "ageType")]
        public IEnumerable<AgeTypeModel> AgeType { get; set; }

    }
}
