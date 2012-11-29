using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDBManager
    {
        IEnumerable<EstateModel> GetEstates();
        ProtocolModel GetProtocol();
        void GetInventoryByEstateNameID(int name);
        
        void SaveInventory(string ngtvarde);
    }
}
