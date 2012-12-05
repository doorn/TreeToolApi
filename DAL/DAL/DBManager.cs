using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Net;
//using System.Data;

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

         public InventoryModel GetInventoryByEstateName(int name)
         {
             return GetInventoryByEstateNameFromMock(name);
         }

         public HttpStatusCode SaveInventory(InventoryModel inventory)
         {
             try
             {
                 SaveInventoryToDB(inventory);
                 return HttpStatusCode.Created;
             }
             catch (Exception ex) {
                 return HttpStatusCode.BadRequest;
             }
         }
         InventoryModel GetInventoryByEstateNameFromMock(int name) {
             return GetInventoryMockData();
         }

         


         void SaveInventoryToDB(InventoryModel inventory)
         {
             TreeToolEntities ent = new TreeToolEntities();
             


             Estate estateEntity =  ent.Estate.Where(e => e.Name.Equals(inventory.EstateName)).Single();
             Performer performerEntity = ent.Performer.Where(p=>p.PerformerID.Equals(inventory.PerformerID)).Single();
             Inventory inventoryEntity = new Inventory();
             inventoryEntity.Date = DateTime.Now;
             inventoryEntity.Estate = estateEntity;
             inventoryEntity.Performer = performerEntity;
             //ent.TreeObservation.add

             


            // inventoryEntity.TreeObservation = "";
             
         }
         //ICollection<TreeObservation> ConvertTreeObservationModelsToEntityCollection(IEnumerable<TreeObservationModel> treeObservations)
         //{
         //    ICollection<TreeObservation> treeObservationEntities = new List<TreeObservation>();
         //    foreach(TreeObservationModel tree in treeObservations){
         //        TreeObservation newTree = new TreeObservation{
         //           t
         //        };
         //        treeObservationEntities.Add(
         //    }
             

         //}
         void GetEstateByName(int name) {
             //TreeToolEntities ent = TreeToolEntities();
             //return 
         }
         
         InventoryModel GetInventoryMockData() {
             InventoryModel inventory = new InventoryModel
             {
                 Date = DateTime.Now.ToShortDateString(),
                 EstateName = 71101,
                 PerformerID = 1
             };
             List<TreeObservationModel> observations = new List<TreeObservationModel>();
             TreeObservationModel observ1 = new TreeObservationModel();
             observ1.DamageClassComment = "Brandskadad";
             observ1.DamageClassID = 2;
             observ1.DiseasesComment = "SARS";
             observ1.DiseasesID = 4;
             observ1.FungusComment = "Ännu mer svamp";
             observ1.FungusID = 4;
             observ1.Height = 8.9;
             observ1.Perimeter = 140;
             observ1.SafetyComment = "Livsfarligt träd";
             observ1.SafetyID = 4;
             observ1.TreeObservationComment = "30 år gammalt";
             observ1.TreeSpeciesID = 16;
             observ1.VitalityComment = "Lite halv dåligt kondition";
             observ1.VitalityID = 3;

             observ1.CoordX = 15.1425;
             observ1.CoordY = 59.2100021;

             TreeObservationModel observ2 = observ1;
             observ2.CoordX = 15.1699;
             observ2.CoordY = 59.2401;
             TreeObservationModel observ3 = observ1;
             observ3.CoordX = 15.1011;
             observ3.CoordY = 59.1000;
             TreeObservationModel observ4 = observ1;
             observ3.CoordX = 15.3015;
             observ3.CoordY = 59.29001;

             observations.Add(observ1);
             observations.Add(observ2);
             observations.Add(observ3);
             observations.Add(observ4);

             inventory.TreeObservations = observations;
             return inventory;
         }

        /// <summary>
        /// Gets standard protocol from database.
        /// </summary>
        /// <returns>Protocol Model</returns>
         ProtocolModel GetProtocolFromDB() {
             
             TreeToolEntities ent = new TreeToolEntities();
             

             var protocol = new ProtocolModel();
             var observationTypes = new ObservationTypeCollection();
             
             
             protocol.TreeSpecies = (ent.TreeSpecies.Select(t=> new TreeSpeciesModel{ ID = t.TreeSpeciesID, Name = t.SwedishName}));
             //protocol.ActionNeedsTimeType = (ent.ActionNeedsTimeType.Select(t=> new ObservationType{ ID = t.ActionNeedsTimeID, Value= t.Value}));
             //protocol.ActionNeedsType = (ent.ActionNeedsType.Select(t=> new ObservationType{ ID = t.ActionNeedsID, Value= t.Value}));
             observationTypes.DamageClassType = (ent.DamageClassType.Select(t => new ObservationType { ID = t.DamageClassID, Value = t.Value }));
             observationTypes.DiseasesType = (ent.DiseasesType.Select(t => new ObservationType { ID = t.DiseasesID, Value = t.Value }));
             observationTypes.FungusType = (ent.FungusType.Select(t => new ObservationType { ID = t.FungusID, Value = t.Value }));
             observationTypes.SafetyType = (ent.SafetyType.Select(t => new ObservationType { ID = t.SafetyID, Value = t.Value }));
             observationTypes.VitalityType = (ent.VitalityType.Select(t => new ObservationType { ID = t.VitalityID, Value = t.Value }));
             protocol.ObservationTypes = observationTypes;
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
