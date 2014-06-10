using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GardenEntities;
using System.Data;
using System.Data.SqlServerCe;
using System.IO;

namespace GardenDAL
{
    public class GardenDAO
    {
        //string conString = Properties.Settings.Default.GardenConnectionString;
        string conString = @"Data Source = E:\Programming\WcfGardenService\WcfGardenService\GardenDAO\Garden.sdf";

        public bool AddPlant(GardenEntity newPlant)
        {
            throw new NotImplementedException();
        }

        public bool RemovePlant(GardenEntity removePlant)
        {
            throw new NotImplementedException();
        }

        public List<GardenEntity> ViewAllPlantsInGarden()
        {
            List<GardenEntity> gardenEntities = new List<GardenEntity>();

            using (SqlCeConnection con = new SqlCeConnection(conString))
            {
                try
                {
                    con.Open();
                }
                catch (SqlCeException ee)
                {
                    //unable to open SqlCe connection
                    SqlCeErrorCollection errorCollection = ee.Errors;
                    StringBuilder bld = new StringBuilder();
                    Exception inner = ee.InnerException;

                    if (inner != null)
                    {
                        bld.AppendLine("Inner Exception: " + inner.ToString());
                    }

                    foreach (SqlCeError err in errorCollection)
                    {
                        bld.AppendLine(err.ToString());
                    }

                }

                using(SqlCeCommand com = new SqlCeCommand("SELECT * FROM Plant",con))
                {
                    SqlCeDataReader reader = com.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        try
                        {

                            AddReaderToGardenEntityList(gardenEntities, reader);
                        }
                        catch (Exception)
                        {
                            //unable to parse datas
                        }
                    }
                }
            }
            return gardenEntities;
        }

        private void AddReaderToGardenEntityList(List<GardenEntity> gardenEntities, SqlCeDataReader reader)
        {
            GardenEntity gardenEntity = new GardenEntity();
            gardenEntity.name = (string)reader["name"];
            gardenEntity.description = (string)reader["description"];
            gardenEntity.maintenance = (string)reader["maintenance"];
            gardenEntity.lightExposure = (GardenEntity.sunExposure)Enum.Parse(typeof(GardenEntity.sunExposure), (reader["LightExposure"]).ToString());
            gardenEntity.type = (GardenEntity.plantType)Enum.Parse(typeof(GardenEntity.plantType), (reader["Type"]).ToString());
            gardenEntity.coldestHardiness = (GardenEntity.hardinessZone)Enum.Parse(typeof(GardenEntity.hardinessZone), (reader["WithStandColdestZone"]).ToString());
            gardenEntity.hottestHardiness = (GardenEntity.hardinessZone)Enum.Parse(typeof(GardenEntity.hardinessZone), (reader["WithStandHottestZone"]).ToString());
            gardenEntity.seedStartMonths = DAOSeedStartMonthsToGardenEntitySeedStartMonths((string)reader["SeedStartMonths"]);
            gardenEntities.Add(gardenEntity);
        }

        public List<GardenEntity> ListAnnual()
        {
            List<GardenEntity> gardenEntities = new List<GardenEntity>();

            using (SqlCeConnection con = new SqlCeConnection(conString))
            {
                try
                {
                    con.Open();
                }
                catch (SqlCeException ee)
                {
                    //unable to open SqlCe connection
                    SqlCeErrorCollection errorCollection = ee.Errors;
                    StringBuilder bld = new StringBuilder();
                    Exception inner = ee.InnerException;

                    if (inner != null)
                    {
                        bld.AppendLine("Inner Exception: " + inner.ToString());
                    }

                    foreach (SqlCeError err in errorCollection)
                    {
                        bld.AppendLine(err.ToString());
                    }

                }

                using (SqlCeCommand com = new SqlCeCommand("SELECT Plant.ID, Plant.Name, Plant.Description, Plant.Maintenance, Plant.Type, Plant.LightExposure, Plant.SeedStartMonths, Plant.WithstandColdestZone, Plant.WithstandHottestZone, PlantType.ID AS Expr1, PlantType.Type AS Expr2 FROM  Plant INNER JOIN PlantType ON Plant.Type = PlantType.ID WHERE (PlantType.Type = 'Annual')", con))
                {
                    SqlCeDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {

                            AddReaderToGardenEntityList(gardenEntities, reader);
                        }
                        catch (Exception)
                        {
                            //unable to parse datas
                        }
                    }
                }
            }
            return gardenEntities;
        }

        public List<GardenEntity> ListPerenial()
        {
            List<GardenEntity> gardenEntities = new List<GardenEntity>();

            using (SqlCeConnection con = new SqlCeConnection(conString))
            {
                try
                {
                    con.Open();
                }
                catch (SqlCeException ee)
                {
                    //unable to open SqlCe connection
                    SqlCeErrorCollection errorCollection = ee.Errors;
                    StringBuilder bld = new StringBuilder();
                    Exception inner = ee.InnerException;

                    if (inner != null)
                    {
                        bld.AppendLine("Inner Exception: " + inner.ToString());
                    }

                    foreach (SqlCeError err in errorCollection)
                    {
                        bld.AppendLine(err.ToString());
                    }

                }

                using (SqlCeCommand com = new SqlCeCommand("SELECT Plant.ID, Plant.Name, Plant.Description, Plant.Maintenance, Plant.Type, Plant.LightExposure, Plant.SeedStartMonths, Plant.WithstandColdestZone, Plant.WithstandHottestZone, PlantType.ID AS Expr1, PlantType.Type AS Expr2 FROM  Plant INNER JOIN PlantType ON Plant.Type = PlantType.ID WHERE (PlantType.Type = 'perenial')", con))
                {
                    SqlCeDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {

                            AddReaderToGardenEntityList(gardenEntities, reader);
                        }
                        catch (Exception)
                        {
                            //unable to parse datas
                        }
                    }
                }
            }
            return gardenEntities;
        }

        public List<GardenEntity> ListPlantsInZone(GardenEntity.hardinessZone myZone)
        {
            List<GardenEntity> gardenEntities = new List<GardenEntity>();

            using (SqlCeConnection con = new SqlCeConnection(conString))
            {
                try
                {
                    con.Open();
                }
                catch (SqlCeException ee)
                {
                    //unable to open SqlCe connection
                    SqlCeErrorCollection errorCollection = ee.Errors;
                    StringBuilder bld = new StringBuilder();
                    Exception inner = ee.InnerException;

                    if (inner != null)
                    {
                        bld.AppendLine("Inner Exception: " + inner.ToString());
                    }

                    foreach (SqlCeError err in errorCollection)
                    {
                        bld.AppendLine(err.ToString());
                    }

                }

                using (SqlCeCommand com = new SqlCeCommand("SELECT * FROM Plant WHERE Plant.WithstandColdestZone <= '" + (int)myZone+"' AND Plant.WithstandHottestZone >= '"+(int)myZone+"'", con))
                {
                    SqlCeDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {

                            AddReaderToGardenEntityList(gardenEntities, reader);
                        }
                        catch (Exception)
                        {
                            //unable to parse datas
                        }
                    }
                }
            }
            return gardenEntities;
        }

        public List<GardenEntity> ListPlantsRequireThisSunExposure(GardenEntity.sunExposure mySun)
        {
            List<GardenEntity> gardenEntities = new List<GardenEntity>();

            using (SqlCeConnection con = new SqlCeConnection(conString))
            {
                try
                {
                    con.Open();
                }
                catch (SqlCeException ee)
                {
                    //unable to open SqlCe connection
                    SqlCeErrorCollection errorCollection = ee.Errors;
                    StringBuilder bld = new StringBuilder();
                    Exception inner = ee.InnerException;

                    if (inner != null)
                    {
                        bld.AppendLine("Inner Exception: " + inner.ToString());
                    }

                    foreach (SqlCeError err in errorCollection)
                    {
                        bld.AppendLine(err.ToString());
                    }

                }

                using (SqlCeCommand com = new SqlCeCommand("SELECT * FROM Plant WHERE Plant.LightExposure = '"+(int)mySun+"'", con))
                {
                    SqlCeDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {

                            AddReaderToGardenEntityList(gardenEntities, reader);
                        }
                        catch (Exception)
                        {
                            //unable to parse datas
                        }
                    }
                }
            }
            return gardenEntities;
        }

        public List<GardenEntity> PlantsToPlantInThisMonth(GardenEntity.Month thisMonth)
        {
            List<GardenEntity> gardenEntities = new List<GardenEntity>();

            using (SqlCeConnection con = new SqlCeConnection(conString))
            {
                try
                {
                    con.Open();
                }
                catch (SqlCeException ee)
                {
                    //unable to open SqlCe connection
                    SqlCeErrorCollection errorCollection = ee.Errors;
                    StringBuilder bld = new StringBuilder();
                    Exception inner = ee.InnerException;

                    if (inner != null)
                    {
                        bld.AppendLine("Inner Exception: " + inner.ToString());
                    }

                    foreach (SqlCeError err in errorCollection)
                    {
                        bld.AppendLine(err.ToString());
                    }

                } 

                string tmp = ( (int) thisMonth ).ToString();
                using (SqlCeCommand com = new SqlCeCommand("SELECT * FROM Plant WHERE SeedStartMonths LIKE '% " + tmp + " %'", con))
                {
                    SqlCeDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {

                            AddReaderToGardenEntityList(gardenEntities, reader);
                        }
                        catch (Exception)
                        {
                            //unable to parse datas
                        }
                    }
                }
            }
            return gardenEntities;
        }

        //method use to convert format 1 2 11 12 of SeedStartMonths into a List<GardenEntity.Month>
        //using the space as seperator
        private List<GardenEntity.Month> DAOSeedStartMonthsToGardenEntitySeedStartMonths(string seedMonths)
        {
            List<GardenEntity.Month> monthList = new List<GardenEntity.Month>();
            if (seedMonths.Length > 0)
            {
                string[] arr = seedMonths.Split();

                foreach (string s in arr)
                {
                    try
                    {
                        monthList.Add((GardenEntity.Month)Enum.Parse(typeof(GardenEntity.Month),s));
                    }
                    catch
                    {
                        //unable to parse data for List<GardenEntity.Month>
                    }
                }
            }
            else
            {
                //seedMonths can't be empty, invalid data
            }


            return monthList;
        }
    }
}
