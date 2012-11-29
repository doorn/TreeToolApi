using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using DAL;
namespace Api.Services
{
    public class EstateService
    {
        public IEnumerable<EstateModel> GetEstates(){
            IDBManager manager = new DBManager();
            return manager.GetEstates();
        }
    }
}