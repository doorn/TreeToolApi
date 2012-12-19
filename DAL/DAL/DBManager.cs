using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Net;
using System.Web;
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

         public IEnumerable<TreeInventoryModel> GetTreeInventoryByEstateName(int name)
         {
             return GetInventoryMockData(name);
         }

         public HttpStatusCode SaveInventory(TreeInventoryModel inventory)
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
         //InventoryModel GetInventoryByEstateNameFromMock(int name) {
         //    return GetInventoryMockData(name);
         //}

         void SaveInventoryToDB(TreeInventoryModel inventory)
         {
             TreeToolOrebrollEntities ent = new TreeToolOrebrollEntities();
             


             //Estate estateEntity =  ent.Estate.Where(e => e.Name.Equals(inventory.EstateName)).Single();
             //Performer performerEntity = ent.Performer.Where(p=>p.PerformerID.Equals(inventory.PerformerID)).Single();
             //Inventory inventoryEntity = new Inventory();
             //inventoryEntity.Date = DateTime.Now;
             //inventoryEntity.Estate = estateEntity;
             //inventoryEntity.Performer = performerEntity;
             //ent.Inventory.Add(inventoryEntity);
             
             //ent.SaveChanges();
             

             


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
         
         IEnumerable<TreeInventoryModel> GetInventoryMockData(int name) {
             List<TreeInventoryModel> inventories;
             try{
                 if (name != 71101) {
                     throw new KeyNotFoundException();
                 }
             
                 inventories = new List<TreeInventoryModel>();
                 TreeInventoryModel observ1 = new TreeInventoryModel();
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
                 observ1.TreeID = 1;
                 observ1.TreeSpecies = "koreagran";
                 observ1.AgeID = 2;

                 observ1.CoordX = 15.1425;
                 observ1.CoordY = 59.2100021;

                 TreeInventoryModel observ2 = new TreeInventoryModel();
                 observ2.DamageClassComment = "Brandskadad";
                 observ2.DamageClassID = 2;
                 observ2.DiseasesComment = "SARS";
                 observ2.DiseasesID = 4;
                 observ2.FungusComment = "Ännu mer svamp";
                 observ2.FungusID = 4;
                 observ2.Height = 8.9;
                 observ2.Perimeter = 140;
                 observ2.SafetyComment = "Livsfarligt träd";
                 observ2.SafetyID = 4;
                 observ2.TreeObservationComment = "30 år gammalt";
                 observ2.TreeSpeciesID = 16;
                 observ2.VitalityComment = "Lite halv dåligt kondition";
                 observ2.VitalityID = 3;
                 observ2.TreeID = 2;
                 observ2.TreeSpecies = "Björk";
                 observ2.AgeID = 1;

                 observ2.CoordX = 15.1445;
                 observ2.CoordY = 59.2300021;
                 TreeInventoryModel observ3 = new TreeInventoryModel();
                 observ3.DamageClassComment = "Brandskadad";
                 observ3.DamageClassID = 2;
                 observ3.DiseasesComment = "SARS";
                 observ3.DiseasesID = 4;
                 observ3.FungusComment = "Ännu mer svamp";
                 observ3.FungusID = 4;
                 observ3.Height = 8.9;
                 observ3.Perimeter = 140;
                 observ3.SafetyComment = "Livsfarligt träd";
                 observ3.SafetyID = 4;
                 observ3.TreeObservationComment = "30 år gammalt";
                 observ3.TreeSpeciesID = 16;
                 observ3.VitalityComment = "Lite halv dåligt kondition";
                 observ3.VitalityID = 3;
                 observ3.TreeID = 3;
                 observ3.TreeSpecies = "Ek";

                 observ3.CoordX = 15.1465;
                 observ3.CoordY = 59.2400021;
                 observ3.AgeID = 3;
                 
                 TreeInventoryModel observ4 = new TreeInventoryModel();
                 observ4.DamageClassComment = "Brandskadad";
                 observ4.DamageClassID = 2;
                 observ4.DiseasesComment = "SARS";
                 observ4.DiseasesID = 4;
                 observ4.FungusComment = "Ännu mer svamp";
                 observ4.FungusID = 4;
                 observ4.Height = 8.9;
                 observ4.Perimeter = 140;
                 observ4.SafetyComment = "Livsfarligt träd";
                 observ4.SafetyID = 4;
                 observ4.TreeObservationComment = "30 år gammalt";
                 observ4.TreeSpeciesID = 16;
                 observ4.VitalityComment = "Lite halv dåligt kondition";
                 observ4.VitalityID = 3;
                 observ4.TreeID = 4;
                 observ4.TreeSpecies = "Tall";
                 observ4.AgeID = 4;

                 observ4.CoordX = 15.1485;
                 observ4.CoordY = 59.2600021;

                 inventories.Add(observ1);
                 inventories.Add(observ2);
                 inventories.Add(observ3);
                 inventories.Add(observ4);
                 
             }
             catch(Exception ex){
                throw new KeyNotFoundException();
             }
             return inventories;
         }

        /// <summary>
        /// Gets standard protocol from database.
        /// </summary>
        /// <returns>Protocol Model</returns>
         ProtocolModel GetProtocolFromDB() {

             TreeToolOrebrollEntities ent = new TreeToolOrebrollEntities();
             
             var protocol = new ProtocolModel();
             var observationTypes = new ObservationTypeCollection();
             
             protocol.TreeSpecies = (ent.TreeSpecies.Select(t=> new TreeSpeciesModel{ ID = t.TreeSpeciesID, Name = t.SwedishName}));
             observationTypes.ActionNeedsTimeType = (ent.ActionNeedsTimeType.Select(t => new ObservationTypeModel { ID = t.ActionNeedsTimeID, Value = t.Value }));
             observationTypes.ActionNeedsType = (ent.ActionNeedsType.Select(t => new ActionNeedsTypeModel { ID = t.ActionNeedsID, Value = t.Value}));
             observationTypes.DamageClassType = (ent.DamageClassType.Select(t => new ObservationTypeModel { ID = t.DamageClassID, Value = t.Value }));
             observationTypes.DiseasesType = (ent.DiseasesType.Select(t => new ObservationTypeModel { ID = t.DiseasesID, Value = t.Value }));
             observationTypes.FungusType = (ent.FungusType.Select(t => new ObservationTypeModel { ID = t.FungusID, Value = t.Value }));
             observationTypes.SafetyType = (ent.SafetyType.Select(t => new ObservationTypeModel { ID = t.SafetyID, Value = t.Value }));
             observationTypes.VitalityType = (ent.VitalityType.Select(t => new ObservationTypeModel { ID = t.VitalityID, Value = t.Value }));
             observationTypes.AgeType = (ent.AgeType.Select(t => new AgeTypeModel { ID = t.AgeID, Value = t.Value }));
             
             protocol.ObservationTypes = observationTypes;
             return protocol;
         }


        /// <summary>
        /// Gets all estates from database
        /// </summary>
        /// <returns>Returns multiple estate models.</returns>
         IEnumerable<EstateModel> GetEstatesFromDB() {
             TreeToolOrebrollEntities ent = new TreeToolOrebrollEntities();
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
