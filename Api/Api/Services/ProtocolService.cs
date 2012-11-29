using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using DAL;

namespace Api.Services
{
    public class ProtocolService
    {
        public ProtocolModel GetProtocol()
        {
            IDBManager manager = new DBManager();
            return manager.GetProtocol();
        }
    }
}