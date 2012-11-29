using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class DBManager : IDBManager
    {
         public ProtocolModel GetProtocol()
         {
             return GetProtocolFromDB();
         }
         public IEnumerable<EstateModel> GetEstates()
         {
             return GetEstatesFromDB();
         }

         public void GetInventoryByEstateNameID(int name)
         {
             throw new NotImplementedException();
         }

         public void SaveInventory(string ngtvarde)
         {
             throw new NotImplementedException();
         }



        /// <summary>
        /// Gets standard protocol from database.
        /// </summary>
        /// <returns>Protocol Model</returns>
         ProtocolModel GetProtocolFromDB() {
             TreeToolEntities ent = new TreeToolEntities();
             var protocol = new ProtocolModel();
             protocol.TreeSpecies = (ent.TreeSpecies.Select(t=> new TreeSpeciesModel{ ID = t.TreeSpeciesID, Name = t.SwedishName}));
             protocol.ActionNeedsTimeType = (ent.ActionNeedsTimeType.Select(t=> new ObservationType{ ID = t.ActionNeedsTimeID, Value= t.Value}));
             protocol.ActionNeedsType = (ent.ActionNeedsType.Select(t=> new ObservationType{ ID = t.ActionNeedsID, Value= t.Value}));
             protocol.DamageClassType = (ent.DamageClassType.Select(t=> new ObservationType{ ID = t.DamageClassID, Value= t.Value}));
             protocol.DiseasesType = (ent.DiseasesType.Select(t=> new ObservationType{ ID = t.DiseasesID, Value= t.Value}));
             protocol.FungusType = (ent.FungusType.Select(t=> new ObservationType{ ID = t.FungusID, Value= t.Value}));
             protocol.SafetyType = (ent.SafetyType.Select(t=> new ObservationType{ ID = t.SafetyID, Value= t.Value}));
             protocol.VitalityType = (ent.VitalityType.Select(t=> new ObservationType{ ID = t.VitalityID, Value= t.Value}));
             return protocol;
         }


        /// <summary>
        /// Gets all estates from database
        /// </summary>
        /// <returns>Returns multiple estate models.</returns>
         IEnumerable<EstateModel> GetEstatesFromDB() {
             TreeToolEntities ent = new TreeToolEntities();
             var estates = (from e in ent.Estate
                            select new EstateModel
                            {
                                Name = e.Name,
                                Title = e.Title,
                                X = e.CoordiX,
                                Y =  e.CoordiY
                            });
             return estates;
         }
    }
}
