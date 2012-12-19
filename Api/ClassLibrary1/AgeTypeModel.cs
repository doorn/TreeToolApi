using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace Models
{
    [DataContract]
    public class AgeTypeModel
    {
        [DataMember(Name = "id")]
        public int ID { get; set; }
        [DataMember(Name = "value")]
        public string Value { get; set; }
    }
}
