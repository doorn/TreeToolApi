using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [DataContract]
    public class EstateModel
    {
        [DataMember(Name = "name")]
        public int Name { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "x")]
        public double X { get; set; }

        [DataMember(Name = "y")]
        public double Y { get; set; }
    }
}
