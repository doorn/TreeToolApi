using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class InventoryModel
    {
        public DateTime Date { get; set; }
        public int EstateName { get; set; }
        public int PerformerID { get; set; }
        public IEnumerable<TreeObservation> TreeObservation { get; set; }

    }
}
