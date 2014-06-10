using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using GardenLogics;
using GardenEntities;

namespace WcfGardenService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class GardenService : IGardenService
    {
        GardenLogic gardenLogic = new GardenLogic();

        public List<Plant> ViewAllPlantsInGarden()
        {
            List<GardenEntity> gardenEntities = gardenLogic.ViewAllPlantsInGarden();
            List<Plant> gardenPlants = new List<Plant>();
            gardenPlants = TranslateGardenEntityToGardenContractData(gardenEntities);

            if (gardenEntities == null)
            {
                throw new FaultException<GardenFault>(new GardenFault("Entities in GardenService is null. ViewAllPlantsInGarden"));
            }

            return gardenPlants;
        }

        public List<Plant> ListAnnual()
        {
            List<GardenEntity> gardenEntities = gardenLogic.ListAnnual();
            List<Plant> gardenPlants = new List<Plant>();
            gardenPlants = TranslateGardenEntityToGardenContractData(gardenEntities);

            if (gardenEntities == null)
            {
                throw new FaultException<GardenFault>(new GardenFault("Entities in GardenService is null. ListAnnual"));
            }

            return gardenPlants;
        }

        public List<Plant> ListPerenial()
        {
            List<GardenEntity> gardenEntities = gardenLogic.ListPerenial();
            List<Plant> gardenPlants = new List<Plant>();
            gardenPlants = TranslateGardenEntityToGardenContractData(gardenEntities);

            if (gardenEntities == null)
            {
                throw new FaultException<GardenFault>(new GardenFault("Entities in GardenService is null. ListPerenial"));
            }

            return gardenPlants;
        }

        public List<Plant> ListPlantsInZone(hardinessZone myZone)
        {
            List<GardenEntity> gardenEntities = gardenLogic.ListPlantsInZone((GardenEntity.hardinessZone)myZone);
            List<Plant> gardenPlants = new List<Plant>();
            gardenPlants = TranslateGardenEntityToGardenContractData(gardenEntities);

            if (gardenEntities == null)
            {
                throw new FaultException<GardenFault>(new GardenFault("Entities in GardenService is null. ListPlantsInZone"));
            }

            return gardenPlants;
        }

        public List<Plant> ListPlantsRequireThisSunExposure(sunExposure mySun)
        {
            List<GardenEntity> gardenEntities = gardenLogic.ListPlantsRequireThisSunExposure((GardenEntity.sunExposure)mySun);
            List<Plant> gardenPlants = new List<Plant>();
            gardenPlants = TranslateGardenEntityToGardenContractData(gardenEntities);

            if (gardenEntities == null)
            {
                throw new FaultException<GardenFault>(new GardenFault("Entities in GardenService is null. ListPlantsRequireThisSunExposure"));
            }

            return gardenPlants;
        }

        public List<Plant> PlantsToPlantInThisMonth(Month thisMonth)
        {
            List<GardenEntity> gardenEntities = gardenLogic.PlantsToPlantInThisMonth((GardenEntity.Month)thisMonth);
            List<Plant> gardenPlants = new List<Plant>();
            gardenPlants = TranslateGardenEntityToGardenContractData(gardenEntities);

            if (gardenEntities == null)
            {
                throw new FaultException<GardenFault>(new GardenFault("Entities in GardenService is null. PlantsToPlantInThisMonth"));
            }

            return gardenPlants;
        }

        private List<Plant> TranslateGardenEntityToGardenContractData(List<GardenEntity> gardenEntities)
        {
            List<Plant> gardenPlantList = new List<Plant>();

            try
            {
                foreach (GardenEntity entity in gardenEntities)
                {
                    Plant gardenPlant = new Plant();
                    gardenPlant.coldestHardiness = (hardinessZone)entity.coldestHardiness;
                    gardenPlant.description = entity.description;
                    gardenPlant.hottestHardiness = (hardinessZone)entity.hottestHardiness;
                    gardenPlant.lightExposure = (sunExposure)entity.lightExposure;
                    gardenPlant.maintenance = entity.maintenance;
                    gardenPlant.name = entity.name;
                    gardenPlant.seedStartMonths = CopyseedStartMonths(entity.seedStartMonths);

                    gardenPlant.type = (plantType)entity.type;

                    gardenPlantList.Add(gardenPlant);
                }
            }
            catch( Exception e)
            {
                throw new FaultException<GardenFault>(new GardenFault("Error in TranslateGardenEntityToGardenContractData."+System.Environment.NewLine+e.ToString()));
            }

            return (gardenPlantList);
        }

        private List<Month> CopyseedStartMonths(List<GardenEntity.Month> monthList)
        {
            List<Month> plantMonthList = new List<Month>();

            foreach (GardenEntity.Month month in monthList)
            {
                plantMonthList.Add(((Month)month));
            }

            return plantMonthList;
        }
    }
}
