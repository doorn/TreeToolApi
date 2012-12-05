using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDBManager
    {
        IEnumerable<EstateModel> GetEstates();
        ProtocolModel GetProtocol();
        InventoryModel GetInventoryByEstateName(int name);
        HttpStatusCode SaveInventory(InventoryModel inventory);
    }
}
