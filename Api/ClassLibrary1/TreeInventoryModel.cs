using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [DataContract]
    public class TreeInventoryModel
    {
        [DataMember(Name = "perimeter")]
        public double Perimeter { get; set; }
        [DataMember(Name = "height")]
        public double Height { get; set; }
        [DataMember(Name = "coordX")]
        public double CoordX { get; set; }
        [DataMember(Name = "coordY")]
        public double CoordY { get; set; }

        [DataMember (Name="vitalityID")]
        public int VitalityID { get; set; }
        [DataMember(Name = "diseasesID")]
        public int DiseasesID { get; set; }
        [DataMember(Name = "damageClassID")]
        public int DamageClassID { get; set; }
        [DataMember(Name = "safetyID")]
        public int SafetyID { get; set; }
        [DataMember(Name = "actionNeedsTimeID")]
        public int ActionNeedsTimeID { get; set; }
        [DataMember(Name = "actionNeedsID")]
        public int ActionNeedsID { get; set; }
        [DataMember(Name = "fungusID")]
        public int FungusID { get; set; }
        [DataMember(Name = "ageID")]
        public int AgeID { get; set; }
        [DataMember(Name = "treeSpeciesID")]
        public int TreeSpeciesID { get; set; }
        [DataMember(Name = "treeSpecies")]
        public string TreeSpecies { get; set; }

        [DataMember (Name="treeObservationComment")]
        public string TreeObservationComment { get; set; }
        [DataMember(Name = "vitalityComment")]
        public string VitalityComment { get; set; }
        [DataMember(Name = "damageClassComment")]
        public string DamageClassComment { get; set; }
        [DataMember(Name = "fungusComment")]
        public string FungusComment { get; set; }
        [DataMember(Name = "diseasesComment")]
        public string DiseasesComment { get; set; }
        [DataMember(Name = "safetyComment")]
        public string SafetyComment { get; set; }
        [DataMember(Name = "actionNeedsComment")]
        public string ActionNeedsComment { get; set; }
        [DataMember(Name = "actionNeedsTimeComment")]
        public string ActionNeedsTimeComment { get; set; }
        [DataMember (Name="treeID")]
        public int TreeID { get; set; }

        [DataMember(Name = "performerID")]
        public int PerformerID { get; set; }
    }
}
