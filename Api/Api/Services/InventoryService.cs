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
        public InventoryModel GetInventoryByEstateName(int name)
        {
            IDBManager manager = new DBManager();
            return manager.GetInventoryByEstateName(name);
        }
        public HttpStatusCode SaveInventory(InventoryModel inventory)
        {
            IDBManager manager = new DBManager();
            return manager.SaveInventory(inventory);
        }
    }
}