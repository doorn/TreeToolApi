using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using Models;
using System.Net;
namespace Api.Services
{
    public class InventoryService
    {
        internal IEnumerable<TreeInventoryModel> GetTreeInventoryByEstateName(int name)
        {
            IDBManager manager = new DBManager();
            return manager.GetTreeInventoryByEstateName(name);
        }
        public HttpStatusCode SaveInventory(TreeInventoryModel inventory)
        {
            IDBManager manager = new DBManager();
            return manager.SaveInventory(inventory);
        }
    }
}