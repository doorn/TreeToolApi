using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [DataContract]
    public class ObservationTypeModel
    {
        [DataMember (Name="id")]
        public int ID { get; set; }
        [DataMember (Name="value")]
        public int Value { get; set; }
    }
}
